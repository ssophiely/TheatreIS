using ManagingTheatreApp.Client;
using ManagingTheatreApp.Interaction;
using ManagingTheatreApp.Interaction.Out;
using ManagingTheatreApp.ModalWindows;

namespace TheTheatre;

public partial class SpectaclesForm : Form
{
    public SpectaclesForm(string token)
    {
        InitializeComponent();
        Client = new(token);
    }

    public Form MenuForm { get; set; } = null!;


    public readonly SpectaclesClient Client;


    private async void SpectaclesForm_Load(object sender, EventArgs e)
    {

        await GetSpectacles();
        await GetEmployees();

        spec_genre.Items.Clear();
        foreach (var genre in _genres)
        {
            spec_genre.Items.Add(genre.Name);
        }
        spec_genre.SelectedIndex = 0;
    }

    private async Task GetSpectacles()
    {
        try
        {
            spec_dataGridView.Rows.Clear();

            DataGridViewComboBoxColumn comboColumn = (DataGridViewComboBoxColumn)spec_dataGridView.Columns["genre"];

            await UpdGenres(comboColumn);

            var specs = await Client.GetSpectacles();

            foreach (var spec in specs)
            {
                spec_dataGridView.Rows.Add(spec.Id, spec.Name, spec.Duration, spec.Genre, spec.Plot);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public async Task GetRoles(int id)
    {
        try
        {
            roles_dataGridView.Rows.Clear();

            var roles = await Client.GetRoles(id);

            foreach (var role in roles)
            {
                roles_dataGridView.Rows.Add(role.Id, role.Name, role.EmpName,
                    role.EmployeeId, role.EmpPosition, role.SpecName, role.SpecId);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task UpdGenres(DataGridViewComboBoxColumn comboColumn)
    {
        try
        {
            _genres = await Client.GetGenres();

            comboColumn.Items.Clear();

            foreach (var genre in _genres)
            {
                comboColumn.Items.Add(genre.Name);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task DeleteSpectacle(int id)
    {
        try
        {
            await Client.DeleteSpectacle(id);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task UpdateSpectacle(int rowInd)
    {
        var row = spec_dataGridView.Rows[rowInd];

        UpdateSpectacle info = new()
        {
            Name = (string)row.Cells[1].Value,
            Duration = Convert.ToDouble(row.Cells[2].Value),
            GenreId = _genres.First(g => g.Name == (string)row.Cells[3].Value).Id,
            Plot = row.Cells[4].Value?.ToString() ?? null
        };

        try
        {
            await Client.UpdateSpectacle((int)row.Cells[0].Value, info);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task GetEmployees()
    {
        try
        {
            _employees = await Client.GetEmployees();

            all_emps.Rows.Clear();

            foreach (var emp in _employees)
            {
                all_emps.Rows.Add(emp.Id, emp.FullName, emp.Experience, emp.Phone, emp.Position);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void spec_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == spec_dataGridView.Columns["roles"].Index)
        {
            await GetRoles((int)spec_dataGridView.Rows[e.RowIndex].Cells[0].Value);
            return;
        }

        if (e.ColumnIndex == spec_dataGridView.Columns["role_add"].Index)
        {
            var form = new AddRole((int)spec_dataGridView.Rows[e.RowIndex].Cells[0].Value) { Form = this, Emps = _employees };

            form.Show();

            return;
        }

        if (e.ColumnIndex == spec_dataGridView.Columns["delete"].Index)
        {
            await DeleteSpectacle((int)spec_dataGridView.Rows[e.RowIndex].Cells[0].Value);
            await GetSpectacles();
            roles_dataGridView.Rows.Clear();
            return;
        }

        if (e.ColumnIndex == spec_dataGridView.Columns["update"].Index)
        {
            await UpdateSpectacle(e.RowIndex);
            await GetSpectacles();
            roles_dataGridView.Rows.Clear();
            return;
        }
    }

    private void all_emps_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == all_emps.Columns["emp_add"].Index)
        {
            var cells = all_emps.Rows[e.RowIndex].Cells;
            spec_emps.Rows.Add(cells[0].Value, cells[1].Value, "");

            all_emps.Rows.RemoveAt(e.RowIndex);
            return;
        }
    }

    private void spec_emps_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == spec_emps.Columns["emp_del"].Index)
        {
            var id = (int)spec_emps.Rows[e.RowIndex].Cells[0].Value;

            spec_emps.Rows.RemoveAt(e.RowIndex);

            var emp = _employees.First(e => e.Id == id);
            all_emps.Rows.Add(emp.Id, emp.FullName, emp.Experience, emp.Phone, emp.Position);

            return;
        }
    }

    private async void create_btn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(name.Text) || hours.Value == 0)
        {
            MessageBox.Show($"Заполните данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        List<RoleCreateInfo> roles = new();

        foreach (DataGridViewRow row in spec_emps.Rows)
        {
            if (string.IsNullOrEmpty((string)row.Cells[2].Value))
                continue;

            roles.Add(new RoleCreateInfo() { EmployeeId = (int)row.Cells[0].Value, Name = (string)row.Cells[2].Value });
        }

        if (roles.Count == 0)
        {
            MessageBox.Show($"Заполните данные об участниках спектакля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var info = new CreateSpectacle()
        {
            Name = name.Text,
            Plot = string.IsNullOrEmpty(spec_plot.Text) ? null : spec_plot.Text,
            GenreId = _genres.First(g => g.Name == spec_genre.Text).Id,
            Duration = (double)hours.Value,
            Roles = roles
        };

        try
        {
            await Client.CreateSpectacle(info);
            await GetSpectacles();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        await GetSpectacles();

        name.Text = string.Empty;
        spec_plot.Text = string.Empty;
        hours.Value = 0;
        spec_emps.Rows.Clear();
        await GetEmployees();
    }


    private async void roles_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == roles_dataGridView.Columns["role_change"].Index)
        {
            var form = new ChangeRole(_employees, (int)roles_dataGridView.Rows[e.RowIndex].Cells[0].Value,
                (int)roles_dataGridView.Rows[e.RowIndex].Cells[6].Value, (int)roles_dataGridView.Rows[e.RowIndex].Cells[3].Value)
            { Form = this, Role = (string)roles_dataGridView.Rows[e.RowIndex].Cells[1].Value };
            form.Show();
            return;
        }

        if (e.ColumnIndex == roles_dataGridView.Columns["role_del"].Index)
        {
            try
            {
                await Client.DeleteRole((int)roles_dataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await GetRoles((int)roles_dataGridView.Rows[e.RowIndex].Cells[6].Value);
            return;
        }
    }











    private List<GenreInfo> _genres = new List<GenreInfo>();

    private List<EmployeeInfo> _employees = new List<EmployeeInfo>();
}

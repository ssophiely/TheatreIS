using ManagingTheatreApp.Client;
using System.Windows.Forms;

namespace TheTheatre;

public partial class SpectaclesForm : Form
{
    public SpectaclesForm()
    {
        InitializeComponent();
    }

    public Form MenuForm { get; set; } = null!;

    public string Token { get; set; } = null!;


    private readonly SpectaclesClient _client = new();

    private async void SpectaclesForm_Load(object sender, EventArgs e)
    {

        await GetSpectacles();
    }

    private async Task GetSpectacles()
    {
        try
        {
            var genres = await _client.GetGenres();

            DataGridViewComboBoxColumn comboColumn = (DataGridViewComboBoxColumn)spec_dataGridView.Columns["genre"];

            comboColumn.Items.Clear();

            foreach (var genre in genres)
            {
                comboColumn.Items.Add(genre.Name);
            }

            var specs = await _client.GetSpectacles();

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

    private async Task GetRoles(int id)
    {
        try
        {
            var spec = await _client.GetSpectacle(id);

            foreach (var role in spec.Role)
            {
                roles_dataGridView.Rows.Add(role.Name, role.EmpName, role.EmpPosition, spec.Name);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task UpdGenres(DataGridViewComboBoxCell cell)
    {
        try
        {
            var genres = await _client.GetGenres();

            cell.Items.Clear();

            foreach (var genre in genres)
            {
                cell.Items.Add(genre.Name);
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
            roles_dataGridView.Rows.Clear();
            await GetRoles((int)spec_dataGridView.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}

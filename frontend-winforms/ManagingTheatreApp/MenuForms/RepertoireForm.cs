using ManagingTheatreApp.Client;
using ManagingTheatreApp.Interaction;

namespace ManagingTheatreApp.MenuForms;

public partial class RepertoireForm : Form
{
    public RepertoireForm(string token)
    {
        InitializeComponent();
        Client = new(token);
        TicketsClient = new(token);
    }

    public Form MenuForm { get; set; } = null!;


    public readonly RepClient Client;
    public readonly TicketsClient TicketsClient;

    private List<RepInfo>? _reps;

    private async void RepertoireForm_Load(object sender, EventArgs e)
    {
        await GetRepertoire();
    }

    private async Task GetRepertoire()
    {
        try
        {
            rep_table.Rows.Clear();

            _reps = await Client.GetRepertoire();

            foreach (var rep in _reps)
            {
                rep_table.Rows.Add(rep.Id, $"{rep.Date.Year}.{rep.Date.Month}", rep.Spectacle.Name, rep.BoxOffice, rep.Rating);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task GetActs(int id, string spec)
    {
        try
        {
            acts_table.Rows.Clear();

            var acts = await Client.GetActs(id);

            foreach (var act in acts)
            {
                acts_table.Rows.Add(act.Id, act.Date, spec, act.SpectacleId);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Close_Click(object sender, EventArgs e)
    {
        MenuForm.Show();
        Close();
    }

    private async void rep_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == rep_table.Columns["acts"].Index)
        {
            await GetActs((int)rep_table.Rows[e.RowIndex].Cells[0].Value, (string)rep_table.Rows[e.RowIndex].Cells[2].Value);
            return;
        }

        if (e.ColumnIndex == rep_table.Columns["rep_del"].Index)
        {
            if ((int)rep_table.Rows[e.RowIndex].Cells[3].Value > 0)
            {
                MessageBox.Show($"Нельзя удалить спектакль из репертуара, т.к. на него были куплены билеты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                await Client.DeleteRepertoire((int)rep_table.Rows[e.RowIndex].Cells[0].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await GetRepertoire();

            return;
        }
    }

    private async void acts_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == acts_table.Columns["act_del"].Index)
        {
            try
            {
                if (await TicketsClient.CheckTickets((int)acts_table.Rows[e.RowIndex].Cells[0].Value))
                {
                    MessageBox.Show($"Нельзя удалить показ, есть оплаченные билеты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await Client.DeleteAct((int)acts_table.Rows[e.RowIndex].Cells[0].Value);

                await GetActs((int)acts_table.Rows[e.RowIndex].Cells[3].Value, (string)acts_table.Rows[e.RowIndex].Cells[2].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

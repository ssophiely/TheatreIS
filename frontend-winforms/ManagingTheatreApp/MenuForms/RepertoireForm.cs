using ManagingTheatreApp.Client;
using ManagingTheatreApp.Interaction;
using ManagingTheatreApp.Interaction.Out;
using System.Globalization;

namespace ManagingTheatreApp.MenuForms;

public partial class RepertoireForm : Form
{
    public RepertoireForm(string token)
    {
        InitializeComponent();
        Client = new(token);
        TicketsClient = new(token);
        SpecClient = new(token);
    }

    public Form MenuForm { get; set; } = null!;


    public readonly RepClient Client;
    public readonly TicketsClient TicketsClient;
    public readonly SpectaclesClient SpecClient;

    private List<RepInfo>? _reps;

    private async void RepertoireForm_Load(object sender, EventArgs e)
    {
        await GetRepertoire();

        act_date.CustomFormat = "dd.MM.yyyy HH:mm";
        rep_date.CustomFormat = "MM.yyyy";

        var spectacles = await GetSpectacles();

        foreach (var spec in spectacles)
        {
            specs.Items.Add(spec);
        }
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

    private async Task<List<SpectacleInfo>> GetSpectacles()
    {
        try
        {
            return await SpecClient.GetSpectacles();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception();
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
                acts_table.Rows.Add(act.Id, act.Date.AddHours(-3), spec, act.RepertoireId);
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

    private async void add_act_Click(object sender, EventArgs e)
    {
        string date = act_date.Text;
        int repId = (int)this.repId.Value;

        try
        {
            await Client.AddAct(new CreateAct() { Date = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture), RepertoireId = repId });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MessageBox.Show($"Показ успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async void add_rep_Click(object sender, EventArgs e)
    {
        string date = rep_date.Text;
        var selectedSpecs = specs.CheckedItems;

        foreach (var spec in selectedSpecs)
        {
            var spectacle = spec as SpectacleInfo;

            if (spectacle != null)
            {

                try
                {
                    await Client.AddRepertoire(new CreateRep() { Date = DateTime.ParseExact(date, "MM.yyyy", CultureInfo.InvariantCulture), SpectacleId = spectacle.Id });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось добавить спектакль {spectacle.Name}: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        await GetRepertoire();
    }
}

using ManagingTheatreApp.Client;

namespace ManagingTheatreApp.MenuForms;

public partial class StatisticsForm : Form
{
    public StatisticsForm(string token)
    {
        InitializeComponent();

        Client = new(token);
    }

    public Form MenuForm { get; set; } = null!;


    public readonly StatisticsClient Client;

    private async Task GetBoxOffice()
    {
        try
        {
            var result = await Client.GetBoxOffice();

            foreach (var item in result)
            {
                box_table.Rows.Add(item.Name, item.TotalBoxOffice);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task GetSoldTickets()
    {
        try
        {
            var tickets = await Client.GetTickets();

            foreach (var t in tickets)
            {
                tickets_table.Rows.Add($"{t.Month}.{t.Year}", t.TicketsCount);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void StatisticsForm_Load(object sender, EventArgs e)
    {
        await GetBoxOffice();
        await GetSoldTickets();
    }

    private void Menu_Click(object sender, EventArgs e)
    {
        MenuForm.Show();
        Close();
    }
}

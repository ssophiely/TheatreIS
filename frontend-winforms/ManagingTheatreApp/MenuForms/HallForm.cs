using ManagingTheatreApp.Client;

namespace ManagingTheatreApp.MenuForms;

public partial class LocationForm : Form
{
    public LocationForm(string token)
    {
        InitializeComponent();
        Client = new(token);
    }

    public Form MenuForm { get; set; } = null!;


    public readonly TicketsClient Client;

    private void HallForm_Load(object sender, EventArgs e)
    {

    }

    private async void locations_btn_Click(object sender, EventArgs e)
    {
        var id = (int)act_id.Value;

        await GetLocations(id);
    }

    private async Task GetLocations(int id)
    {
        try
        {
            loc_table.Rows.Clear();

            var locations = await Client.GetLocations(id);

            foreach (var loc in locations)
            {
                loc_table.Rows.Add(loc.Id, loc.Row, loc.Seat, loc.Sector, loc.Price, loc.State);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void price_btn_Click(object sender, EventArgs e)
    {
        var price = this.price.Value;

        var selectedRows = loc_table.Rows.Cast<DataGridViewRow>()
                            .Where(row => row.Cells["change"].Value != null &&
                                          row.Cells["change"].Value.Equals(true))
                            .ToList();

        foreach (var row in selectedRows)
        {
            if ((string)row.Cells[5].Value == "Свободно")
            {
                try
                {
                    await Client.ChangePrice(new Interaction.Out.ChangePrice()
                    {
                        Id = (int)row.Cells[0].Value,
                        Price = price
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Нельзя поменять цену, место забронировано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        await GetLocations((int)act_id.Value);
    }

    private void Close_Click(object sender, EventArgs e)
    {
        MenuForm.Show();
        Close();
    }
}

using ManagingTheatreApp.Interaction;
using ManagingTheatreApp.Interaction.Out;
using TheTheatre;

namespace ManagingTheatreApp.ModalWindows;

public partial class AddRole : Form
{
    public AddRole(int id)
    {
        InitializeComponent();

        _specId = id;
    }

    public SpectaclesForm Form { get; set; } = null!;

    public List<EmployeeInfo> Emps { get; set; } = null!;


    private readonly int _specId;

    private void AddRole_Load(object sender, EventArgs e)
    {
        foreach (var emp in Emps)
        {
            emps.Items.Add(emp);
        }

        emps.DisplayMember = "FullName";
        emps.SelectedItem = Emps[0];
    }

    private async void add_btn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(role.Text))
        {
            MessageBox.Show($"Введите название роли!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            await Form.Client.AddRole(new CreateRole()
            {
                Name = role.Text,
                EmployeeId = (emps.SelectedItem as EmployeeInfo)!.Id,
                SpectacleId = _specId
            });

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}

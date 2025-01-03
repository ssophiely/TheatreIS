using ManagingTheatreApp.Interaction;
using ManagingTheatreApp.Interaction.Out;
using TheTheatre;

namespace ManagingTheatreApp.ModalWindows;

public partial class ChangeRole : Form
{
    public ChangeRole(List<EmployeeInfo> emps, int id, int specId, int empId)
    {
        InitializeComponent();
        _id = id;
        _emps = emps;
        _specId = specId;
        _empId = empId;
    }

    public SpectaclesForm Form { get; set; } = null!;

    public string Role { get; set; } = null!;

    private readonly int _id;

    private readonly int _specId;

    private readonly int _empId;

    private readonly List<EmployeeInfo> _emps;

    private void ChangeRole_Load(object sender, EventArgs e)
    {
        role.Text = Role;

        foreach (var emp in _emps)
        {
            emps.Items.Add(emp);
        }

        emps.DisplayMember = "FullName";
        emps.SelectedItem = _emps.First(e => e.Id == _empId);
    }

    private async void change_btn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(role.Text))
        {
            MessageBox.Show($"Введите название роли!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            await Form.Client.UpdateRole(_id, new UpdateRole()
            { Name = role.Text, EmployeeId = (emps.SelectedItem as EmployeeInfo)!.Id });

            await Form.GetRoles(_specId);

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}

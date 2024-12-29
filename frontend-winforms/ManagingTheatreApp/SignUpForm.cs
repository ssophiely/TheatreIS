using ManagingTheatreApp.Client;
namespace ManagingTheatreApp;

public partial class SignUpForm : Form
{
    public SignUpForm()
    {
        InitializeComponent();
    }

    public SignInForm SignInForm = null!;

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        // Открываем форму входа
        SignInForm.Show();

        Close();
    }

    private async void signup_btn_Click(object sender, EventArgs e)
    {
        var login = this.login.Text;
        var pas = password.Text;
        var pas2 = password2.Text;

        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pas) || string.IsNullOrEmpty(pas2))
        {
            MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (pas != pas2)
        {
            MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            await _client.AddAdmin(login, pas);

            SignInForm.Show();

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private readonly AuthenticationClient _client = new AuthenticationClient();
}

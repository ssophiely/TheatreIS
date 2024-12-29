using ManagingTheatreApp.Client;

namespace ManagingTheatreApp;

public partial class SignInForm : Form
{
    public SignInForm()
    {
        InitializeComponent();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        SignUpForm form2 = new() { SignInForm = this };
        form2.Show();

        Hide();
    }

    private async void signin_btn_Click(object sender, EventArgs e)
    {
        var login = this.login.Text;
        var pas = this.password.Text;

        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pas))
        {
            MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            var jwt = await _client.VerifyAdmin(login, pas);

            var form = new MenuForm() { SignInForm = this, Token = jwt };
            form.Show();

            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private readonly AuthenticationClient _client = new AuthenticationClient();
}

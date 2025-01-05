using ManagingTheatreApp.MenuForms;
using TheTheatre;

namespace ManagingTheatreApp;

public partial class MenuForm : Form
{
    public MenuForm()
    {
        InitializeComponent();
    }

    public string Token { get; set; } = null!;

    public SignInForm SignInForm { get; set; } = null!;


    private void exit_btn_Click(object sender, EventArgs e)
    {
        SignInForm.Show();

        Close();
    }

    private void spec_btn_Click(object sender, EventArgs e)
    {
        var form = new SpectaclesForm(Token) { MenuForm = this };
        form.Show();

        Hide();
    }

    private void rep_btn_Click(object sender, EventArgs e)
    {
        var form = new RepertoireForm(Token) { MenuForm = this };
        form.Show();

        Hide();
    }

    private void stat_btn_Click(object sender, EventArgs e)
    {
        var form = new StatisticsForm(Token) { MenuForm = this };
        form.Show();

        Hide();
    }
}

namespace Homework_Studios_Launcher;

public partial class StartForm : Form
{
    public StartForm()
    {
        InitializeComponent();
        Padding = new Padding(0);
    }

    private void launch_client_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void server_Click(object sender, EventArgs e)
    {
        Program.server = true;
        Close();
    }
}
namespace Homework_Studios_Launcher;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
        Padding = new Padding(0);
        AppdataDataSaver.SafeCreateFile("saved_games");
        Cnsole.console = console;
    }

    private void Main_Load(object sender, EventArgs e)
    {
    }

    private void consolein_TextChanged(object sender, EventArgs e)
    {
        var txt = consolein.Text;
        if (txt.Contains(Environment.NewLine))
        {
            Cnsole.WriteLine(txt.Replace(Environment.NewLine, ""));
            consolein.Text = "";
        }
    }

    private void gameadder_Click(object sender, EventArgs e)
    {
        folderBrowserDialog1.ShowDialog();
        var path = folderBrowserDialog1.SelectedPath;
        folderBrowserDialog1.InitialDirectory = path;
        new Game(path).Add();
        
    }

    private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
    {
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        var list = this.listView1.SelectedItems;
        if(list.Count != 0)
        Cnsole.WriteLine(list[0].Text);
    }
}

internal class Game
{
    public static string name;
    private readonly string path;

    public Game(string path)
    {
        this.path = path;
    }

    public void Add()
    {
        Cnsole.WriteLine("Trying to add game: " + path);
        name = path.Split('\\').Last();
        var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HW-SLauncher";
        var saves = File.Create(appdata + "\\SavedPaths.txt");

        var sw = new StreamWriter(saves);
        sw.WriteLine(path, true);
        sw.Close();

        Program.games.Add(this);
        Cnsole.WriteSuccessLine("Added game: " + name);
    }
}

internal class Cnsole
{
    public static RichTextBox console;

    public static void WriteLine(string text)
    {
        console.Text += text + Environment.NewLine;
        console.ScrollToCaret();
    }

    public static void WriteErrorLine(string text)
    {
        console.SelectionColor = Color.Red;
        console.AppendText(text + Environment.NewLine);
        console.SelectionColor = console.ForeColor;
        console.ScrollToCaret();
    }

    public static void WriteWarningLine(string text)
    {
        console.SelectionColor = Color.Yellow;
        console.AppendText(text + Environment.NewLine);
        console.SelectionColor = console.ForeColor;
        console.ScrollToCaret();
    }

    public static void WriteSuccessLine(string text)
    {
        console.SelectionColor = Color.Green;
        console.AppendText(text + Environment.NewLine);
        console.SelectionColor = console.ForeColor;
        console.ScrollToCaret();
    }
}
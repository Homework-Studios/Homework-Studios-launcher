using System.ComponentModel;

namespace Homework_Studios_Launcher;

partial class ServerForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.panel2 = new System.Windows.Forms.Panel();
        this.gameadder = new System.Windows.Forms.Button();
        this.run_update = new System.Windows.Forms.Button();
        
        this.buttonsetc = new System.Windows.Forms.Panel();
        this.updateall = new System.Windows.Forms.Button();
        this.console = new System.Windows.Forms.RichTextBox();
        this.consolein = new System.Windows.Forms.TextBox();
        this.consolepanrl = new System.Windows.Forms.Panel();
        this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
        // 
        // consolepanrl
        // 
        this.consolepanrl.Controls.Add(this.consolein);
        this.consolepanrl.Controls.Add(this.console);
        this.consolepanrl.Dock = System.Windows.Forms.DockStyle.Fill;
        this.consolepanrl.Location = new System.Drawing.Point(513, 0);
        this.consolepanrl.Name = "consolepanrl";
        this.consolepanrl.Size = new System.Drawing.Size(1122, 849);
        this.consolepanrl.TabIndex = 7;
        // 
        // console
        // 
        this.console.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
        this.console.Dock = System.Windows.Forms.DockStyle.Fill;
        this.console.ForeColor = System.Drawing.SystemColors.InactiveBorder;
        this.console.Location = new System.Drawing.Point(0, 0);
        this.console.Name = "console";
        this.console.ReadOnly = true;
        this.console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
        this.console.Size = new System.Drawing.Size(1122, 849);
        this.console.TabIndex = 5;
        this.console.Text = "";
        // 
        // consolein
        // 
        this.consolein.AcceptsReturn = true;
        this.consolein.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
        this.consolein.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.consolein.ForeColor = System.Drawing.SystemColors.InactiveBorder;
        this.consolein.Location = new System.Drawing.Point(0, 810);
        this.consolein.Multiline = true;
        this.consolein.Name = "consolein";
        this.consolein.Size = new System.Drawing.Size(1122, 39);
        this.consolein.TabIndex = 6;
        // 
        // consolepanrl
        // 
        this.consolepanrl.Controls.Add(this.consolein);
        this.consolepanrl.Controls.Add(this.console);
        this.consolepanrl.Dock = System.Windows.Forms.DockStyle.Fill;
        this.consolepanrl.Location = new System.Drawing.Point(513, 0);
        this.consolepanrl.Name = "consolepanrl";
        this.consolepanrl.Size = new System.Drawing.Size(1122, 849);
        this.consolepanrl.TabIndex = 7;
        // 
        // folderBrowserDialog1
        // 
        this.folderBrowserDialog1.Description = "Select the folder where your game is installed or shuld be";
        this.folderBrowserDialog1.UseDescriptionForTitle = true;
            
        this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        this.ClientSize = new System.Drawing.Size(1635, 849);
        this.Controls.Add(this.consolepanrl);
        this.Controls.Add(this.buttonsetc);
        this.Controls.Add(this.consolepanrl);
        this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
        this.Name = "Main";
        this.Opacity = 0.95D;
        this.Text = "Homework Studios Server";
        this.buttonsetc.ResumeLayout(false);
        this.consolepanrl.ResumeLayout(false);
        this.consolepanrl.PerformLayout();

    }
    
    private MenuStrip menuStrip1;
    private ToolStripMenuItem qrawToolStripMenuItem;
    private ToolStripComboBox toolStripComboBox1;
    private Panel panel2;
    private Button gameadder;
    private Button run_update;
    private CheckedListBox checkedListBox1;
    private Panel buttonsetc;
    public RichTextBox console;
    private TextBox consolein;
    private Panel consolepanrl;
    private Button updateall;
    private FolderBrowserDialog folderBrowserDialog1;

    #endregion
}
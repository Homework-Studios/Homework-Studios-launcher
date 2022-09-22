using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Homework_Studios_Launcher
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("5");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("6");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("7");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gameadder = new System.Windows.Forms.Button();
            this.run_update = new System.Windows.Forms.Button();
            this.buttonsetc = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.updateall = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.consolein = new System.Windows.Forms.TextBox();
            this.consolepanrl = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonsetc.SuspendLayout();
            this.consolepanrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 652);
            this.panel2.TabIndex = 1;
            // 
            // gameadder
            // 
            this.gameadder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameadder.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameadder.FlatAppearance.BorderSize = 0;
            this.gameadder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameadder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameadder.Location = new System.Drawing.Point(0, 0);
            this.gameadder.Name = "gameadder";
            this.gameadder.Size = new System.Drawing.Size(513, 46);
            this.gameadder.TabIndex = 0;
            this.gameadder.Text = "Add Launchable .exe";
            this.gameadder.UseVisualStyleBackColor = false;
            this.gameadder.Click += new System.EventHandler(this.gameadder_Click);
            // 
            // run_update
            // 
            this.run_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.run_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.run_update.ForeColor = System.Drawing.SystemColors.Control;
            this.run_update.Location = new System.Drawing.Point(0, 767);
            this.run_update.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.run_update.Name = "run_update";
            this.run_update.Size = new System.Drawing.Size(513, 82);
            this.run_update.TabIndex = 2;
            this.run_update.Text = "Launch / Update";
            this.run_update.UseVisualStyleBackColor = false;
            // 
            // buttonsetc
            // 
            this.buttonsetc.Controls.Add(this.listView1);
            this.buttonsetc.Controls.Add(this.updateall);
            this.buttonsetc.Controls.Add(this.run_update);
            this.buttonsetc.Controls.Add(this.gameadder);
            this.buttonsetc.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonsetc.Location = new System.Drawing.Point(0, 0);
            this.buttonsetc.Name = "buttonsetc";
            this.buttonsetc.Size = new System.Drawing.Size(513, 849);
            this.buttonsetc.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listView1.Location = new System.Drawing.Point(0, 527);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 194);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // updateall
            // 
            this.updateall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updateall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateall.Location = new System.Drawing.Point(0, 721);
            this.updateall.Name = "updateall";
            this.updateall.Size = new System.Drawing.Size(513, 46);
            this.updateall.TabIndex = 5;
            this.updateall.Text = "Update All";
            this.updateall.UseVisualStyleBackColor = false;
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
            this.consolein.TextChanged += new System.EventHandler(this.consolein_TextChanged);
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
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1635, 849);
            this.Controls.Add(this.consolepanrl);
            this.Controls.Add(this.buttonsetc);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0.95D;
            this.Text = "Homework Studios Launcher";
            this.Load += new System.EventHandler(this.Main_Load);
            this.buttonsetc.ResumeLayout(false);
            this.consolepanrl.ResumeLayout(false);
            this.consolepanrl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem qrawToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private Panel panel2;
        private Button gameadder;
        private Button run_update;
        private Panel buttonsetc;
        public RichTextBox console;
        private TextBox consolein;
        private Panel consolepanrl;
        private Button updateall;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListView listView1;
    }
}
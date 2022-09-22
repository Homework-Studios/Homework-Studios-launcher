using System.ComponentModel;

namespace Homework_Studios_Launcher;

partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.launch_client = new System.Windows.Forms.Button();
            this.server = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.launch_client);
            this.panel1.Controls.Add(this.server);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 378);
            this.panel1.TabIndex = 0;
            // 
            // launch_client
            // 
            this.launch_client.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.launch_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.launch_client.ForeColor = System.Drawing.SystemColors.Control;
            this.launch_client.Location = new System.Drawing.Point(0, 0);
            this.launch_client.Name = "launch_client";
            this.launch_client.Size = new System.Drawing.Size(659, 186);
            this.launch_client.TabIndex = 1;
            this.launch_client.Text = "Client";
            this.launch_client.UseVisualStyleBackColor = false;
            this.launch_client.Click += new System.EventHandler(this.launch_client_Click);
            // 
            // server
            // 
            this.server.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.server.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.server.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.server.Location = new System.Drawing.Point(0, 192);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(659, 186);
            this.server.TabIndex = 0;
            this.server.Text = "Server";
            this.server.UseVisualStyleBackColor = false;
            this.server.Click += new System.EventHandler(this.server_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(659, 378);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Opacity = 0.95D;
            this.Text = "Homework Studios Launcher Main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel panel1;
    private Button launch_client;
    private Button server;
}
namespace Paid2Play
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.navMenu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greeting = new System.Windows.Forms.Label();
            this.navMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenu
            // 
            this.navMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.appsToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.navMenu.Location = new System.Drawing.Point(0, 0);
            this.navMenu.Name = "navMenu";
            this.navMenu.Size = new System.Drawing.Size(974, 24);
            this.navMenu.TabIndex = 0;
            this.navMenu.Text = "navMenu";
            this.navMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.navMenu_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // appsToolStripMenuItem
            // 
            this.appsToolStripMenuItem.Name = "appsToolStripMenuItem";
            this.appsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.appsToolStripMenuItem.Text = "Apps";
            this.appsToolStripMenuItem.Click += new System.EventHandler(this.appsToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.BackColor = System.Drawing.Color.Transparent;
            this.greeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greeting.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.ForeColor = System.Drawing.SystemColors.Desktop;
            this.greeting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.greeting.Location = new System.Drawing.Point(12, 247);
            this.greeting.MaximumSize = new System.Drawing.Size(500, 5000);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(82, 30);
            this.greeting.TabIndex = 1;
            this.greeting.Text = "Greeting";
            this.greeting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.greeting.Click += new System.EventHandler(this.greeting_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Paid2Play.Properties.Resources.Applications1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 508);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.navMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Gray;
            this.MainMenuStrip = this.navMenu;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.navMenu.ResumeLayout(false);
            this.navMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navMenu;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label greeting;
    }
}
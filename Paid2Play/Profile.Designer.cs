namespace Paid2Play
{
    partial class profile
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
            this.components = new System.ComponentModel.Container();
            this.navMenu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.username = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpwordbox = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.p2pDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p2pDataSet1 = new Paid2Play.p2pDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.navMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2pDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2pDataSet1)).BeginInit();
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
            this.navMenu.TabIndex = 1;
            this.navMenu.Text = "navMenu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
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
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Cyan;
            this.username.Location = new System.Drawing.Point(86, 49);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(134, 31);
            this.username.TabIndex = 2;
            this.username.Text = "username";
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.ForeColor = System.Drawing.SystemColors.Info;
            this.credits.Location = new System.Drawing.Point(783, 49);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(56, 20);
            this.credits.TabIndex = 3;
            this.credits.Text = "credits";
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(52, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "click here to change password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cpwordbox
            // 
            this.cpwordbox.Location = new System.Drawing.Point(64, 164);
            this.cpwordbox.Name = "cpwordbox";
            this.cpwordbox.Size = new System.Drawing.Size(100, 20);
            this.cpwordbox.TabIndex = 8;
            this.cpwordbox.Visible = false;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(64, 203);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 9;
            this.enter.Text = "enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Visible = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Recent Activity:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // p2pDataSet1BindingSource
            // 
            this.p2pDataSet1BindingSource.DataSource = this.p2pDataSet1;
            this.p2pDataSet1BindingSource.Position = 0;
            // 
            // p2pDataSet1
            // 
            this.p2pDataSet1.DataSetName = "p2pDataSet1";
            this.p2pDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(725, 255);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 13;
            this.Data.Text = "Data";
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(974, 508);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.cpwordbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.username);
            this.Controls.Add(this.navMenu);
            this.Name = "profile";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.profile_Load);
            this.navMenu.ResumeLayout(false);
            this.navMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2pDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2pDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navMenu;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label credits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cpwordbox;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource p2pDataSet1BindingSource;
        private p2pDataSet1 p2pDataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Data;
    }
}
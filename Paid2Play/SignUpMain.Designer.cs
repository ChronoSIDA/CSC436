namespace Paid2Play
{
    partial class SignUpMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpMain));
            this.createUsr = new System.Windows.Forms.TextBox();
            this.CreatePWD = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createUsr
            // 
            this.createUsr.BackColor = System.Drawing.SystemColors.Window;
            this.createUsr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createUsr.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.createUsr.Location = new System.Drawing.Point(340, 200);
            this.createUsr.Name = "createUsr";
            this.createUsr.Size = new System.Drawing.Size(250, 14);
            this.createUsr.TabIndex = 0;
            this.createUsr.Text = "Create Your Username";
            // 
            // CreatePWD
            // 
            this.CreatePWD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreatePWD.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CreatePWD.Location = new System.Drawing.Point(340, 269);
            this.CreatePWD.Name = "CreatePWD";
            this.CreatePWD.Size = new System.Drawing.Size(250, 14);
            this.CreatePWD.TabIndex = 1;
            this.CreatePWD.Text = "Set Your Password";
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpButton.BackgroundImage")));
            this.SignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Location = new System.Drawing.Point(321, 337);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(329, 56);
            this.SignUpButton.TabIndex = 2;
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignUpMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 508);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.CreatePWD);
            this.Controls.Add(this.createUsr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpMain";
            this.Text = "Paid2Play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox createUsr;
        private System.Windows.Forms.TextBox CreatePWD;
        private System.Windows.Forms.Button SignUpButton;
    }
}
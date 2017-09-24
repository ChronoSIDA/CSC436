namespace Paid2Play
{
    partial class Form1
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
            this.signIn = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Label();
            this.InEmailtBOX = new System.Windows.Forms.TextBox();
            this.INpwordtBOX = new System.Windows.Forms.TextBox();
            this.upEMailTBOX = new System.Windows.Forms.TextBox();
            this.UppwordTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signIn
            // 
            this.signIn.AutoSize = true;
            this.signIn.Location = new System.Drawing.Point(92, 45);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(40, 13);
            this.signIn.TabIndex = 0;
            this.signIn.Text = "Sign-In";
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.Location = new System.Drawing.Point(422, 45);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(45, 13);
            this.signUp.TabIndex = 1;
            this.signUp.Text = "Sign-Up";
            // 
            // InEmailtBOX
            // 
            this.InEmailtBOX.Location = new System.Drawing.Point(95, 106);
            this.InEmailtBOX.Name = "InEmailtBOX";
            this.InEmailtBOX.Size = new System.Drawing.Size(100, 20);
            this.InEmailtBOX.TabIndex = 2;
            // 
            // INpwordtBOX
            // 
            this.INpwordtBOX.Location = new System.Drawing.Point(95, 164);
            this.INpwordtBOX.Name = "INpwordtBOX";
            this.INpwordtBOX.Size = new System.Drawing.Size(100, 20);
            this.INpwordtBOX.TabIndex = 3;
            // 
            // upEMailTBOX
            // 
            this.upEMailTBOX.Location = new System.Drawing.Point(425, 106);
            this.upEMailTBOX.Name = "upEMailTBOX";
            this.upEMailTBOX.Size = new System.Drawing.Size(100, 20);
            this.upEMailTBOX.TabIndex = 4;
            // 
            // UppwordTBOX
            // 
            this.UppwordTBOX.Location = new System.Drawing.Point(425, 164);
            this.UppwordTBOX.Name = "UppwordTBOX";
            this.UppwordTBOX.Size = new System.Drawing.Size(100, 20);
            this.UppwordTBOX.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UppwordTBOX);
            this.Controls.Add(this.upEMailTBOX);
            this.Controls.Add(this.INpwordtBOX);
            this.Controls.Add(this.InEmailtBOX);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.signIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signIn;
        private System.Windows.Forms.Label signUp;
        private System.Windows.Forms.TextBox InEmailtBOX;
        private System.Windows.Forms.TextBox INpwordtBOX;
        private System.Windows.Forms.TextBox upEMailTBOX;
        private System.Windows.Forms.TextBox UppwordTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


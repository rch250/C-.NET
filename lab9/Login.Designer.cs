namespace Lab9
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadprogressBar = new System.Windows.Forms.ProgressBar();
            this.percentagelabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.logintoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordtextBox);
            this.groupBox1.Controls.Add(this.emailtextBox);
            this.groupBox1.Controls.Add(this.usertextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(136, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(150, 87);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.ShortcutsEnabled = false;
            this.passwordtextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordtextBox.TabIndex = 5;
            this.logintoolTip.SetToolTip(this.passwordtextBox, "Enter your password");
            this.passwordtextBox.UseSystemPasswordChar = true;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(150, 58);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.ShortcutsEnabled = false;
            this.emailtextBox.Size = new System.Drawing.Size(100, 22);
            this.emailtextBox.TabIndex = 4;
            this.logintoolTip.SetToolTip(this.emailtextBox, "Enter your email address");
            // 
            // usertextBox
            // 
            this.usertextBox.Location = new System.Drawing.Point(150, 29);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.ShortcutsEnabled = false;
            this.usertextBox.Size = new System.Drawing.Size(100, 22);
            this.usertextBox.TabIndex = 3;
            this.logintoolTip.SetToolTip(this.usertextBox, "Enter your Username");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadprogressBar
            // 
            this.loadprogressBar.Location = new System.Drawing.Point(157, 252);
            this.loadprogressBar.Name = "loadprogressBar";
            this.loadprogressBar.Size = new System.Drawing.Size(266, 23);
            this.loadprogressBar.TabIndex = 1;
            this.loadprogressBar.Click += new System.EventHandler(this.loadprogressBar_Click);
            // 
            // percentagelabel
            // 
            this.percentagelabel.AutoSize = true;
            this.percentagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentagelabel.Location = new System.Drawing.Point(253, 299);
            this.percentagelabel.Name = "percentagelabel";
            this.percentagelabel.Size = new System.Drawing.Size(51, 20);
            this.percentagelabel.TabIndex = 2;
            this.percentagelabel.Text = "label4";
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(157, 348);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "&Login";
            this.logintoolTip.SetToolTip(this.loginbutton, "Login");
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(341, 347);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 5;
            this.exitbutton.Text = "&Exit";
            this.logintoolTip.SetToolTip(this.exitbutton, "Exit");
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(256, 348);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 6;
            this.cancelbutton.Text = "&Cancel";
            this.logintoolTip.SetToolTip(this.cancelbutton, "Cancel");
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.percentagelabel);
            this.Controls.Add(this.loadprogressBar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar loadprogressBar;
        private System.Windows.Forms.Label percentagelabel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.ToolTip logintoolTip;
    }
}


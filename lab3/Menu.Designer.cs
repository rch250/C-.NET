namespace Lab3a
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.menuPictureBox = new System.Windows.Forms.PictureBox();
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.websiteButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.videoButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.menuToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(289, 40);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "User name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(289, 125);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(289, 191);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Phone Number";
            // 
            // menuPictureBox
            // 
            this.menuPictureBox.Location = new System.Drawing.Point(41, 40);
            this.menuPictureBox.Name = "menuPictureBox";
            this.menuPictureBox.Size = new System.Drawing.Size(219, 250);
            this.menuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuPictureBox.TabIndex = 1;
            this.menuPictureBox.TabStop = false;
            // 
            // usertextBox
            // 
            this.usertextBox.Location = new System.Drawing.Point(293, 79);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.Size = new System.Drawing.Size(155, 20);
            this.usertextBox.TabIndex = 1;
            this.menuToolTip.SetToolTip(this.usertextBox, "Enter user name");
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(293, 148);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(155, 20);
            this.passwordtextBox.TabIndex = 2;
            this.menuToolTip.SetToolTip(this.passwordtextBox, "Enter password");
            this.passwordtextBox.UseSystemPasswordChar = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(293, 235);
            this.phoneTextBox.Mask = "(999) 000-0000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(155, 20);
            this.phoneTextBox.TabIndex = 3;
            this.menuToolTip.SetToolTip(this.phoneTextBox, "Enter phone number");
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(535, 75);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(159, 41);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "&OK";
            this.menuToolTip.SetToolTip(this.okButton, "ok");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // websiteButton
            // 
            this.websiteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.websiteButton.Location = new System.Drawing.Point(535, 122);
            this.websiteButton.Name = "websiteButton";
            this.websiteButton.Size = new System.Drawing.Size(159, 37);
            this.websiteButton.TabIndex = 4;
            this.websiteButton.Text = "&Visit our Website";
            this.menuToolTip.SetToolTip(this.websiteButton, "visit our website");
            this.websiteButton.UseVisualStyleBackColor = true;
            this.websiteButton.Click += new System.EventHandler(this.websiteButton_Click);
            // 
            // emailButton
            // 
            this.emailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailButton.Location = new System.Drawing.Point(535, 165);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(159, 33);
            this.emailButton.TabIndex = 4;
            this.emailButton.Text = "&Email Order";
            this.menuToolTip.SetToolTip(this.emailButton, "Email Order");
            this.emailButton.UseVisualStyleBackColor = true;
            // 
            // videoButton
            // 
            this.videoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoButton.Location = new System.Drawing.Point(535, 204);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(159, 42);
            this.videoButton.TabIndex = 4;
            this.videoButton.Text = "&Video";
            this.menuToolTip.SetToolTip(this.videoButton, "Watch our Video");
            this.videoButton.UseVisualStyleBackColor = true;
            this.videoButton.Click += new System.EventHandler(this.videoButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(535, 252);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(159, 38);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "&Cancel";
            this.menuToolTip.SetToolTip(this.cancelButton, "Cancel");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.videoButton);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.websiteButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.usertextBox);
            this.Controls.Add(this.menuPictureBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menuForm";
            this.Text = "Menu Form";
            this.Load += new System.EventHandler(this.menuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.PictureBox menuPictureBox;
        private System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button websiteButton;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolTip menuToolTip;
    }
}


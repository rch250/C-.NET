namespace Lab3a
{
    partial class WebBrowser
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.navbutton = new System.Windows.Forms.Button();
            this.mywebBrowser = new System.Windows.Forms.WebBrowser();
            this.refreshButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.stopBbutton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.webtoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(371, 21);
            this.comboBox1.TabIndex = 0;
            this.webtoolTip.SetToolTip(this.comboBox1, "URL");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // navbutton
            // 
            this.navbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbutton.Location = new System.Drawing.Point(512, 29);
            this.navbutton.Name = "navbutton";
            this.navbutton.Size = new System.Drawing.Size(149, 34);
            this.navbutton.TabIndex = 1;
            this.navbutton.Text = "&Navigate";
            this.webtoolTip.SetToolTip(this.navbutton, "Navigate");
            this.navbutton.UseVisualStyleBackColor = true;
            this.navbutton.Click += new System.EventHandler(this.navbutton_Click);
            // 
            // mywebBrowser
            // 
            this.mywebBrowser.Location = new System.Drawing.Point(75, 107);
            this.mywebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mywebBrowser.Name = "mywebBrowser";
            this.mywebBrowser.Size = new System.Drawing.Size(901, 250);
            this.mywebBrowser.TabIndex = 2;
            this.mywebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.mywebBrowser_DocumentCompleted);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(75, 391);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(149, 34);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "&Refresh";
            this.webtoolTip.SetToolTip(this.refreshButton, "Refresh");
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(230, 391);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(149, 34);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "&Back";
            this.webtoolTip.SetToolTip(this.backButton, "Back");
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButton.Location = new System.Drawing.Point(385, 391);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(149, 34);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.Text = "&Forward";
            this.webtoolTip.SetToolTip(this.forwardButton, "Forward");
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // stopBbutton
            // 
            this.stopBbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBbutton.Location = new System.Drawing.Point(540, 391);
            this.stopBbutton.Name = "stopBbutton";
            this.stopBbutton.Size = new System.Drawing.Size(149, 34);
            this.stopBbutton.TabIndex = 1;
            this.stopBbutton.Text = "&Stop";
            this.webtoolTip.SetToolTip(this.stopBbutton, "Stop");
            this.stopBbutton.UseVisualStyleBackColor = true;
            this.stopBbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(681, 391);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(149, 34);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "&Home";
            this.webtoolTip.SetToolTip(this.homeButton, "Home");
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(836, 391);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(149, 34);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "&Close";
            this.webtoolTip.SetToolTip(this.closeButton, "Close");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mywebBrowser);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.stopBbutton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.navbutton);
            this.Controls.Add(this.comboBox1);
            this.Name = "WebBrowser";
            this.Text = "Mike\'s Ice Cream Shop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button navbutton;
        private System.Windows.Forms.WebBrowser mywebBrowser;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button stopBbutton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolTip webtoolTip;
    }
}
namespace Lab3a
{
    partial class Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mytextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.pausebutton = new System.Windows.Forms.Button();
            this.forwardbutton = new System.Windows.Forms.Button();
            this.rewindbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(127, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(532, 338);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // mytextBox
            // 
            this.mytextBox.Location = new System.Drawing.Point(127, 371);
            this.mytextBox.Name = "mytextBox";
            this.mytextBox.Size = new System.Drawing.Size(532, 20);
            this.mytextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(110, 411);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 27);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "&Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(191, 411);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 27);
            this.startbutton.TabIndex = 2;
            this.startbutton.Text = "&Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // pausebutton
            // 
            this.pausebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausebutton.Location = new System.Drawing.Point(272, 411);
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.Size = new System.Drawing.Size(75, 27);
            this.pausebutton.TabIndex = 2;
            this.pausebutton.Text = "&Pause";
            this.pausebutton.UseVisualStyleBackColor = true;
            this.pausebutton.Click += new System.EventHandler(this.pausebutton_Click);
            // 
            // forwardbutton
            // 
            this.forwardbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardbutton.Location = new System.Drawing.Point(353, 411);
            this.forwardbutton.Name = "forwardbutton";
            this.forwardbutton.Size = new System.Drawing.Size(75, 27);
            this.forwardbutton.TabIndex = 2;
            this.forwardbutton.Text = "&Forward";
            this.forwardbutton.UseVisualStyleBackColor = true;
            // 
            // rewindbutton
            // 
            this.rewindbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewindbutton.Location = new System.Drawing.Point(434, 411);
            this.rewindbutton.Name = "rewindbutton";
            this.rewindbutton.Size = new System.Drawing.Size(75, 27);
            this.rewindbutton.TabIndex = 2;
            this.rewindbutton.Text = "&Rewind";
            this.rewindbutton.UseVisualStyleBackColor = true;
            // 
            // stopbutton
            // 
            this.stopbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbutton.Location = new System.Drawing.Point(515, 411);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 27);
            this.stopbutton.TabIndex = 2;
            this.stopbutton.Text = "&Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.rewindbutton);
            this.Controls.Add(this.forwardbutton);
            this.Controls.Add(this.pausebutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.mytextBox);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Video";
            this.Text = "Video";
            this.Load += new System.EventHandler(this.Video_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox mytextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button pausebutton;
        private System.Windows.Forms.Button forwardbutton;
        private System.Windows.Forms.Button rewindbutton;
        private System.Windows.Forms.Button stopbutton;
    }
}
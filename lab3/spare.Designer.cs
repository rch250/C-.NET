namespace Lab3a
{
    partial class spare
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
            this.icecreamsizegroupBox = new System.Windows.Forms.GroupBox();
            this.largeradioButton = new System.Windows.Forms.RadioButton();
            this.mediumradioButton = new System.Windows.Forms.RadioButton();
            this.smallradioButton = new System.Windows.Forms.RadioButton();
            this.icecreamsizegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // icecreamsizegroupBox
            // 
            this.icecreamsizegroupBox.Controls.Add(this.largeradioButton);
            this.icecreamsizegroupBox.Controls.Add(this.mediumradioButton);
            this.icecreamsizegroupBox.Controls.Add(this.smallradioButton);
            this.icecreamsizegroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icecreamsizegroupBox.Location = new System.Drawing.Point(300, 173);
            this.icecreamsizegroupBox.Name = "icecreamsizegroupBox";
            this.icecreamsizegroupBox.Size = new System.Drawing.Size(200, 105);
            this.icecreamsizegroupBox.TabIndex = 4;
            this.icecreamsizegroupBox.TabStop = false;
            this.icecreamsizegroupBox.Text = "Ice Cream Size";
            // 
            // largeradioButton
            // 
            this.largeradioButton.AutoSize = true;
            this.largeradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeradioButton.Location = new System.Drawing.Point(26, 75);
            this.largeradioButton.Name = "largeradioButton";
            this.largeradioButton.Size = new System.Drawing.Size(68, 24);
            this.largeradioButton.TabIndex = 0;
            this.largeradioButton.TabStop = true;
            this.largeradioButton.Text = "Large";
            this.largeradioButton.UseVisualStyleBackColor = true;
            // 
            // mediumradioButton
            // 
            this.mediumradioButton.AutoSize = true;
            this.mediumradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumradioButton.Location = new System.Drawing.Point(26, 51);
            this.mediumradioButton.Name = "mediumradioButton";
            this.mediumradioButton.Size = new System.Drawing.Size(83, 24);
            this.mediumradioButton.TabIndex = 0;
            this.mediumradioButton.TabStop = true;
            this.mediumradioButton.Text = "Medium";
            this.mediumradioButton.UseVisualStyleBackColor = true;
            // 
            // smallradioButton
            // 
            this.smallradioButton.AutoSize = true;
            this.smallradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallradioButton.Location = new System.Drawing.Point(26, 27);
            this.smallradioButton.Name = "smallradioButton";
            this.smallradioButton.Size = new System.Drawing.Size(66, 24);
            this.smallradioButton.TabIndex = 0;
            this.smallradioButton.TabStop = true;
            this.smallradioButton.Text = "Small";
            this.smallradioButton.UseVisualStyleBackColor = true;
            // 
            // spare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.icecreamsizegroupBox);
            this.Name = "spare";
            this.Text = "spare";
            this.icecreamsizegroupBox.ResumeLayout(false);
            this.icecreamsizegroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox icecreamsizegroupBox;
        private System.Windows.Forms.RadioButton largeradioButton;
        private System.Windows.Forms.RadioButton mediumradioButton;
        private System.Windows.Forms.RadioButton smallradioButton;
    }
}
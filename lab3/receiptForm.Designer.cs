namespace Lab3a
{
    partial class receiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receiptForm));
            this.customergroupBox = new System.Windows.Forms.GroupBox();
            this.ordergroupBox = new System.Windows.Forms.GroupBox();
            this.rnamelabel = new System.Windows.Forms.Label();
            this.cnamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctypelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cnumberlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctotallabel = new System.Windows.Forms.Label();
            this.customergroupBox.SuspendLayout();
            this.ordergroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customergroupBox
            // 
            this.customergroupBox.Controls.Add(this.cnamelabel);
            this.customergroupBox.Controls.Add(this.rnamelabel);
            this.customergroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customergroupBox.Location = new System.Drawing.Point(82, 69);
            this.customergroupBox.Name = "customergroupBox";
            this.customergroupBox.Size = new System.Drawing.Size(245, 76);
            this.customergroupBox.TabIndex = 0;
            this.customergroupBox.TabStop = false;
            this.customergroupBox.Text = "Your Information";
            // 
            // ordergroupBox
            // 
            this.ordergroupBox.Controls.Add(this.ctotallabel);
            this.ordergroupBox.Controls.Add(this.cnumberlabel);
            this.ordergroupBox.Controls.Add(this.ctypelabel);
            this.ordergroupBox.Controls.Add(this.label6);
            this.ordergroupBox.Controls.Add(this.label4);
            this.ordergroupBox.Controls.Add(this.label2);
            this.ordergroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordergroupBox.Location = new System.Drawing.Point(82, 213);
            this.ordergroupBox.Name = "ordergroupBox";
            this.ordergroupBox.Size = new System.Drawing.Size(291, 164);
            this.ordergroupBox.TabIndex = 1;
            this.ordergroupBox.TabStop = false;
            this.ordergroupBox.Text = "Order Information";
            // 
            // rnamelabel
            // 
            this.rnamelabel.AutoSize = true;
            this.rnamelabel.Location = new System.Drawing.Point(39, 35);
            this.rnamelabel.Name = "rnamelabel";
            this.rnamelabel.Size = new System.Drawing.Size(87, 20);
            this.rnamelabel.TabIndex = 0;
            this.rnamelabel.Text = "Your name";
            // 
            // cnamelabel
            // 
            this.cnamelabel.AutoSize = true;
            this.cnamelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnamelabel.Location = new System.Drawing.Point(158, 35);
            this.cnamelabel.Name = "cnamelabel";
            this.cnamelabel.Size = new System.Drawing.Size(43, 22);
            this.cnamelabel.TabIndex = 0;
            this.cnamelabel.Text = "        ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Receipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ice cream type";
            // 
            // ctypelabel
            // 
            this.ctypelabel.AutoSize = true;
            this.ctypelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctypelabel.Location = new System.Drawing.Point(148, 31);
            this.ctypelabel.Name = "ctypelabel";
            this.ctypelabel.Size = new System.Drawing.Size(43, 22);
            this.ctypelabel.TabIndex = 0;
            this.ctypelabel.Text = "        ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone number";
            // 
            // cnumberlabel
            // 
            this.cnumberlabel.AutoSize = true;
            this.cnumberlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnumberlabel.Location = new System.Drawing.Point(148, 72);
            this.cnumberlabel.Name = "cnumberlabel";
            this.cnumberlabel.Size = new System.Drawing.Size(43, 22);
            this.cnumberlabel.TabIndex = 0;
            this.cnumberlabel.Text = "        ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Order Total";
            // 
            // ctotallabel
            // 
            this.ctotallabel.AutoSize = true;
            this.ctotallabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctotallabel.Location = new System.Drawing.Point(148, 116);
            this.ctotallabel.Name = "ctotallabel";
            this.ctotallabel.Size = new System.Drawing.Size(43, 22);
            this.ctotallabel.TabIndex = 0;
            this.ctotallabel.Text = "        ";
            // 
            // receiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordergroupBox);
            this.Controls.Add(this.customergroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "receiptForm";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.receiptForm_Load);
            this.customergroupBox.ResumeLayout(false);
            this.customergroupBox.PerformLayout();
            this.ordergroupBox.ResumeLayout(false);
            this.ordergroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox customergroupBox;
        private System.Windows.Forms.GroupBox ordergroupBox;
        private System.Windows.Forms.Label cnamelabel;
        private System.Windows.Forms.Label rnamelabel;
        private System.Windows.Forms.Label ctotallabel;
        private System.Windows.Forms.Label cnumberlabel;
        private System.Windows.Forms.Label ctypelabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
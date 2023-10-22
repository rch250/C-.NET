namespace Lab3a
{
    partial class shopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shopForm));
            this.exitbutton = new System.Windows.Forms.Button();
            this.icecreamtypegroupBox = new System.Windows.Forms.GroupBox();
            this.vanillaradioButton = new System.Windows.Forms.RadioButton();
            this.chocolateradioButton = new System.Windows.Forms.RadioButton();
            this.strawberryradioButton = new System.Windows.Forms.RadioButton();
            this.shoptoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.resetbutton = new System.Windows.Forms.Button();
            this.checkoutbutton = new System.Windows.Forms.Button();
            this.toppingsgroupBox = new System.Windows.Forms.GroupBox();
            this.mintcheckBox = new System.Windows.Forms.CheckBox();
            this.carmelcheckBox = new System.Windows.Forms.CheckBox();
            this.chocolatecheckBox = new System.Windows.Forms.CheckBox();
            this.freshfruitcheckBox = new System.Windows.Forms.CheckBox();
            this.processgroupBox = new System.Windows.Forms.GroupBox();
            this.totalamountlabel = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.numberlabel = new System.Windows.Forms.Label();
            this.customerlabel = new System.Windows.Forms.Label();
            this.customertextBox = new System.Windows.Forms.TextBox();
            this.numbertextBox = new System.Windows.Forms.TextBox();
            this.titlelabel = new System.Windows.Forms.Label();
            this.smallradioButton = new System.Windows.Forms.RadioButton();
            this.mediumradioButton = new System.Windows.Forms.RadioButton();
            this.largeradioButton = new System.Windows.Forms.RadioButton();
            this.icecreamsizegroupBox = new System.Windows.Forms.GroupBox();
            this.icecreamtypelabel = new System.Windows.Forms.Label();
            this.icecreampictureBox = new System.Windows.Forms.PictureBox();
            this.receiptbutton = new System.Windows.Forms.Button();
            this.rec_button = new System.Windows.Forms.Button();
            this.icecreamtypegroupBox.SuspendLayout();
            this.toppingsgroupBox.SuspendLayout();
            this.processgroupBox.SuspendLayout();
            this.icecreamsizegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icecreampictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(26, 147);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(105, 48);
            this.exitbutton.TabIndex = 0;
            this.exitbutton.Text = "E&xit";
            this.shoptoolTip.SetToolTip(this.exitbutton, "Exit");
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // icecreamtypegroupBox
            // 
            this.icecreamtypegroupBox.Controls.Add(this.vanillaradioButton);
            this.icecreamtypegroupBox.Controls.Add(this.chocolateradioButton);
            this.icecreamtypegroupBox.Controls.Add(this.strawberryradioButton);
            this.icecreamtypegroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icecreamtypegroupBox.Location = new System.Drawing.Point(60, 233);
            this.icecreamtypegroupBox.Name = "icecreamtypegroupBox";
            this.icecreamtypegroupBox.Size = new System.Drawing.Size(239, 124);
            this.icecreamtypegroupBox.TabIndex = 2;
            this.icecreamtypegroupBox.TabStop = false;
            this.icecreamtypegroupBox.Text = "Ice Cream Type";
            // 
            // vanillaradioButton
            // 
            this.vanillaradioButton.AutoSize = true;
            this.vanillaradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanillaradioButton.Location = new System.Drawing.Point(26, 84);
            this.vanillaradioButton.Name = "vanillaradioButton";
            this.vanillaradioButton.Size = new System.Drawing.Size(74, 24);
            this.vanillaradioButton.TabIndex = 0;
            this.vanillaradioButton.TabStop = true;
            this.vanillaradioButton.Text = "Vanilla";
            this.vanillaradioButton.UseVisualStyleBackColor = true;
            this.vanillaradioButton.CheckedChanged += new System.EventHandler(this.vanillaradioButton_CheckedChanged);
            // 
            // chocolateradioButton
            // 
            this.chocolateradioButton.AutoSize = true;
            this.chocolateradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocolateradioButton.Location = new System.Drawing.Point(26, 61);
            this.chocolateradioButton.Name = "chocolateradioButton";
            this.chocolateradioButton.Size = new System.Drawing.Size(99, 24);
            this.chocolateradioButton.TabIndex = 0;
            this.chocolateradioButton.TabStop = true;
            this.chocolateradioButton.Text = "Chocolate";
            this.chocolateradioButton.UseVisualStyleBackColor = true;
            this.chocolateradioButton.CheckedChanged += new System.EventHandler(this.chocolateradioButton_CheckedChanged);
            // 
            // strawberryradioButton
            // 
            this.strawberryradioButton.AutoSize = true;
            this.strawberryradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strawberryradioButton.Location = new System.Drawing.Point(27, 36);
            this.strawberryradioButton.Name = "strawberryradioButton";
            this.strawberryradioButton.Size = new System.Drawing.Size(103, 24);
            this.strawberryradioButton.TabIndex = 0;
            this.strawberryradioButton.TabStop = true;
            this.strawberryradioButton.Text = "Strawberry";
            this.strawberryradioButton.UseVisualStyleBackColor = true;
            this.strawberryradioButton.CheckedChanged += new System.EventHandler(this.strawberryradioButton_CheckedChanged);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(26, 93);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(105, 48);
            this.resetbutton.TabIndex = 0;
            this.resetbutton.Text = "&Reset";
            this.shoptoolTip.SetToolTip(this.resetbutton, "Clear the form");
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.Location = new System.Drawing.Point(26, 43);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Size = new System.Drawing.Size(105, 48);
            this.checkoutbutton.TabIndex = 0;
            this.checkoutbutton.Text = "&Check Out";
            this.shoptoolTip.SetToolTip(this.checkoutbutton, "Check out");
            this.checkoutbutton.UseVisualStyleBackColor = true;
            this.checkoutbutton.Click += new System.EventHandler(this.checkoutbutton_Click);
            // 
            // toppingsgroupBox
            // 
            this.toppingsgroupBox.Controls.Add(this.mintcheckBox);
            this.toppingsgroupBox.Controls.Add(this.carmelcheckBox);
            this.toppingsgroupBox.Controls.Add(this.chocolatecheckBox);
            this.toppingsgroupBox.Controls.Add(this.freshfruitcheckBox);
            this.toppingsgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsgroupBox.Location = new System.Drawing.Point(60, 382);
            this.toppingsgroupBox.Name = "toppingsgroupBox";
            this.toppingsgroupBox.Size = new System.Drawing.Size(239, 92);
            this.toppingsgroupBox.TabIndex = 4;
            this.toppingsgroupBox.TabStop = false;
            this.toppingsgroupBox.Text = "Toppings $1.00";
            // 
            // mintcheckBox
            // 
            this.mintcheckBox.AutoSize = true;
            this.mintcheckBox.Location = new System.Drawing.Point(145, 55);
            this.mintcheckBox.Name = "mintcheckBox";
            this.mintcheckBox.Size = new System.Drawing.Size(58, 24);
            this.mintcheckBox.TabIndex = 0;
            this.mintcheckBox.Text = "Mint";
            this.mintcheckBox.UseVisualStyleBackColor = true;
            this.mintcheckBox.CheckedChanged += new System.EventHandler(this.mintcheckBox_CheckedChanged);
            // 
            // carmelcheckBox
            // 
            this.carmelcheckBox.AutoSize = true;
            this.carmelcheckBox.Location = new System.Drawing.Point(145, 27);
            this.carmelcheckBox.Name = "carmelcheckBox";
            this.carmelcheckBox.Size = new System.Drawing.Size(78, 24);
            this.carmelcheckBox.TabIndex = 0;
            this.carmelcheckBox.Text = "Carmel";
            this.carmelcheckBox.UseVisualStyleBackColor = true;
            this.carmelcheckBox.CheckedChanged += new System.EventHandler(this.carmelcheckBox_CheckedChanged_1);
            // 
            // chocolatecheckBox
            // 
            this.chocolatecheckBox.AutoSize = true;
            this.chocolatecheckBox.Location = new System.Drawing.Point(26, 55);
            this.chocolatecheckBox.Name = "chocolatecheckBox";
            this.chocolatecheckBox.Size = new System.Drawing.Size(100, 24);
            this.chocolatecheckBox.TabIndex = 0;
            this.chocolatecheckBox.Text = "Chocolate";
            this.chocolatecheckBox.UseVisualStyleBackColor = true;
            this.chocolatecheckBox.CheckedChanged += new System.EventHandler(this.chocolatecheckBox_CheckedChanged);
            // 
            // freshfruitcheckBox
            // 
            this.freshfruitcheckBox.AutoSize = true;
            this.freshfruitcheckBox.Location = new System.Drawing.Point(26, 27);
            this.freshfruitcheckBox.Name = "freshfruitcheckBox";
            this.freshfruitcheckBox.Size = new System.Drawing.Size(105, 24);
            this.freshfruitcheckBox.TabIndex = 0;
            this.freshfruitcheckBox.Text = "Fresh Fruit";
            this.freshfruitcheckBox.UseVisualStyleBackColor = true;
            this.freshfruitcheckBox.CheckedChanged += new System.EventHandler(this.freshfruitcheckBox_CheckedChanged);
            // 
            // processgroupBox
            // 
            this.processgroupBox.Controls.Add(this.exitbutton);
            this.processgroupBox.Controls.Add(this.resetbutton);
            this.processgroupBox.Controls.Add(this.checkoutbutton);
            this.processgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processgroupBox.Location = new System.Drawing.Point(347, 251);
            this.processgroupBox.Name = "processgroupBox";
            this.processgroupBox.Size = new System.Drawing.Size(230, 195);
            this.processgroupBox.TabIndex = 5;
            this.processgroupBox.TabStop = false;
            this.processgroupBox.Text = "Process";
            // 
            // totalamountlabel
            // 
            this.totalamountlabel.AutoSize = true;
            this.totalamountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamountlabel.Location = new System.Drawing.Point(460, 448);
            this.totalamountlabel.Name = "totalamountlabel";
            this.totalamountlabel.Size = new System.Drawing.Size(18, 20);
            this.totalamountlabel.TabIndex = 1;
            this.totalamountlabel.Text = "0";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(378, 448);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(44, 20);
            this.totallabel.TabIndex = 1;
            this.totallabel.Text = "Total";
            // 
            // numberlabel
            // 
            this.numberlabel.AutoSize = true;
            this.numberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberlabel.Location = new System.Drawing.Point(418, 12);
            this.numberlabel.Name = "numberlabel";
            this.numberlabel.Size = new System.Drawing.Size(235, 31);
            this.numberlabel.TabIndex = 6;
            this.numberlabel.Text = "Customer Number";
            // 
            // customerlabel
            // 
            this.customerlabel.AutoSize = true;
            this.customerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerlabel.Location = new System.Drawing.Point(35, 12);
            this.customerlabel.Name = "customerlabel";
            this.customerlabel.Size = new System.Drawing.Size(211, 31);
            this.customerlabel.TabIndex = 6;
            this.customerlabel.Text = "Customer Name";
            // 
            // customertextBox
            // 
            this.customertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customertextBox.Location = new System.Drawing.Point(268, 20);
            this.customertextBox.Name = "customertextBox";
            this.customertextBox.Size = new System.Drawing.Size(120, 26);
            this.customertextBox.TabIndex = 7;
            // 
            // numbertextBox
            // 
            this.numbertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbertextBox.Location = new System.Drawing.Point(671, 20);
            this.numbertextBox.Name = "numbertextBox";
            this.numbertextBox.Size = new System.Drawing.Size(117, 26);
            this.numbertextBox.TabIndex = 7;
            this.numbertextBox.TextChanged += new System.EventHandler(this.numbertextBox_TextChanged);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.Color.Red;
            this.titlelabel.Location = new System.Drawing.Point(262, 52);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(263, 31);
            this.titlelabel.TabIndex = 8;
            this.titlelabel.Text = "ICE CREAM SHOP";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.smallradioButton.CheckedChanged += new System.EventHandler(this.smallradioButton_CheckedChanged);
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
            this.mediumradioButton.CheckedChanged += new System.EventHandler(this.mediumradioButton_CheckedChanged);
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
            this.largeradioButton.CheckedChanged += new System.EventHandler(this.largeradioButton_CheckedChanged);
            // 
            // icecreamsizegroupBox
            // 
            this.icecreamsizegroupBox.Controls.Add(this.largeradioButton);
            this.icecreamsizegroupBox.Controls.Add(this.mediumradioButton);
            this.icecreamsizegroupBox.Controls.Add(this.smallradioButton);
            this.icecreamsizegroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icecreamsizegroupBox.Location = new System.Drawing.Point(60, 102);
            this.icecreamsizegroupBox.Name = "icecreamsizegroupBox";
            this.icecreamsizegroupBox.Size = new System.Drawing.Size(200, 105);
            this.icecreamsizegroupBox.TabIndex = 3;
            this.icecreamsizegroupBox.TabStop = false;
            this.icecreamsizegroupBox.Text = "Ice Cream Size";
            // 
            // icecreamtypelabel
            // 
            this.icecreamtypelabel.AutoSize = true;
            this.icecreamtypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icecreamtypelabel.Location = new System.Drawing.Point(396, 223);
            this.icecreamtypelabel.Name = "icecreamtypelabel";
            this.icecreamtypelabel.Size = new System.Drawing.Size(82, 20);
            this.icecreamtypelabel.TabIndex = 10;
            this.icecreamtypelabel.Text = "Ice Cream";
            this.icecreamtypelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icecreampictureBox
            // 
            this.icecreampictureBox.Image = global::Lab3a.Properties.Resources.vanilla;
            this.icecreampictureBox.Location = new System.Drawing.Point(347, 86);
            this.icecreampictureBox.Name = "icecreampictureBox";
            this.icecreampictureBox.Size = new System.Drawing.Size(175, 134);
            this.icecreampictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icecreampictureBox.TabIndex = 9;
            this.icecreampictureBox.TabStop = false;
            // 
            // receiptbutton
            // 
            this.receiptbutton.Location = new System.Drawing.Point(0, 0);
            this.receiptbutton.Name = "receiptbutton";
            this.receiptbutton.Size = new System.Drawing.Size(75, 23);
            this.receiptbutton.TabIndex = 0;
            // 
            // rec_button
            // 
            this.rec_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec_button.Location = new System.Drawing.Point(373, 499);
            this.rec_button.Name = "rec_button";
            this.rec_button.Size = new System.Drawing.Size(127, 37);
            this.rec_button.TabIndex = 11;
            this.rec_button.Text = "See my receipt";
            this.shoptoolTip.SetToolTip(this.rec_button, "show receipt");
            this.rec_button.UseVisualStyleBackColor = true;
            this.rec_button.Click += new System.EventHandler(this.rec_button_Click);
            // 
            // shopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.rec_button);
            this.Controls.Add(this.receiptbutton);
            this.Controls.Add(this.icecreamtypelabel);
            this.Controls.Add(this.icecreampictureBox);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.totalamountlabel);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.numbertextBox);
            this.Controls.Add(this.customertextBox);
            this.Controls.Add(this.customerlabel);
            this.Controls.Add(this.numberlabel);
            this.Controls.Add(this.processgroupBox);
            this.Controls.Add(this.toppingsgroupBox);
            this.Controls.Add(this.icecreamsizegroupBox);
            this.Controls.Add(this.icecreamtypegroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "shopForm";
            this.Text = "shopForm";
            this.Load += new System.EventHandler(this.shopForm_Load);
            this.icecreamtypegroupBox.ResumeLayout(false);
            this.icecreamtypegroupBox.PerformLayout();
            this.toppingsgroupBox.ResumeLayout(false);
            this.toppingsgroupBox.PerformLayout();
            this.processgroupBox.ResumeLayout(false);
            this.icecreamsizegroupBox.ResumeLayout(false);
            this.icecreamsizegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icecreampictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.GroupBox icecreamtypegroupBox;
        private System.Windows.Forms.RadioButton vanillaradioButton;
        private System.Windows.Forms.RadioButton chocolateradioButton;
        private System.Windows.Forms.RadioButton strawberryradioButton;
        private System.Windows.Forms.ToolTip shoptoolTip;
        private System.Windows.Forms.GroupBox toppingsgroupBox;
        private System.Windows.Forms.CheckBox mintcheckBox;
        private System.Windows.Forms.CheckBox carmelcheckBox;
        private System.Windows.Forms.CheckBox chocolatecheckBox;
        private System.Windows.Forms.CheckBox freshfruitcheckBox;
        private System.Windows.Forms.GroupBox processgroupBox;
        private System.Windows.Forms.Label totalamountlabel;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button checkoutbutton;
        private System.Windows.Forms.Label numberlabel;
        private System.Windows.Forms.Label customerlabel;
        private System.Windows.Forms.TextBox customertextBox;
        private System.Windows.Forms.TextBox numbertextBox;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.PictureBox icecreampictureBox;
        private System.Windows.Forms.RadioButton smallradioButton;
        private System.Windows.Forms.RadioButton mediumradioButton;
        private System.Windows.Forms.RadioButton largeradioButton;
        private System.Windows.Forms.GroupBox icecreamsizegroupBox;
        private System.Windows.Forms.Label icecreamtypelabel;
        private System.Windows.Forms.Button receiptbutton;
        private System.Windows.Forms.Button rec_button;
    }
}
namespace Lab4
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.reportbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.travelRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataSet = new Lab4.TravelDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ReportdataGridView = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeforTravelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripDatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelRequestsTableAdapter = new Lab4.TravelDataSetTableAdapters.TravelRequestsTableAdapter();
            this.Excelbutton = new System.Windows.Forms.Button();
            this.firstformbutton = new System.Windows.Forms.Button();
            this.ReporttoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Exitbutton = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dateTimeLabel = new System.Windows.Forms.ToolStripLabel();
            this.reporttimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportbindingNavigator)).BeginInit();
            this.reportbindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportbindingNavigator
            // 
            this.reportbindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reportbindingNavigator.BindingSource = this.travelRequestsBindingSource;
            this.reportbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reportbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reportbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dateTimeLabel});
            this.reportbindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reportbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reportbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reportbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reportbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reportbindingNavigator.Name = "reportbindingNavigator";
            this.reportbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reportbindingNavigator.Size = new System.Drawing.Size(800, 26);
            this.reportbindingNavigator.TabIndex = 0;
            this.reportbindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // travelRequestsBindingSource
            // 
            this.travelRequestsBindingSource.DataMember = "TravelRequests";
            this.travelRequestsBindingSource.DataSource = this.travelDataSet;
            // 
            // travelDataSet
            // 
            this.travelDataSet.DataSetName = "TravelDataSet";
            this.travelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(41, 23);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // ReportdataGridView
            // 
            this.ReportdataGridView.AutoGenerateColumns = false;
            this.ReportdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.purposeforTravelDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.tripDatesDataGridViewTextBoxColumn,
            this.travelCostDataGridViewTextBoxColumn});
            this.ReportdataGridView.DataSource = this.travelRequestsBindingSource;
            this.ReportdataGridView.Location = new System.Drawing.Point(28, 107);
            this.ReportdataGridView.Name = "ReportdataGridView";
            this.ReportdataGridView.Size = new System.Drawing.Size(745, 150);
            this.ReportdataGridView.TabIndex = 1;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // purposeforTravelDataGridViewTextBoxColumn
            // 
            this.purposeforTravelDataGridViewTextBoxColumn.DataPropertyName = "PurposeforTravel";
            this.purposeforTravelDataGridViewTextBoxColumn.HeaderText = "PurposeforTravel";
            this.purposeforTravelDataGridViewTextBoxColumn.Name = "purposeforTravelDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // tripDatesDataGridViewTextBoxColumn
            // 
            this.tripDatesDataGridViewTextBoxColumn.DataPropertyName = "TripDates";
            this.tripDatesDataGridViewTextBoxColumn.HeaderText = "TripDates";
            this.tripDatesDataGridViewTextBoxColumn.Name = "tripDatesDataGridViewTextBoxColumn";
            // 
            // travelCostDataGridViewTextBoxColumn
            // 
            this.travelCostDataGridViewTextBoxColumn.DataPropertyName = "TravelCost";
            this.travelCostDataGridViewTextBoxColumn.HeaderText = "TravelCost";
            this.travelCostDataGridViewTextBoxColumn.Name = "travelCostDataGridViewTextBoxColumn";
            // 
            // travelRequestsTableAdapter
            // 
            this.travelRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // Excelbutton
            // 
            this.Excelbutton.Location = new System.Drawing.Point(123, 344);
            this.Excelbutton.Name = "Excelbutton";
            this.Excelbutton.Size = new System.Drawing.Size(108, 23);
            this.Excelbutton.TabIndex = 2;
            this.Excelbutton.Text = "Export to Excel";
            this.ReporttoolTip.SetToolTip(this.Excelbutton, "Export to Excel");
            this.Excelbutton.UseVisualStyleBackColor = true;
            this.Excelbutton.Click += new System.EventHandler(this.Excelbutton_Click);
            // 
            // firstformbutton
            // 
            this.firstformbutton.Location = new System.Drawing.Point(277, 343);
            this.firstformbutton.Name = "firstformbutton";
            this.firstformbutton.Size = new System.Drawing.Size(112, 23);
            this.firstformbutton.TabIndex = 3;
            this.firstformbutton.Text = "Go to First Form";
            this.firstformbutton.UseVisualStyleBackColor = true;
            this.firstformbutton.Click += new System.EventHandler(this.firstformbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(443, 343);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 4;
            this.Exitbutton.Text = "Exit";
            this.ReporttoolTip.SetToolTip(this.Exitbutton, "Exit the program");
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(67, 23);
            this.dateTimeLabel.Text = "DateTime";
            // 
            // reporttimer
            // 
            this.reporttimer.Enabled = true;
            this.reporttimer.Interval = 1000;
            this.reporttimer.Tick += new System.EventHandler(this.reporttimer_Tick);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.firstformbutton);
            this.Controls.Add(this.Excelbutton);
            this.Controls.Add(this.ReportdataGridView);
            this.Controls.Add(this.reportbindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportbindingNavigator)).EndInit();
            this.reportbindingNavigator.ResumeLayout(false);
            this.reportbindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator reportbindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView ReportdataGridView;
        private TravelDataSet travelDataSet;
        private System.Windows.Forms.BindingSource travelRequestsBindingSource;
        private TravelDataSetTableAdapters.TravelRequestsTableAdapter travelRequestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeforTravelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripDatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Excelbutton;
        private System.Windows.Forms.ToolTip ReporttoolTip;
        private System.Windows.Forms.Button firstformbutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripLabel dateTimeLabel;
        private System.Windows.Forms.Timer reporttimer;
    }
}
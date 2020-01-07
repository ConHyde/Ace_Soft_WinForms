namespace AceSoft
{
    partial class EmployeesListForm
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
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.grdEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(12, 12);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(65, 43);
            this.btnAddDriver.TabIndex = 2;
            this.btnAddDriver.Text = "New Employee";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // grdEmployees
            // 
            this.grdEmployees.AllowUserToAddRows = false;
            this.grdEmployees.AllowUserToDeleteRows = false;
            this.grdEmployees.AllowUserToOrderColumns = true;
            this.grdEmployees.AllowUserToResizeColumns = false;
            this.grdEmployees.AllowUserToResizeRows = false;
            this.grdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployees.Location = new System.Drawing.Point(12, 61);
            this.grdEmployees.MultiSelect = false;
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.ReadOnly = true;
            this.grdEmployees.RowHeadersVisible = false;
            this.grdEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployees.Size = new System.Drawing.Size(680, 540);
            this.grdEmployees.TabIndex = 0;
            this.grdEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmployees_CellDoubleClick);
            this.grdEmployees.SelectionChanged += new System.EventHandler(this.grdEmployees_SelectionChanged);
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 613);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.grdEmployees);
            this.Name = "EmployeesListForm";
            this.Text = "Employees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeesListForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEmployees;
        private System.Windows.Forms.Button btnAddDriver;
    }
}
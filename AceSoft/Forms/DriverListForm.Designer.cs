namespace AceSoft
{
    partial class DriverListForm
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
            this.grdDrivers = new System.Windows.Forms.DataGridView();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.pnlDriverList = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDrivers)).BeginInit();
            this.pnlDriverList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDrivers
            // 
            this.grdDrivers.AllowUserToAddRows = false;
            this.grdDrivers.AllowUserToDeleteRows = false;
            this.grdDrivers.AllowUserToResizeRows = false;
            this.grdDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDrivers.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.grdDrivers.Location = new System.Drawing.Point(21, 49);
            this.grdDrivers.MultiSelect = false;
            this.grdDrivers.Name = "grdDrivers";
            this.grdDrivers.ReadOnly = true;
            this.grdDrivers.RowHeadersVisible = false;
            this.grdDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDrivers.Size = new System.Drawing.Size(1005, 564);
            this.grdDrivers.TabIndex = 0;
            this.grdDrivers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDrivers_CellDoubleClick);
            this.grdDrivers.SelectionChanged += new System.EventHandler(this.grdDrivers_SelectionChanged);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(21, 3);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(65, 43);
            this.btnAddDriver.TabIndex = 1;
            this.btnAddDriver.Text = "New Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // pnlDriverList
            // 
            this.pnlDriverList.Controls.Add(this.btnAddDriver);
            this.pnlDriverList.Controls.Add(this.grdDrivers);
            this.pnlDriverList.Location = new System.Drawing.Point(0, -1);
            this.pnlDriverList.Name = "pnlDriverList";
            this.pnlDriverList.Size = new System.Drawing.Size(1051, 616);
            this.pnlDriverList.TabIndex = 2;
            // 
            // DriverListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 627);
            this.Controls.Add(this.pnlDriverList);
            this.Name = "DriverListForm";
            this.Text = "";
            this.Activated += new System.EventHandler(this.DriverListForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DriverList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grdDrivers)).EndInit();
            this.pnlDriverList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDrivers;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Panel pnlDriverList;
    }
}
namespace AceSoft
{
    partial class Main
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
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrivers
            // 
            this.btnDrivers.Location = new System.Drawing.Point(1105, 24);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(135, 90);
            this.btnDrivers.TabIndex = 0;
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(1105, 120);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(135, 90);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Visible = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 647);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnDrivers);
            this.Name = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnEmployees;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AceSoft
{
    public partial class EmployeesListForm : AceForm
    {
        private int employeeSelected = 0;
        public EmployeesListForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                grdEmployees.DataSource = EmployeeFactory.Instance.GetEmployees();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Database has failed to load the Employee data", "Error");
                throw ex;
            }

            grdEmployees.Columns[0].Visible = false;

        }

        private void EmployeesListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void grdEmployees_SelectionChanged(object sender, EventArgs e)
        {
            int rowIndex;
            if (grdEmployees.SelectedRows.Count > 0)
            {
                rowIndex = grdEmployees.SelectedRows[0].Index;

                employeeSelected = Int32.Parse(this.grdEmployees[0, rowIndex].Value.ToString());
            }
        }

        private void grdEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeForm form = new EmployeeForm(employeeSelected);
            form.ShowDialog();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm(0);
            form.ShowDialog();
        }
    }
}

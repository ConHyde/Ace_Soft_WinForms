using AceSoftAccess;
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
    public partial class EmployeeForm : AceForm
    {
        Employee _employee = null;
        public EmployeeForm(int employeeId)
        {
            InitializeComponent();
            LoadEmployee(employeeId);
        }

        private void LoadEmployee(int employeeId)
        {
            if(employeeId > 0)
            {
                try
                {
                    _employee = EmployeeFactory.Instance.GetEmployeeFromId(employeeId);

                    txtName.Text = _employee.Name;
                    ckDisabled.Checked = _employee.Disabled;
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

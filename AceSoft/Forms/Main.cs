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
    public partial class Main : AceForm
    {
        public Main()
        {
            InitializeComponent();
            Text = base.Text;
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            DriverListForm form = new DriverListForm();
            form.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesListForm form = new EmployeesListForm();
            form.ShowDialog();
            
        }
    }
}

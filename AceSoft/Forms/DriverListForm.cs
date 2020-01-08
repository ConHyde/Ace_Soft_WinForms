using AceSoftAccess;
using AceSoftServices.Controllers;
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
    public partial class DriverListForm : AceForm
    {
        private int driverSelected = 0;
        private bool _prospects = false;
        private bool _archived = false;
        public DriverListForm()
        {
            this.Text = base.Text;
            InitializeComponent();
            LoadForm();
        }

        public void RefreshDrivers()
        { 
            try
            {
                using (AceSoftDataEntities db = new AceSoftDataEntities())
                {
                    var drivers = db.Drivers.OrderBy(d => d.Surname).Select(d => new
                    {
                        DriverId = d.Id,
                        Surname = d.Surname,
                        Forname = d.Forename,
                        Mobile = d.Mobile,
                        LastContacted = d.Last_Contact,
                        LastSpokeTo = d.Employee.Name,
                        CPCExpiry = d.CPC_Expiry,
                        DigiExpiry = d.Digi_Expiry,
                        LicenseExpiry = d.License_Expiry,
                        LicenseNextCheck = d.License_Next_Check,
                        Prospect = d.Prospect,
                        Archived = d.Archived

                    }).ToList();                    grdDrivers.DataSource = drivers.Where(d => (d.Prospect == _prospects)).ToList();

                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Database has failed to load the driver data", "Error");
                throw ex;
            }

        }

        public void LoadForm()
        {
            RefreshDrivers();            
        }

        private void DriverList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            Driver newDriver = new Driver();
            DriverForm driverForm = new DriverForm(0);
            driverForm.ShowDialog();
        }

        private void grdDrivers_SelectionChanged(object sender, EventArgs e)
        {
            int rowIndex;
            if (grdDrivers.SelectedRows.Count > 0) 
            {
                 rowIndex =  grdDrivers.SelectedRows[0].Index;
                 
                driverSelected = Int32.Parse(this.grdDrivers[0, rowIndex].Value.ToString());
            }
        }

        private void grdDrivers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DriverForm form = new DriverForm(driverSelected);
            form.ShowDialog();
        }

        private void DriverListForm_Activated(object sender, EventArgs e)
        {
            RefreshDrivers();
        }

        private void ckProspects_CheckedChanged(object sender, EventArgs e)
        {
            _prospects = ckProspects.Checked;
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDrivers();
        }
    }
}

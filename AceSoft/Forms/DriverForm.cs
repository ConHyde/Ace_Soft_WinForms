using AceSoftAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AceSoft
{
    public partial class DriverForm : AceForm
    {
        private Driver _driver = new Driver();
        public DriverForm(int driverId)
        {
            InitializeComponent();
            Text = base.Text;
            LoadDriver(driverId);
            BindControls();   
        }

        protected void BindControls()
        {
            using (AceSoftDataEntities db = new AceSoftDataEntities())
            {
                //.Join(
                //db.Drivers,
                //employee => employee.Id,
                //driver => driver.Employee.Id,
                //(employee, driver) => new
                //{
                //    DriverId = driver.Id,
                //    EmployeeId = employee.Id,
                //    EmployeeName = employee.Name
                //}
                //    ).ToList();
                //}

                cmbStaffContacted.DataSource = db.Employees.ToList();
                cmbStaffContacted.DisplayMember = "Name";
                cmbStaffContacted.ValueMember = "Id";

                if (_driver.Id != 0)
                {
                    cmbStaffContacted.SelectedValue = _driver.Employee.Id;
                }
                else
                {
                    cmbStaffContacted.SelectedValue = 1;

                }
            }

        }

        private bool SetControlError(List<Control> controls)
        {
            bool result = true;

            if (controls.Count > 0)
            {
                foreach (Control c in controls)
                {
                    c.BackColor = Color.Red;
                    c.ForeColor = Color.DarkRed;
                }
                result = false;
            }
            return result;
        }

        private bool ValidateEntry()
        {
            List<Control> errorControls = new List<Control>();

            bool result = true;

            if (String.IsNullOrEmpty(txtCity.Text))
            {
                errorControls.Add(txtCity);
            }
            if (String.IsNullOrEmpty(txtForename.Text))
            {
                errorControls.Add(txtForename);
            }
            if (String.IsNullOrEmpty(txtSurname.Text))
            {
                errorControls.Add(txtSurname);
            }
            if (String.IsNullOrEmpty(txtMobile.Text))
            {
                errorControls.Add(txtMobile);
            }
            if (cmbStaffContacted.SelectedItem == null)
            {
                errorControls.Add(cmbStaffContacted);
            }

            if (!ckProspect.Checked && !_driver.Prospect || _driver.Id > 0 && !ckProspect.Checked)
            {
                if (String.IsNullOrEmpty(txtAddress.Text))
                {
                    errorControls.Add(txtAddress);
                }
                //if (String.IsNullOrEmpty(txtEmail.Text))
                //{
                //    errorControls.Add(txtEmail);
                //}
                if (String.IsNullOrEmpty(txtLicenseNumber.Text))
                {
                    errorControls.Add(txtLicenseNumber);
                }
                if (String.IsNullOrEmpty(txtNationality.Text))
                {
                    errorControls.Add(txtNationality);
                }
                if (String.IsNullOrEmpty(txtNI_Num.Text))
                {
                    errorControls.Add(txtNI_Num);
                }
                if (String.IsNullOrEmpty(txtPostcode.Text))
                {
                    errorControls.Add(txtPostcode);
                }
                //if (String.IsNullOrEmpty(txtTelephone.Text))
                //{
                //    errorControls.Add(txtTelephone);
                //}
                //if (dtCPC_Expiry.Value.Date == DateTime.Now.Date)
                //{
                //    errorControls.Add(dtCPC_Expiry);
                //}
                //if (dtDigi_Expiry.Value.Date == DateTime.Now.Date)
                //{
                //    errorControls.Add(dtDigi_Expiry);
                //}
                //if (dtLicenseExpiry.Value.Date == DateTime.Now.Date)
                //{
                //    errorControls.Add(dtLicenseExpiry);
                //}
                //if (dtDoB.Value.Date == DateTime.Now.Date)
                //{
                //    errorControls.Add(dtDoB);
                //}
            }
            result = SetControlError(errorControls);

            if (_driver.Id == 0)
            {
                result = !CheckDuplicateDriver();
            }

            return result;
        }

        private bool CheckDuplicateDriver()
        {
            bool result = false; 

            if (txtSurname.Text != null && txtMobile.Text != null)
            {
                result = DriverFactory.Instance.IsDuplicate(txtSurname.Text, txtMobile.Text);

                if (result)
                {
                    MessageBox.Show("This driver already exists!", "ERROR");
                }
            }

                return result;
        }

        private void LoadDriver(int driverId)
        {
            if (driverId > 0)
            {
                _driver = DriverFactory.Instance.GetDriverFromId(driverId);

                txtAddress.Text = _driver.City;
                txtCity.Text = _driver.City;
                txtEmail.Text = _driver.Email;
                txtForename.Text = _driver.Forename;
                txtLicenseNumber.Text = _driver.License_Num;
                txtMobile.Text = _driver.Mobile;
                txtNationality.Text = _driver.Nationality;
                txtNI_Num.Text = _driver.NI_Num;
                txtPostcode.Text = _driver.Postcode;
                txtSurname.Text = _driver.Surname;
                txtTelephone.Text = _driver.Telephone;
                dtDoB.Value = _driver.DoB ?? DateTime.Now;
                dtCPC_Expiry.Value = _driver.CPC_Expiry ?? DateTime.Now;
                dtDigi_Expiry.Value = _driver.Digi_Expiry ?? DateTime.Now;
                dtLicenseChecked.Value = _driver.License_Checked ?? DateTime.Now;
                dtLicenseExpiry.Value = _driver.License_Expiry ?? DateTime.Now;
                dtLicenseNextCheck.Value = _driver.License_Next_Check ?? DateTime.Now;
                dtLicenseValid.Value = _driver.License_Valid ?? DateTime.Now;
                cmbStaffContacted.SelectedValue = _driver.EmployeeId;
                cmbStaffContacted.ValueMember = _driver.Employee.Name;
                ckOwnCar.Checked = _driver.Car_Owned;
                ckArchived.Checked = _driver.Archived;
                ckProspect.Checked = _driver.Prospect;
                ckClass1.Checked = _driver.Class1;
                ckClass2.Checked = _driver.Class2;
                ckTrunking.Checked = _driver.Trunking;
                ckMultidrop.Checked = _driver.Multidrop;
                ckMorning.Checked = _driver.Morning;
                ckNight.Checked = _driver.Night;
                ckNightOut.Checked = _driver.NightOut;
                ckTramping.Checked = _driver.Tramping;
                rtxtNotes.Text = _driver.Notes;
            }
            if(_driver.Prospect || _driver.Id == 0)
            {
                BackColor = Color.LightYellow;
                lblProspect.Visible = true;
                ckProspect.Enabled = true;
                ckProspect.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {

                _driver.Address = txtAddress.Text;
                _driver.City = txtCity.Text;
                _driver.Email = txtEmail.Text;
                _driver.Forename = txtForename.Text;
                _driver.License_Num = txtLicenseNumber.Text;
                _driver.Mobile = txtMobile.Text;
                _driver.Nationality = txtNationality.Text;
                _driver.NI_Num = txtNI_Num.Text;
                _driver.Postcode = txtPostcode.Text;
                _driver.Surname = txtSurname.Text;
                _driver.Telephone = txtTelephone.Text;
                _driver.CPC_Expiry = dtCPC_Expiry.Value.Date;
                _driver.Digi_Expiry = dtDigi_Expiry.Value.Date;
                _driver.License_Checked = dtLicenseChecked.Value.Date;
                _driver.License_Expiry = dtLicenseExpiry.Value.Date;
                _driver.License_Next_Check = dtLicenseChecked.Value.AddDays(90);
                _driver.License_Valid = dtLicenseValid.Value;
                _driver.EmployeeId = Int32.Parse(cmbStaffContacted.SelectedValue.ToString());
                _driver.Last_Contact = dtLast_Contacted.Value.Date;
                _driver.Car_Owned = ckOwnCar.Checked;
                _driver.Archived = ckArchived.Checked;
                _driver.Prospect = ckProspect.Checked;
                _driver.Class1 = ckClass1.Checked;
                _driver.Class2 = ckClass2.Checked;
                _driver.Trunking = ckTrunking.Checked;
                _driver.Multidrop = ckMultidrop.Checked;
                _driver.Morning = ckMorning.Checked;
                _driver.Night = ckNight.Checked;
                _driver.NightOut = ckNightOut.Checked;
                _driver.Tramping = ckTramping.Checked;
                _driver.Notes = rtxtNotes.Text;

                DriverFactory.Instance.UpsertDriver(_driver);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all fields before saving", "Warning");
            }

        }

        private void btnLicenseChecked_Click(object sender, EventArgs e)
        {
            dtLicenseChecked.Value = DateTime.Now.Date;
        }

        private void btnContacted_Click(object sender, EventArgs e)
        {
            dtLast_Contacted.Value = DateTime.Now.Date;
        }

        private void ckProspect_CheckedChanged(object sender, EventArgs e)
        {
            if (!ValidateEntry())
            {
                ckProspect.Checked = true;
            }
        }
    }
}

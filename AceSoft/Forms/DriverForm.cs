﻿using AceSoftAccess;
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
                cmbStaffContacted.SelectedValue = _driver.Id; 
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
            
            if(String.IsNullOrEmpty(txtAddress.Text))
            {
                errorControls.Add(txtAddress);
            }
            if (String.IsNullOrEmpty(txtCity.Text))
            {
                errorControls.Add(txtCity);
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                errorControls.Add(txtEmail);
            }
            if (String.IsNullOrEmpty(txtForename.Text))
            {
                errorControls.Add(txtForename);
            }
            if (String.IsNullOrEmpty(txtLicenseNumber.Text))
            {
                errorControls.Add(txtLicenseNumber);
            }
            if (String.IsNullOrEmpty(txtMobile.Text))
            {
                errorControls.Add(txtMobile);
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
            if (String.IsNullOrEmpty(txtSurname.Text))
            {
                errorControls.Add(txtSurname);
            }
            if (String.IsNullOrEmpty(txtTelephone.Text))
            {
                errorControls.Add(txtTelephone);
            }
            if (dtCPC_Expiry.Value.Date == DateTime.Now.Date)
            {
                errorControls.Add(dtCPC_Expiry);
            }
            if (dtDigi_Expiry.Value.Date == DateTime.Now.Date)
            {
                errorControls.Add(dtDigi_Expiry);
            }
            if (dtLicenseExpiry.Value.Date == DateTime.Now.Date)
            {
                errorControls.Add(dtLicenseExpiry);
            }
            if (dtDoB.Value.Date == DateTime.Now.Date)
            {
                errorControls.Add(dtDoB);
            }
            if (cmbStaffContacted.SelectedItem == null)
            {
                errorControls.Add(cmbStaffContacted);
            }

            result = SetControlError(errorControls);

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
                txtPostcode.Text = _driver.Postcode; ;
                txtSurname.Text = _driver.Surname;
                txtTelephone.Text = _driver.Telephone;
                dtDoB.Value = _driver.DoB;
                dtCPC_Expiry.Value = _driver.CPC_Expiry ?? DateTime.Now;
                dtDigi_Expiry.Value = _driver.Digi_Expiry ?? DateTime.Now;
                dtLicenseChecked.Value = _driver.License_Checked ?? DateTime.Now;
                dtLicenseExpiry.Value = _driver.License_Expiry ?? DateTime.Now;
                dtLicenseNextCheck.Value = _driver.License_Next_Check ?? DateTime.Now;
                dtLicenseValid.Value = _driver.License_Valid ?? DateTime.Now;
                cmbStaffContacted.ValueMember = _driver.Employee.Name;
                cmbStaffContacted.SelectedValue = _driver.EmployeeId;
                ckOwnCar.Checked = _driver.Car_Owned;
                ckArchived.Checked = _driver.Archived;

                
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
                _driver.Employee.Id = Int32.Parse(cmbStaffContacted.SelectedValue.ToString());
                _driver.Car_Owned = ckOwnCar.Checked;
                _driver.Archived = ckArchived.Checked;

                DriverFactory.Instance.UpsertDriver(_driver);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all fields before saving", "Eat my smelly cunt");
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
    }
}
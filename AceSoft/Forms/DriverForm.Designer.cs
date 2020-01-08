namespace AceSoft
{
    partial class DriverForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblNI_Num = new System.Windows.Forms.Label();
            this.txtNI_Num = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.LblLicenseNumber = new System.Windows.Forms.Label();
            this.lblStaffContacted = new System.Windows.Forms.Label();
            this.cmbStaffContacted = new System.Windows.Forms.ComboBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblLastContacted = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblLicenseChecked = new System.Windows.Forms.Label();
            this.btnContacted = new System.Windows.Forms.Button();
            this.lblLicenseNextCheck = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.ckOwnCar = new System.Windows.Forms.CheckBox();
            this.lblCPC_Expiry = new System.Windows.Forms.Label();
            this.lblLicenseValid = new System.Windows.Forms.Label();
            this.lblLicenseExpiry = new System.Windows.Forms.Label();
            this.lblDigi_Expiry = new System.Windows.Forms.Label();
            this.dtDigi_Expiry = new System.Windows.Forms.DateTimePicker();
            this.dtCPC_Expiry = new System.Windows.Forms.DateTimePicker();
            this.dtLicenseExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtLicenseValid = new System.Windows.Forms.DateTimePicker();
            this.dtLicenseNextCheck = new System.Windows.Forms.DateTimePicker();
            this.dtLicenseChecked = new System.Windows.Forms.DateTimePicker();
            this.dtDoB = new System.Windows.Forms.DateTimePicker();
            this.dtLast_Contacted = new System.Windows.Forms.DateTimePicker();
            this.btnLicenseChecked = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckClass1 = new System.Windows.Forms.CheckBox();
            this.ckMorning = new System.Windows.Forms.CheckBox();
            this.ckTramping = new System.Windows.Forms.CheckBox();
            this.ckMultidrop = new System.Windows.Forms.CheckBox();
            this.ckClass2 = new System.Windows.Forms.CheckBox();
            this.ckNight = new System.Windows.Forms.CheckBox();
            this.ckNightOut = new System.Windows.Forms.CheckBox();
            this.ckTrunking = new System.Windows.Forms.CheckBox();
            this.ckProspect = new System.Windows.Forms.CheckBox();
            this.ckArchived = new System.Windows.Forms.CheckBox();
            this.lblProspect = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(335, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSurname.Location = new System.Drawing.Point(109, 21);
            this.txtSurname.MaxLength = 50;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(179, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(109, 47);
            this.txtForename.MaxLength = 50;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(179, 20);
            this.txtForename.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(4, 24);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(56, 13);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname*:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(4, 50);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(72, 13);
            this.lblForename.TabIndex = 6;
            this.lblForename.Text = "Forename(s)*:";
            // 
            // lblNI_Num
            // 
            this.lblNI_Num.AutoSize = true;
            this.lblNI_Num.Location = new System.Drawing.Point(353, 28);
            this.lblNI_Num.Name = "lblNI_Num";
            this.lblNI_Num.Size = new System.Drawing.Size(99, 13);
            this.lblNI_Num.TabIndex = 7;
            this.lblNI_Num.Text = "National Insurance:";
            // 
            // txtNI_Num
            // 
            this.txtNI_Num.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNI_Num.Location = new System.Drawing.Point(465, 25);
            this.txtNI_Num.MaxLength = 9;
            this.txtNI_Num.Name = "txtNI_Num";
            this.txtNI_Num.Size = new System.Drawing.Size(179, 20);
            this.txtNI_Num.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(4, 77);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(109, 74);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(179, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(4, 103);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 13);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "City*:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(109, 100);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(179, 20);
            this.txtCity.TabIndex = 12;
            // 
            // txtPostcode
            // 
            this.txtPostcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPostcode.Location = new System.Drawing.Point(109, 126);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(95, 20);
            this.txtPostcode.TabIndex = 13;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(4, 129);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(55, 13);
            this.lblPostcode.TabIndex = 14;
            this.lblPostcode.Text = "Postcode:";
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLicenseNumber.Location = new System.Drawing.Point(465, 51);
            this.txtLicenseNumber.MaxLength = 20;
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(179, 20);
            this.txtLicenseNumber.TabIndex = 15;
            // 
            // LblLicenseNumber
            // 
            this.LblLicenseNumber.AutoSize = true;
            this.LblLicenseNumber.Location = new System.Drawing.Point(353, 54);
            this.LblLicenseNumber.Name = "LblLicenseNumber";
            this.LblLicenseNumber.Size = new System.Drawing.Size(87, 13);
            this.LblLicenseNumber.TabIndex = 16;
            this.LblLicenseNumber.Text = "License Number:";
            // 
            // lblStaffContacted
            // 
            this.lblStaffContacted.AutoSize = true;
            this.lblStaffContacted.Location = new System.Drawing.Point(4, 183);
            this.lblStaffContacted.Name = "lblStaffContacted";
            this.lblStaffContacted.Size = new System.Drawing.Size(88, 13);
            this.lblStaffContacted.TabIndex = 17;
            this.lblStaffContacted.Text = "Staff Contacted*:";
            // 
            // cmbStaffContacted
            // 
            this.cmbStaffContacted.FormattingEnabled = true;
            this.cmbStaffContacted.Location = new System.Drawing.Point(109, 178);
            this.cmbStaffContacted.Name = "cmbStaffContacted";
            this.cmbStaffContacted.Size = new System.Drawing.Size(115, 21);
            this.cmbStaffContacted.TabIndex = 19;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(4, 210);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(45, 13);
            this.lblMobile.TabIndex = 20;
            this.lblMobile.Text = "Mobile*:";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(109, 205);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(179, 20);
            this.txtMobile.TabIndex = 21;
            // 
            // lblLastContacted
            // 
            this.lblLastContacted.AutoSize = true;
            this.lblLastContacted.Location = new System.Drawing.Point(4, 157);
            this.lblLastContacted.Name = "lblLastContacted";
            this.lblLastContacted.Size = new System.Drawing.Size(82, 13);
            this.lblLastContacted.TabIndex = 23;
            this.lblLastContacted.Text = "Last Contacted:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(109, 231);
            this.txtTelephone.MaxLength = 11;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(179, 20);
            this.txtTelephone.TabIndex = 25;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(4, 236);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(61, 13);
            this.lblTelephone.TabIndex = 24;
            this.lblTelephone.Text = "Telephone:";
            // 
            // lblLicenseChecked
            // 
            this.lblLicenseChecked.AutoSize = true;
            this.lblLicenseChecked.Location = new System.Drawing.Point(353, 80);
            this.lblLicenseChecked.Name = "lblLicenseChecked";
            this.lblLicenseChecked.Size = new System.Drawing.Size(93, 13);
            this.lblLicenseChecked.TabIndex = 27;
            this.lblLicenseChecked.Text = "License Checked:";
            // 
            // btnContacted
            // 
            this.btnContacted.Location = new System.Drawing.Point(230, 152);
            this.btnContacted.Name = "btnContacted";
            this.btnContacted.Size = new System.Drawing.Size(70, 20);
            this.btnContacted.TabIndex = 28;
            this.btnContacted.Text = "Contacted";
            this.btnContacted.UseVisualStyleBackColor = true;
            this.btnContacted.Click += new System.EventHandler(this.btnContacted_Click);
            // 
            // lblLicenseNextCheck
            // 
            this.lblLicenseNextCheck.AutoSize = true;
            this.lblLicenseNextCheck.Location = new System.Drawing.Point(353, 106);
            this.lblLicenseNextCheck.Name = "lblLicenseNextCheck";
            this.lblLicenseNextCheck.Size = new System.Drawing.Size(106, 13);
            this.lblLicenseNextCheck.TabIndex = 30;
            this.lblLicenseNextCheck.Text = "License Next Check:";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(4, 262);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(71, 13);
            this.lblDoB.TabIndex = 31;
            this.lblDoB.Text = "Date Of Birth:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(109, 283);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 34;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(4, 286);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email:";
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(109, 309);
            this.txtNationality.MaxLength = 25;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(179, 20);
            this.txtNationality.TabIndex = 36;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(4, 312);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(59, 13);
            this.lblNationality.TabIndex = 35;
            this.lblNationality.Text = "Nationality:";
            // 
            // ckOwnCar
            // 
            this.ckOwnCar.AutoSize = true;
            this.ckOwnCar.Location = new System.Drawing.Point(109, 335);
            this.ckOwnCar.Name = "ckOwnCar";
            this.ckOwnCar.Size = new System.Drawing.Size(67, 17);
            this.ckOwnCar.TabIndex = 37;
            this.ckOwnCar.Text = "Own Car";
            this.ckOwnCar.UseVisualStyleBackColor = true;
            // 
            // lblCPC_Expiry
            // 
            this.lblCPC_Expiry.Location = new System.Drawing.Point(353, 184);
            this.lblCPC_Expiry.Name = "lblCPC_Expiry";
            this.lblCPC_Expiry.Size = new System.Drawing.Size(106, 13);
            this.lblCPC_Expiry.TabIndex = 39;
            this.lblCPC_Expiry.Text = "CPC Expiry:";
            // 
            // lblLicenseValid
            // 
            this.lblLicenseValid.Location = new System.Drawing.Point(353, 132);
            this.lblLicenseValid.Name = "lblLicenseValid";
            this.lblLicenseValid.Size = new System.Drawing.Size(106, 13);
            this.lblLicenseValid.TabIndex = 40;
            this.lblLicenseValid.Text = "License Valid:";
            // 
            // lblLicenseExpiry
            // 
            this.lblLicenseExpiry.Location = new System.Drawing.Point(353, 158);
            this.lblLicenseExpiry.Name = "lblLicenseExpiry";
            this.lblLicenseExpiry.Size = new System.Drawing.Size(106, 13);
            this.lblLicenseExpiry.TabIndex = 42;
            this.lblLicenseExpiry.Text = "License Expiry:";
            // 
            // lblDigi_Expiry
            // 
            this.lblDigi_Expiry.Location = new System.Drawing.Point(353, 210);
            this.lblDigi_Expiry.Name = "lblDigi_Expiry";
            this.lblDigi_Expiry.Size = new System.Drawing.Size(106, 13);
            this.lblDigi_Expiry.TabIndex = 44;
            this.lblDigi_Expiry.Text = "Digi Expiry:";
            // 
            // dtDigi_Expiry
            // 
            this.dtDigi_Expiry.Location = new System.Drawing.Point(465, 207);
            this.dtDigi_Expiry.Name = "dtDigi_Expiry";
            this.dtDigi_Expiry.Size = new System.Drawing.Size(179, 20);
            this.dtDigi_Expiry.TabIndex = 46;
            // 
            // dtCPC_Expiry
            // 
            this.dtCPC_Expiry.Location = new System.Drawing.Point(465, 181);
            this.dtCPC_Expiry.Name = "dtCPC_Expiry";
            this.dtCPC_Expiry.Size = new System.Drawing.Size(179, 20);
            this.dtCPC_Expiry.TabIndex = 47;
            // 
            // dtLicenseExpiry
            // 
            this.dtLicenseExpiry.Location = new System.Drawing.Point(465, 155);
            this.dtLicenseExpiry.Name = "dtLicenseExpiry";
            this.dtLicenseExpiry.Size = new System.Drawing.Size(179, 20);
            this.dtLicenseExpiry.TabIndex = 48;
            // 
            // dtLicenseValid
            // 
            this.dtLicenseValid.Location = new System.Drawing.Point(465, 129);
            this.dtLicenseValid.Name = "dtLicenseValid";
            this.dtLicenseValid.Size = new System.Drawing.Size(179, 20);
            this.dtLicenseValid.TabIndex = 49;
            // 
            // dtLicenseNextCheck
            // 
            this.dtLicenseNextCheck.Enabled = false;
            this.dtLicenseNextCheck.Location = new System.Drawing.Point(465, 103);
            this.dtLicenseNextCheck.Name = "dtLicenseNextCheck";
            this.dtLicenseNextCheck.Size = new System.Drawing.Size(179, 20);
            this.dtLicenseNextCheck.TabIndex = 50;
            // 
            // dtLicenseChecked
            // 
            this.dtLicenseChecked.Location = new System.Drawing.Point(465, 77);
            this.dtLicenseChecked.Name = "dtLicenseChecked";
            this.dtLicenseChecked.Size = new System.Drawing.Size(179, 20);
            this.dtLicenseChecked.TabIndex = 51;
            // 
            // dtDoB
            // 
            this.dtDoB.Location = new System.Drawing.Point(109, 257);
            this.dtDoB.Name = "dtDoB";
            this.dtDoB.Size = new System.Drawing.Size(179, 20);
            this.dtDoB.TabIndex = 52;
            // 
            // dtLast_Contacted
            // 
            this.dtLast_Contacted.Location = new System.Drawing.Point(109, 152);
            this.dtLast_Contacted.Name = "dtLast_Contacted";
            this.dtLast_Contacted.Size = new System.Drawing.Size(115, 20);
            this.dtLast_Contacted.TabIndex = 53;
            // 
            // btnLicenseChecked
            // 
            this.btnLicenseChecked.Location = new System.Drawing.Point(465, 236);
            this.btnLicenseChecked.Name = "btnLicenseChecked";
            this.btnLicenseChecked.Size = new System.Drawing.Size(179, 25);
            this.btnLicenseChecked.TabIndex = 54;
            this.btnLicenseChecked.Text = "License Check Complete";
            this.btnLicenseChecked.UseVisualStyleBackColor = true;
            this.btnLicenseChecked.Click += new System.EventHandler(this.btnLicenseChecked_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNotes);
            this.panel1.Controls.Add(this.rtxtNotes);
            this.panel1.Controls.Add(this.ckClass1);
            this.panel1.Controls.Add(this.ckMorning);
            this.panel1.Controls.Add(this.ckTramping);
            this.panel1.Controls.Add(this.ckMultidrop);
            this.panel1.Controls.Add(this.ckClass2);
            this.panel1.Controls.Add(this.ckNight);
            this.panel1.Controls.Add(this.ckNightOut);
            this.panel1.Controls.Add(this.ckTrunking);
            this.panel1.Controls.Add(this.ckProspect);
            this.panel1.Controls.Add(this.ckArchived);
            this.panel1.Controls.Add(this.btnLicenseChecked);
            this.panel1.Controls.Add(this.dtLast_Contacted);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dtDoB);
            this.panel1.Controls.Add(this.dtLicenseChecked);
            this.panel1.Controls.Add(this.dtLicenseNextCheck);
            this.panel1.Controls.Add(this.dtLicenseValid);
            this.panel1.Controls.Add(this.dtLicenseExpiry);
            this.panel1.Controls.Add(this.dtCPC_Expiry);
            this.panel1.Controls.Add(this.dtDigi_Expiry);
            this.panel1.Controls.Add(this.lblDigi_Expiry);
            this.panel1.Controls.Add(this.lblLicenseExpiry);
            this.panel1.Controls.Add(this.lblLicenseValid);
            this.panel1.Controls.Add(this.lblCPC_Expiry);
            this.panel1.Controls.Add(this.ckOwnCar);
            this.panel1.Controls.Add(this.txtNationality);
            this.panel1.Controls.Add(this.lblNationality);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblDoB);
            this.panel1.Controls.Add(this.lblLicenseNextCheck);
            this.panel1.Controls.Add(this.btnContacted);
            this.panel1.Controls.Add(this.lblLicenseChecked);
            this.panel1.Controls.Add(this.txtTelephone);
            this.panel1.Controls.Add(this.lblTelephone);
            this.panel1.Controls.Add(this.lblLastContacted);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.lblMobile);
            this.panel1.Controls.Add(this.cmbStaffContacted);
            this.panel1.Controls.Add(this.lblStaffContacted);
            this.panel1.Controls.Add(this.LblLicenseNumber);
            this.panel1.Controls.Add(this.txtLicenseNumber);
            this.panel1.Controls.Add(this.lblPostcode);
            this.panel1.Controls.Add(this.txtPostcode);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtNI_Num);
            this.panel1.Controls.Add(this.lblNI_Num);
            this.panel1.Controls.Add(this.lblForename);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Controls.Add(this.txtForename);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Location = new System.Drawing.Point(27, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 441);
            this.panel1.TabIndex = 55;
            // 
            // ckClass1
            // 
            this.ckClass1.AutoSize = true;
            this.ckClass1.Location = new System.Drawing.Point(465, 286);
            this.ckClass1.Name = "ckClass1";
            this.ckClass1.Size = new System.Drawing.Size(57, 17);
            this.ckClass1.TabIndex = 65;
            this.ckClass1.Text = "Class1";
            this.ckClass1.UseVisualStyleBackColor = true;
            // 
            // ckMorning
            // 
            this.ckMorning.AutoSize = true;
            this.ckMorning.Location = new System.Drawing.Point(465, 308);
            this.ckMorning.Name = "ckMorning";
            this.ckMorning.Size = new System.Drawing.Size(64, 17);
            this.ckMorning.TabIndex = 64;
            this.ckMorning.Text = "Morning";
            this.ckMorning.UseVisualStyleBackColor = true;
            // 
            // ckTramping
            // 
            this.ckTramping.AutoSize = true;
            this.ckTramping.Location = new System.Drawing.Point(465, 331);
            this.ckTramping.Name = "ckTramping";
            this.ckTramping.Size = new System.Drawing.Size(70, 17);
            this.ckTramping.TabIndex = 63;
            this.ckTramping.Text = "Tramping";
            this.ckTramping.UseVisualStyleBackColor = true;
            // 
            // ckMultidrop
            // 
            this.ckMultidrop.AutoSize = true;
            this.ckMultidrop.Location = new System.Drawing.Point(465, 354);
            this.ckMultidrop.Name = "ckMultidrop";
            this.ckMultidrop.Size = new System.Drawing.Size(71, 17);
            this.ckMultidrop.TabIndex = 62;
            this.ckMultidrop.Text = "MultiDrop";
            this.ckMultidrop.UseVisualStyleBackColor = true;
            // 
            // ckClass2
            // 
            this.ckClass2.AutoSize = true;
            this.ckClass2.Location = new System.Drawing.Point(554, 283);
            this.ckClass2.Name = "ckClass2";
            this.ckClass2.Size = new System.Drawing.Size(57, 17);
            this.ckClass2.TabIndex = 61;
            this.ckClass2.Text = "Class2";
            this.ckClass2.UseVisualStyleBackColor = true;
            // 
            // ckNight
            // 
            this.ckNight.AutoSize = true;
            this.ckNight.Location = new System.Drawing.Point(554, 306);
            this.ckNight.Name = "ckNight";
            this.ckNight.Size = new System.Drawing.Size(51, 17);
            this.ckNight.TabIndex = 60;
            this.ckNight.Text = "Night";
            this.ckNight.UseVisualStyleBackColor = true;
            // 
            // ckNightOut
            // 
            this.ckNightOut.AutoSize = true;
            this.ckNightOut.Location = new System.Drawing.Point(554, 329);
            this.ckNightOut.Name = "ckNightOut";
            this.ckNightOut.Size = new System.Drawing.Size(68, 17);
            this.ckNightOut.TabIndex = 59;
            this.ckNightOut.Text = "NightOut";
            this.ckNightOut.UseVisualStyleBackColor = true;
            // 
            // ckTrunking
            // 
            this.ckTrunking.AutoSize = true;
            this.ckTrunking.Location = new System.Drawing.Point(554, 352);
            this.ckTrunking.Name = "ckTrunking";
            this.ckTrunking.Size = new System.Drawing.Size(68, 17);
            this.ckTrunking.TabIndex = 58;
            this.ckTrunking.Text = "Trunking";
            this.ckTrunking.UseVisualStyleBackColor = true;
            // 
            // ckProspect
            // 
            this.ckProspect.AutoSize = true;
            this.ckProspect.Enabled = false;
            this.ckProspect.Location = new System.Drawing.Point(341, 389);
            this.ckProspect.Name = "ckProspect";
            this.ckProspect.Size = new System.Drawing.Size(68, 17);
            this.ckProspect.TabIndex = 56;
            this.ckProspect.Text = "Prospect";
            this.ckProspect.UseVisualStyleBackColor = true;
            this.ckProspect.CheckedChanged += new System.EventHandler(this.ckProspect_CheckedChanged);
            // 
            // ckArchived
            // 
            this.ckArchived.AutoSize = true;
            this.ckArchived.Location = new System.Drawing.Point(662, 417);
            this.ckArchived.Name = "ckArchived";
            this.ckArchived.Size = new System.Drawing.Size(62, 17);
            this.ckArchived.TabIndex = 55;
            this.ckArchived.Text = "Archive";
            this.ckArchived.UseVisualStyleBackColor = true;
            // 
            // lblProspect
            // 
            this.lblProspect.AutoSize = true;
            this.lblProspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProspect.Location = new System.Drawing.Point(327, 9);
            this.lblProspect.Name = "lblProspect";
            this.lblProspect.Size = new System.Drawing.Size(123, 25);
            this.lblProspect.TabIndex = 66;
            this.lblProspect.Text = "*Prospect*";
            this.lblProspect.Visible = false;
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(748, 36);
            this.rtxtNotes.MaxLength = 500;
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(307, 381);
            this.rtxtNotes.TabIndex = 66;
            this.rtxtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(757, 21);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 67;
            this.lblNotes.Text = "Notes:";
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 515);
            this.Controls.Add(this.lblProspect);
            this.Controls.Add(this.panel1);
            this.Name = "DriverForm";
            this.Text = "DriverForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblNI_Num;
        private System.Windows.Forms.TextBox txtNI_Num;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.Label LblLicenseNumber;
        private System.Windows.Forms.Label lblStaffContacted;
        private System.Windows.Forms.ComboBox cmbStaffContacted;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblLastContacted;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblLicenseChecked;
        private System.Windows.Forms.Button btnContacted;
        private System.Windows.Forms.Label lblLicenseNextCheck;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.CheckBox ckOwnCar;
        private System.Windows.Forms.Label lblCPC_Expiry;
        private System.Windows.Forms.Label lblLicenseValid;
        private System.Windows.Forms.Label lblLicenseExpiry;
        private System.Windows.Forms.Label lblDigi_Expiry;
        private System.Windows.Forms.DateTimePicker dtDigi_Expiry;
        private System.Windows.Forms.DateTimePicker dtCPC_Expiry;
        private System.Windows.Forms.DateTimePicker dtLicenseExpiry;
        private System.Windows.Forms.DateTimePicker dtLicenseValid;
        private System.Windows.Forms.DateTimePicker dtLicenseNextCheck;
        private System.Windows.Forms.DateTimePicker dtLicenseChecked;
        private System.Windows.Forms.DateTimePicker dtDoB;
        private System.Windows.Forms.DateTimePicker dtLast_Contacted;
        private System.Windows.Forms.Button btnLicenseChecked;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckArchived;
        private System.Windows.Forms.CheckBox ckProspect;
        private System.Windows.Forms.CheckBox ckClass1;
        private System.Windows.Forms.CheckBox ckMorning;
        private System.Windows.Forms.CheckBox ckTramping;
        private System.Windows.Forms.CheckBox ckMultidrop;
        private System.Windows.Forms.CheckBox ckClass2;
        private System.Windows.Forms.CheckBox ckNight;
        private System.Windows.Forms.CheckBox ckNightOut;
        private System.Windows.Forms.CheckBox ckTrunking;
        private System.Windows.Forms.Label lblProspect;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
    }
}
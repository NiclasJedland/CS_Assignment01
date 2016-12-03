namespace Assignment01
{
	partial class AddContactForm
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
			if(disposing && (components != null))
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
			this.lblWarning = new System.Windows.Forms.Label();
			this.grpInformation = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblBirthday = new System.Windows.Forms.Label();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTelephoneNumber = new System.Windows.Forms.Label();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.lblCity = new System.Windows.Forms.Label();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.lblZipcode = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblLastname = new System.Windows.Forms.Label();
			this.lblFirstname = new System.Windows.Forms.Label();
			this.grpInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Location = new System.Drawing.Point(18, -4);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(0, 13);
			this.lblWarning.TabIndex = 9;
			// 
			// grpInformation
			// 
			this.grpInformation.Controls.Add(this.btnCancel);
			this.grpInformation.Controls.Add(this.txtFirstName);
			this.grpInformation.Controls.Add(this.lblBirthday);
			this.grpInformation.Controls.Add(this.dtpBirthday);
			this.grpInformation.Controls.Add(this.btnSave);
			this.grpInformation.Controls.Add(this.txtEmail);
			this.grpInformation.Controls.Add(this.lblEmail);
			this.grpInformation.Controls.Add(this.lblTelephoneNumber);
			this.grpInformation.Controls.Add(this.txtPhoneNumber);
			this.grpInformation.Controls.Add(this.txtCity);
			this.grpInformation.Controls.Add(this.lblCity);
			this.grpInformation.Controls.Add(this.txtZipCode);
			this.grpInformation.Controls.Add(this.lblZipcode);
			this.grpInformation.Controls.Add(this.txtAddress);
			this.grpInformation.Controls.Add(this.lblAddress);
			this.grpInformation.Controls.Add(this.txtLastName);
			this.grpInformation.Controls.Add(this.lblLastname);
			this.grpInformation.Controls.Add(this.lblFirstname);
			this.grpInformation.Location = new System.Drawing.Point(12, 12);
			this.grpInformation.Name = "grpInformation";
			this.grpInformation.Size = new System.Drawing.Size(328, 287);
			this.grpInformation.TabIndex = 8;
			this.grpInformation.TabStop = false;
			this.grpInformation.Text = "Information";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(110, 247);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 34);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancel_KeyDown);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(110, 19);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(211, 20);
			this.txtFirstName.TabIndex = 1;
			this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
			// 
			// lblBirthday
			// 
			this.lblBirthday.AutoSize = true;
			this.lblBirthday.Location = new System.Drawing.Point(6, 207);
			this.lblBirthday.Name = "lblBirthday";
			this.lblBirthday.Size = new System.Drawing.Size(48, 13);
			this.lblBirthday.TabIndex = 18;
			this.lblBirthday.Text = "Birthday:";
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Location = new System.Drawing.Point(110, 201);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(211, 20);
			this.dtpBirthday.TabIndex = 8;
			this.dtpBirthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpBirthday_KeyDown);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(221, 247);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 34);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(110, 175);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(211, 20);
			this.txtEmail.TabIndex = 7;
			this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(6, 178);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(35, 13);
			this.lblEmail.TabIndex = 12;
			this.lblEmail.Text = "Email:";
			// 
			// lblTelephoneNumber
			// 
			this.lblTelephoneNumber.AutoSize = true;
			this.lblTelephoneNumber.Location = new System.Drawing.Point(6, 152);
			this.lblTelephoneNumber.Name = "lblTelephoneNumber";
			this.lblTelephoneNumber.Size = new System.Drawing.Size(101, 13);
			this.lblTelephoneNumber.TabIndex = 11;
			this.lblTelephoneNumber.Text = "Telephone Number:";
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(110, 149);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(211, 20);
			this.txtPhoneNumber.TabIndex = 6;
			this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyDown);
			this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(110, 123);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(211, 20);
			this.txtCity.TabIndex = 5;
			this.txtCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCity_KeyDown);
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(6, 126);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(27, 13);
			this.lblCity.TabIndex = 8;
			this.lblCity.Text = "City:";
			// 
			// txtZipCode
			// 
			this.txtZipCode.Location = new System.Drawing.Point(110, 97);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.Size = new System.Drawing.Size(211, 20);
			this.txtZipCode.TabIndex = 4;
			this.txtZipCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZipCode_KeyDown);
			this.txtZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipCode_KeyPress);
			// 
			// lblZipcode
			// 
			this.lblZipcode.AutoSize = true;
			this.lblZipcode.Location = new System.Drawing.Point(6, 100);
			this.lblZipcode.Name = "lblZipcode";
			this.lblZipcode.Size = new System.Drawing.Size(52, 13);
			this.lblZipcode.TabIndex = 6;
			this.lblZipcode.Text = "Zip code:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(110, 71);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(211, 20);
			this.txtAddress.TabIndex = 3;
			this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(6, 74);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(48, 13);
			this.lblAddress.TabIndex = 4;
			this.lblAddress.Text = "Address:";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(110, 45);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(211, 20);
			this.txtLastName.TabIndex = 2;
			this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastName_KeyDown);
			// 
			// lblLastname
			// 
			this.lblLastname.AutoSize = true;
			this.lblLastname.Location = new System.Drawing.Point(6, 48);
			this.lblLastname.Name = "lblLastname";
			this.lblLastname.Size = new System.Drawing.Size(56, 13);
			this.lblLastname.TabIndex = 2;
			this.lblLastname.Text = "Lastname:";
			// 
			// lblFirstname
			// 
			this.lblFirstname.AutoSize = true;
			this.lblFirstname.Location = new System.Drawing.Point(6, 22);
			this.lblFirstname.Name = "lblFirstname";
			this.lblFirstname.Size = new System.Drawing.Size(55, 13);
			this.lblFirstname.TabIndex = 0;
			this.lblFirstname.Text = "Firstname:";
			// 
			// AddContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 313);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.grpInformation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AddContactForm";
			this.Text = "Add New Contact";
			this.grpInformation.ResumeLayout(false);
			this.grpInformation.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblWarning;
		private System.Windows.Forms.GroupBox grpInformation;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblBirthday;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblTelephoneNumber;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.Label lblZipcode;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblLastname;
		private System.Windows.Forms.Label lblFirstname;
	}
}
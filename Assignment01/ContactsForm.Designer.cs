namespace Assignment01
{
	partial class contactsForm
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
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.grpInformation = new System.Windows.Forms.GroupBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblBirthday = new System.Windows.Forms.Label();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAddContact = new System.Windows.Forms.Button();
			this.btnSaveChanges = new System.Windows.Forms.Button();
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
			this.grpPeople = new System.Windows.Forms.GroupBox();
			this.lstPeople = new System.Windows.Forms.ListBox();
			this.lblWarning = new System.Windows.Forms.Label();
			this.gbSearch = new System.Windows.Forms.GroupBox();
			this.grpInformation.SuspendLayout();
			this.grpPeople.SuspendLayout();
			this.gbSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(7, 26);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(249, 22);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// grpInformation
			// 
			this.grpInformation.Controls.Add(this.txtFirstName);
			this.grpInformation.Controls.Add(this.lblBirthday);
			this.grpInformation.Controls.Add(this.dtpBirthday);
			this.grpInformation.Controls.Add(this.btnRemove);
			this.grpInformation.Controls.Add(this.btnAddContact);
			this.grpInformation.Controls.Add(this.btnSaveChanges);
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
			this.grpInformation.Location = new System.Drawing.Point(291, 26);
			this.grpInformation.Margin = new System.Windows.Forms.Padding(4);
			this.grpInformation.Name = "grpInformation";
			this.grpInformation.Padding = new System.Windows.Forms.Padding(4);
			this.grpInformation.Size = new System.Drawing.Size(437, 353);
			this.grpInformation.TabIndex = 5;
			this.grpInformation.TabStop = false;
			this.grpInformation.Text = "Information";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(147, 23);
			this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(280, 22);
			this.txtFirstName.TabIndex = 2;
			// 
			// lblBirthday
			// 
			this.lblBirthday.AutoSize = true;
			this.lblBirthday.Location = new System.Drawing.Point(8, 255);
			this.lblBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBirthday.Name = "lblBirthday";
			this.lblBirthday.Size = new System.Drawing.Size(64, 17);
			this.lblBirthday.TabIndex = 18;
			this.lblBirthday.Text = "Birthday:";
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Location = new System.Drawing.Point(147, 247);
			this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(280, 22);
			this.dtpBirthday.TabIndex = 9;
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(8, 304);
			this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(133, 42);
			this.btnRemove.TabIndex = 12;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAddContact
			// 
			this.btnAddContact.Location = new System.Drawing.Point(153, 304);
			this.btnAddContact.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddContact.Name = "btnAddContact";
			this.btnAddContact.Size = new System.Drawing.Size(133, 42);
			this.btnAddContact.TabIndex = 11;
			this.btnAddContact.Text = "Add A New Contact";
			this.btnAddContact.UseVisualStyleBackColor = true;
			this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.Location = new System.Drawing.Point(296, 304);
			this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(133, 42);
			this.btnSaveChanges.TabIndex = 10;
			this.btnSaveChanges.Text = "Save Changes";
			this.btnSaveChanges.UseVisualStyleBackColor = true;
			this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(147, 215);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(280, 22);
			this.txtEmail.TabIndex = 8;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(8, 219);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(46, 17);
			this.lblEmail.TabIndex = 12;
			this.lblEmail.Text = "Email:";
			// 
			// lblTelephoneNumber
			// 
			this.lblTelephoneNumber.AutoSize = true;
			this.lblTelephoneNumber.Location = new System.Drawing.Point(8, 187);
			this.lblTelephoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTelephoneNumber.Name = "lblTelephoneNumber";
			this.lblTelephoneNumber.Size = new System.Drawing.Size(134, 17);
			this.lblTelephoneNumber.TabIndex = 11;
			this.lblTelephoneNumber.Text = "Telephone Number:";
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(147, 183);
			this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(280, 22);
			this.txtPhoneNumber.TabIndex = 7;
			this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephoneNumber_KeyPress);
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(147, 151);
			this.txtCity.Margin = new System.Windows.Forms.Padding(4);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(280, 22);
			this.txtCity.TabIndex = 6;
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(8, 155);
			this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(35, 17);
			this.lblCity.TabIndex = 8;
			this.lblCity.Text = "City:";
			// 
			// txtZipCode
			// 
			this.txtZipCode.Location = new System.Drawing.Point(147, 119);
			this.txtZipCode.Margin = new System.Windows.Forms.Padding(4);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.Size = new System.Drawing.Size(280, 22);
			this.txtZipCode.TabIndex = 5;
			this.txtZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipCode_KeyPress);
			// 
			// lblZipcode
			// 
			this.lblZipcode.AutoSize = true;
			this.lblZipcode.Location = new System.Drawing.Point(8, 123);
			this.lblZipcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblZipcode.Name = "lblZipcode";
			this.lblZipcode.Size = new System.Drawing.Size(67, 17);
			this.lblZipcode.TabIndex = 6;
			this.lblZipcode.Text = "Zip code:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(147, 87);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(280, 22);
			this.txtAddress.TabIndex = 4;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(8, 91);
			this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(64, 17);
			this.lblAddress.TabIndex = 4;
			this.lblAddress.Text = "Address:";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(147, 55);
			this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(280, 22);
			this.txtLastName.TabIndex = 3;
			// 
			// lblLastname
			// 
			this.lblLastname.AutoSize = true;
			this.lblLastname.Location = new System.Drawing.Point(8, 59);
			this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLastname.Name = "lblLastname";
			this.lblLastname.Size = new System.Drawing.Size(74, 17);
			this.lblLastname.TabIndex = 2;
			this.lblLastname.Text = "Lastname:";
			// 
			// lblFirstname
			// 
			this.lblFirstname.AutoSize = true;
			this.lblFirstname.Location = new System.Drawing.Point(8, 27);
			this.lblFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFirstname.Name = "lblFirstname";
			this.lblFirstname.Size = new System.Drawing.Size(74, 17);
			this.lblFirstname.TabIndex = 0;
			this.lblFirstname.Text = "Firstname:";
			// 
			// grpPeople
			// 
			this.grpPeople.Controls.Add(this.lstPeople);
			this.grpPeople.Location = new System.Drawing.Point(11, 14);
			this.grpPeople.Margin = new System.Windows.Forms.Padding(4);
			this.grpPeople.Name = "grpPeople";
			this.grpPeople.Padding = new System.Windows.Forms.Padding(4);
			this.grpPeople.Size = new System.Drawing.Size(267, 295);
			this.grpPeople.TabIndex = 4;
			this.grpPeople.TabStop = false;
			this.grpPeople.Text = "People";
			// 
			// lstPeople
			// 
			this.lstPeople.FormattingEnabled = true;
			this.lstPeople.ItemHeight = 16;
			this.lstPeople.Location = new System.Drawing.Point(8, 23);
			this.lstPeople.Margin = new System.Windows.Forms.Padding(4);
			this.lstPeople.Name = "lstPeople";
			this.lstPeople.Size = new System.Drawing.Size(249, 260);
			this.lstPeople.TabIndex = 0;
			this.lstPeople.SelectedIndexChanged += new System.EventHandler(this.lstPeople_SelectedIndexChanged);
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Location = new System.Drawing.Point(433, 6);
			this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(0, 17);
			this.lblWarning.TabIndex = 22;
			// 
			// gbSearch
			// 
			this.gbSearch.Controls.Add(this.txtSearch);
			this.gbSearch.Location = new System.Drawing.Point(12, 304);
			this.gbSearch.Name = "gbSearch";
			this.gbSearch.Size = new System.Drawing.Size(266, 68);
			this.gbSearch.TabIndex = 23;
			this.gbSearch.TabStop = false;
			this.gbSearch.Text = "Search";
			// 
			// contactsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 389);
			this.Controls.Add(this.gbSearch);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.grpInformation);
			this.Controls.Add(this.grpPeople);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "contactsForm";
			this.Text = "Contacts";
			this.Load += new System.EventHandler(this.contactsForm_Load);
			this.grpInformation.ResumeLayout(false);
			this.grpInformation.PerformLayout();
			this.grpPeople.ResumeLayout(false);
			this.gbSearch.ResumeLayout(false);
			this.gbSearch.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.GroupBox grpInformation;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblBirthday;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAddContact;
		private System.Windows.Forms.Button btnSaveChanges;
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
		private System.Windows.Forms.GroupBox grpPeople;
		private System.Windows.Forms.ListBox lstPeople;
		private System.Windows.Forms.Label lblWarning;
		private System.Windows.Forms.GroupBox gbSearch;
	}
}


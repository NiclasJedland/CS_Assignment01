using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
	public partial class AddContactForm : Form
	{
		//Custom Events
		public event EventHandler<EventArgs> SavedDatabase;
		protected virtual void OnSavedDatabase()
		{
			if(SavedDatabase != null)
				SavedDatabase(this, EventArgs.Empty);
		}
		//-------------------
		public AddContactForm()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveAndClose();
		}

		private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		#region OnKeyDown
		void CheckKeyPress(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
				SaveAndClose();
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}

		private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtLastName_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtAddress_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtZipCode_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtCity_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtEmail_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void dtpBirthday_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void btnSave_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void btnCancel_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion
		private void SaveAndClose()
		{
			var DBC = new DBConnection();
			DBC.SaveToDatabase(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtZipCode.Text, txtCity.Text, txtPhoneNumber.Text, txtEmail.Text, dtpBirthday.Value);
			OnSavedDatabase();
			this.Close();
		}
	}
}

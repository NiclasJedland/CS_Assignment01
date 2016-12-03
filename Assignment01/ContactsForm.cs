using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Assignment01
{
	public partial class contactsForm : Form
	{
		DBConnection DBC = new DBConnection();
		//Custom Events
		public void OnSavedDatabase(object source, EventArgs e)
		{
			UpdateList(true);
		}
		private void FadeWarningText(object sender, EventArgs e)
		{
			lblWarning.Text = "";
		}
		//---------------------

		public contactsForm()
		{
			InitializeComponent();
		}

		private void contactsForm_Load(object sender, EventArgs e)
		{
			UpdateList(true);
		}

		#region TextBox
		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(txtSearch.Text))
			{
				Person person = new Person();
				person.Search(txtSearch.Text);
				UpdateList(false);
			}
			else
				UpdateList(true);
		}

		private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private void txtTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		#endregion

		#region Buttons

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				if(MessageBox.Show("Remove " + lstPeople.SelectedItem + "?", "Remove Selected", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Timer timer = new Timer();
					timer.Interval = 3000;
					timer.Enabled = true;
					timer.Tick += new EventHandler(FadeWarningText);
					
					var removed = Person.people[lstPeople.SelectedIndex];
					DBC.DeletePersonFromDatabase(Person.people[lstPeople.SelectedIndex].Id);

					lblWarning.ForeColor = Color.Red;
					lblWarning.Text = removed.FirstName + " " + removed.LastName + " Removed!";

					UpdateList(true);
				}
			}
		}

		private void btnAddContact_Click(object sender, EventArgs e)
		{
			this.Hide();
			var newWindow = new AddContactForm();
			newWindow.Closed += (s, args) => this.Show(); //this.Show() will instead reopen parent
			newWindow.SavedDatabase += OnSavedDatabase;
			newWindow.Show();
		}

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				if(MessageBox.Show("Save changes?", "Update Selected", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Timer timer = new Timer();
					timer.Interval = 3000;
					timer.Enabled = true;
					timer.Tick += new EventHandler(FadeWarningText);

					DBC.RenamePersonInDatabase(Person.people[lstPeople.SelectedIndex].Id, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtZipCode.Text, txtCity.Text, txtPhoneNumber.Text, txtEmail.Text, dtpBirthday.Value);

					lblWarning.ForeColor = Color.Green;
					lblWarning.Text = txtFirstName.Text + " " + txtLastName.Text + " Removed!";

					UpdateList(true);
				}
			}
		}

		#endregion

		private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				txtFirstName.Text = Person.people[lstPeople.SelectedIndex].FirstName;
				txtLastName.Text = Person.people[lstPeople.SelectedIndex].LastName;
				txtAddress.Text = Person.people[lstPeople.SelectedIndex].Address;
				txtZipCode.Text = Person.people[lstPeople.SelectedIndex].ZipCode;
				txtCity.Text = Person.people[lstPeople.SelectedIndex].City;
				txtPhoneNumber.Text = Person.people[lstPeople.SelectedIndex].PhoneNumber;
				txtEmail.Text = Person.people[lstPeople.SelectedIndex].Email;
				dtpBirthday.Value = Person.people[lstPeople.SelectedIndex].Birthday;
			}
		}

		void UpdateList(bool loadDatabase)
		{
			lstPeople.Items.Clear();

			txtFirstName.Text = "";
			txtLastName.Text = "";
			txtAddress.Text = "";
			txtZipCode.Text = "";
			txtCity.Text = "";
			txtPhoneNumber.Text = "";
			txtEmail.Text = "";
			dtpBirthday.Value = DateTime.Today;

			if(loadDatabase)
				DBC.LoadFromDatabase();

			Person.people = Person.people.OrderBy(x => x.FirstName).ToList();

			foreach(var person in Person.people)
			{
				lstPeople.Items.Add(person.FirstName + " " + person.LastName);
			}
		}


		
	}
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Assignment01
{
	public class DBConnection
	{
		string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

		public void LoadFromDatabase()
		{
			Person.people.Clear();
			using(var connection = new SqlConnection(conString))
			{
				try
				{
					connection.Open();
					using(var command = new SqlCommand("SELECT * FROM Person", connection))
					{
						var reader = command.ExecuteReader();
						while(reader.Read())
						{
							var id = reader.GetInt32(0);
							var firstName = reader.GetString(1);
							var lastName = reader.GetString(2);
							var address = reader.GetString(3);
							var zipcode = reader.GetString(4);
							var city = reader.GetString(5);
							var phoneNumber = reader.GetString(6);
							var email = reader.GetString(7);
							var birthday = reader.GetDateTime(8);

							Person.people.Add(new Person()
							{
								Id = id,
								FirstName = firstName,
								LastName = lastName,
								Address = address,
								ZipCode = zipcode,
								City = city,
								PhoneNumber = phoneNumber,
								Email = email,
								Birthday = birthday
							});
						}
					}
				}
				catch(Exception e)
				{
					MessageBox.Show("Error: " + e);
				}

			}
		}

		public void SaveToDatabase(string firstName, string lastName, string address, string zipCode, string city, string phoneNumber, string email, DateTime birthDay)
		{
			using(var connection = new SqlConnection(conString))
			{
				connection.Open();
				try
				{
					using(var command = new SqlCommand("INSERT INTO Person VALUES(@FirstName, @LastName, @Address, @ZipCode, @City, @PhoneNumber, @Email, @Birthday)", connection))
					{
						command.Parameters.Add(new SqlParameter("@FirstName", firstName.Trim()));
						command.Parameters.Add(new SqlParameter("@LastName", lastName.Trim()));
						command.Parameters.Add(new SqlParameter("@Address", address.Trim()));
						command.Parameters.Add(new SqlParameter("@ZipCode", zipCode.Trim()));
						command.Parameters.Add(new SqlParameter("@City", city.Trim()));
						command.Parameters.Add(new SqlParameter("@PhoneNumber", phoneNumber.Trim()));
						command.Parameters.Add(new SqlParameter("@Email", email.Trim()));
						command.Parameters.Add(new SqlParameter("@Birthday", birthDay));
						command.ExecuteNonQuery();
					}
				}
				catch(Exception e)
				{
					MessageBox.Show("Could not insert. Error: " + e);
				}
			}
		}

		public void DeletePersonFromDatabase(int Id)
		{
			try
			{
				using(var connection = new SqlConnection(conString))
				{
					connection.Open();
					using(var command = new SqlCommand("DELETE FROM Person WHERE Id = @Id", connection))
					{
						command.Parameters.Add(new SqlParameter("@Id", Id));
						command.ExecuteNonQuery();
					}
				}
			}
			catch(SystemException ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}

		public void RenamePersonInDatabase(int Id, string firstName, string lastName, string address, string zipCode, string city, string phoneNumber, string email, DateTime birthDay)
		{
			using(var connection = new SqlConnection(conString))
			{
				try
				{
					connection.Open();
					using(var command = new SqlCommand("UPDATE Person SET FirstName=@FirstName, LastName=@LastName, Address=@Address, ZipCode=@ZipCode, City=@City, PhoneNumber=@PhoneNumber, Email=@Email, Birthday=@Birthday WHERE Id = @Id", connection))
					{
						command.Parameters.Add(new SqlParameter("@Id", Id));
						command.Parameters.Add(new SqlParameter("@FirstName", firstName));
						command.Parameters.Add(new SqlParameter("@LastName", lastName));
						command.Parameters.Add(new SqlParameter("@Address", address));
						command.Parameters.Add(new SqlParameter("@ZipCode", zipCode));
						command.Parameters.Add(new SqlParameter("@City", city));
						command.Parameters.Add(new SqlParameter("@PhoneNumber", phoneNumber));
						command.Parameters.Add(new SqlParameter("@Email", email));
						command.Parameters.Add(new SqlParameter("@Birthday", birthDay));
						command.ExecuteNonQuery();
					}
				}
				catch(SystemException ex)
				{
					MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
				}
			}

		}
	}
}


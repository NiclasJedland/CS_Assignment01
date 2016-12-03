using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
	public class Person
	{
		public static List<Person> people = new List<Person>();
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string ZipCode { get; set; }
		public string City { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public DateTime Birthday { get; set; }
		public void Search(string searchString)
		{
			people = people.Where(p =>
				p.FirstName.ToLower().Contains(searchString.ToLower()) ||
				p.LastName.ToLower().Contains(searchString.ToLower()) ||
				p.Address.ToLower().Contains(searchString.ToLower()) ||
				p.City.ToLower().Contains(searchString.ToLower()) ||
				p.Email.ToLower().Contains(searchString.ToLower())
				).ToList();
		}
	}
}

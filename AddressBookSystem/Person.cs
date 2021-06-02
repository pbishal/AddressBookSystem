using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Person
    {
		public string firstName;
		public string lastName;
		public string city;
		public string state;
		public string email;
		public long phoneNumber;
		public int zip;
		public Person(string firstName, string lastName, string city, string state, string email, long phoneNumber, int zip)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.city = city;
			this.state = state;
			this.email = email;
			this.phoneNumber = phoneNumber;
			this.zip = zip;
		}
		public String getFirstName()
		{
			return firstName;
		}

		public void setFirstName(String firstName)
		{
			this.firstName = firstName;
		}

		public String getLastName()
		{
			return lastName;
		}

		public void setLastName(String lastName)
		{
			this.lastName = lastName;
		}

		public String getCity()
		{
			return city;
		}

		public void setCity(String city)
		{
			this.city = city;
		}

		public String getState()
		{
			return state;
		}

		public void setState(String state)
		{
			this.state = state;
		}
		public long getPhoneNumber()
		{
			return phoneNumber;
		}

		public void setPhoneNumber(long phoneNumber)
		{
			this.phoneNumber = phoneNumber;
		}

		public String getEmail()
		{
			return email;
		}

		public void setEmail(String email)
		{
			this.email = email;
		}

		public int getZip()
		{
			return zip;
		}

		public void setZip(int zip)
		{
			this.zip = zip;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public Address Address { get; set; }
        public string Password { get; set; }

        public User(string idNumber, string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password)
        {
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            MailAddress = mailAddress;
            Address = address;
            Password = password;
        }

        public Address GetAddress()
        {
            return Address;
        }

        public void SetAddress(Address address)
        {
            if (address != null)
                Address = address;
        }

        public string GetMailAddress()
        {
            return MailAddress;
        }

        public void SetMailAddress(string mailAddress)
        {
            if (isMailAdress(mailAddress))
                MailAddress = mailAddress;
        }

        private static bool isMailAdress(string mailAddress)
        {
            //To Do 
            return true;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }

        public string GetPassword()
        {
            return Password;
        }

        public bool SetPassword(string password)
        {
            if (validPassword(password))
            {
                Password = password;
                return true;
            }
            return false;     
        }

        private static bool validPassword(string password)
        {
            //To Do
            return true;
        }
    }
}

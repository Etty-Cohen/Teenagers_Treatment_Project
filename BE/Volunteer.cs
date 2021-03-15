using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    public class Volunteer : User
    {
        public int VolunteerId { get; set; }

        public Volunteer(string idNumber, string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password) :
            base(idNumber, firstName, lastName, phoneNumber, mailAddress, address, password)
        {
            //To Do - מאיפה המספר סידורי? מוגרל רנדומלית?

        }



    }
}

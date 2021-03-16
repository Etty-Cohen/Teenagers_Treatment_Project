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

        public virtual ICollection<Teenager> Teenagers { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; }

        public Volunteer(string idNumber, string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password) :
            base(idNumber, firstName, lastName, phoneNumber, mailAddress, address, password)
        {
            Teenagers = new HashSet<Teenager>();
            Treatments = new HashSet<Treatment>();
            //To Do - מאיפה המספר סידורי? מוגרל רנדומלית?

        }



    }
}

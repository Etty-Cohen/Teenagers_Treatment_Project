using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    public class Teenager : User
    {
        public int TeenagerId { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<Volunteer> Volunteers { get; set; }

        public virtual ICollection<Mentor> Mentors { get; set; }



        public Teenager(string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password) :
            base(firstName, lastName, phoneNumber, mailAddress, address, password)
        {

            Volunteers = new HashSet<Volunteer>();
            Mentors = new HashSet<Mentor>();
            Treatments = new HashSet<Treatment>();
            Appointments = new HashSet<Appointment>();
        }

        public Teenager() { }



    }
}

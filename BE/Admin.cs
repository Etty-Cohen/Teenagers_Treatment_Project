using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Admin : User
    {
        public int AdminId { get; set; }

        public Areas Area { get; set; }

        public bool IsMainAdmin { get; set; }

        public virtual ICollection<Mentor> Mentors { get; set; }

        public virtual ICollection<Volunteer> Volunteers { get; set; }

        public virtual ICollection<VolunteerRequest> VolunteerRequests { get; set; }

        public Admin(string idNumber, string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password, bool isMainAdmin) :
            base(idNumber, firstName, lastName, phoneNumber, mailAddress, address, password)
        {
            IsMainAdmin = isMainAdmin;
            Volunteers = new HashSet<Volunteer>();
            Mentors = new HashSet<Mentor>();
            VolunteerRequests = new HashSet<VolunteerRequest>();
        }

    }
}


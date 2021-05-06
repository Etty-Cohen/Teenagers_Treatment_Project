using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class VolunteerRequest

    {
        public int VolunteerRequestId { get; set; }
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public Address Address { get; set; }
        public bool IsConfirmed { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Recommender> Recommenders { get; set; }
        public virtual Admin Admin { get; set; }
        public int AdminId { get; set; }

        public VolunteerRequest(string idNumber, string firstName, string lastName, string phoneNumber, 
            string mailAddress, Address address, string description,  int adminId)
        {
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            MailAddress = mailAddress;
            Description = description;
            Address = address;
            IsConfirmed = false;
            AdminId = adminId;
            Recommenders = new HashSet<Recommender>();
        }

    }
}

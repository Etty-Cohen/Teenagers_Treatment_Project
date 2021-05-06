using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Recommender
    {
        public int RecommenderId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string MailAddress { get; set; }

        public string Relationship { get; set; }

        public virtual VolunteerRequest VolunteerRequest { get; set; }

        public int VolunteerRequestId { get; set; }





    public Recommender(int volunteerRequestId, string firstName, string lastName, string phoneNumber, string mailAddress = "", string relationship = "")
        {
            VolunteerRequestId = volunteerRequestId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            MailAddress = mailAddress;
            Relationship = relationship;    
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    public class Volunteer : Helper
    {
        public int VolunteerId { get; set; }


        public virtual ICollection<Treatment> Treatments { get; set; }

        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }

        public Volunteer(string idNumber, string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password, int adminId) :
            base(idNumber, firstName, lastName, phoneNumber, mailAddress, address, password, adminId)
        {
            Treatments = new HashSet<Treatment>();
            AdminId = adminId;
        }



    }
}

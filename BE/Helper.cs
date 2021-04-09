using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Helper : User
    {
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }

        public Areas Area { get; set; }

        public virtual ICollection<Teenager> Teenagers { get; set; }

        public Helper(string idNumber, string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password, int adminId) :
            base(idNumber, firstName, lastName, phoneNumber, mailAddress, address, password)
        {
            Teenagers = new HashSet<Teenager>();
            AdminId = adminId;
        }

    }
}

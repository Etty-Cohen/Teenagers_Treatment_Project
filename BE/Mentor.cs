using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    public class Mentor : User
    {
        public int MentorId { get; set; }

        public int AdminId { get; set; }

        public Mentor(string idNumber, string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password, int adminId) :
            base(idNumber, firstName, lastName, phoneNumber, mailAddress, address, password)
        {
            AdminId = AdminId;
        }


        public Mentor(string idNumber, string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password) :
            base(idNumber, firstName, lastName, phoneNumber, mailAddress, address, password)
        {
            AdminId = this.findAdmin();
        }

         public int findAdmin()
        {
            int adminId = 0; // To Do
            return adminId;
        }


    }
}

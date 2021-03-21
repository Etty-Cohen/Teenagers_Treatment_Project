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

        public int Area { get; set; } // To Do להוסיף ENUM של כל האזורים, ואז במקום אינטגר שיהיה מסוג האינם. וכן להוסיף לבנאי ופונק' התאמת איזור.

        public Admin(string idNumber, string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password):
            base(idNumber, firstName, lastName, phoneNumber, mailAddress, address, password)
        {}
        
    }
}


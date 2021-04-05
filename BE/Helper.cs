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

        public Helper(string idNumber, string firstName, string lastName, string phoneNumber, string mailAddress, Address address, string password) :
            base(idNumber, firstName, lastName, phoneNumber, mailAddress, address, password)
        {
            Teenagers = new HashSet<Teenager>();
            AdminId = this.findAdmin();
        }

        public int findAdmin()
        {
            int adminId = 0; // To Do אולי לפי מיקום
            // להתחבר לנתונים להוציא עם הפונקציה של קבלת אדמין את כל האדמינים באזור של המנטור ואז מתוכם לבחור את באדמין עם הכי פחות מנטורים ומתנדבים
            return adminId;
        }
    }
}

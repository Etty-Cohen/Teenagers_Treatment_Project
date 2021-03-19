using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Appointment
    {
        public int AppointmentId { get; set; }

        public int AdminId { get; set; }

        public int MentorId { get; set; }

        public int TeenagerId { get; set; }

        string Conclusion { get; set; }

        public DateTime AppointmentDate { get; set; }


        public Appointment()
        {
            // To Do
        }
    }
}

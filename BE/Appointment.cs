using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public int AdminId { get; set; }

        public int MentorId { get; set; }

        public int TeenagerId { get; set; }

        public string Conclusion { get; set; }

        public DateTime AppointmentDate { get; set; }

        public virtual Mentor Mentor { get; set; }



        public Appointment(int teenagerId, int mentorId, DateTime appointmentDate)
        {
            TeenagerId = teenagerId;
            MentorId = mentorId;
            AppointmentDate = appointmentDate;
        }

        public bool AddConclusion(string conclusion)
        {
            if (Conclusion == null)
            {
                Conclusion = conclusion;
                return true;
            }
            return false;
        }
    }
}
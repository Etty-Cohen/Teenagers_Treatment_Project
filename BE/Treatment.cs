using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Treatment
    {
        public int TreatmentId { get; set; }

        public virtual Volunteer Volunteer { get; set; }

        public int VolunteerId { get; set; }

        public int MentorId { get; set; }

        public virtual Teenager Teenager { get; set; }

        public int TeenagerId { get; set; }

        public int TreatmentMethod { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime TreatDurMin { get; set; }
        public int Status { get; set; }


        public Treatment(int treatmentMethod, Teenager teenager)
        {
            TreatmentMethod = treatmentMethod;
            //StartTime = לקחת זמן של עכשיו
            //Status = OPENED; // להוסיף ENUM
            // מתי מחפשים מתנדב? ישר שנפתחת פניה?
            Treatments = new HashSet<Treatment>();
        }

        public Treatment() { }
}
}

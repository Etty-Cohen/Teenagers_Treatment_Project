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

        public virtual Teenager Teenager { get; set; }

        public int TeenagerId { get; set; }

        public TreatmentTypes TreatmentMethod { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime TreatDurMin { get; set; }

        public string Conclusion { get; set; }

        public StatusTypes Status { get; set; }


        public Treatment(TreatmentTypes treatmentMethod, Teenager teenager)
        {
            TreatmentMethod = treatmentMethod;
            Teenager = teenager;
            TeenagerId = teenager.TeenagerId;
            StartTime = DateTime.Now;
            Status = StatusTypes.OPENED;
        }

    }
}

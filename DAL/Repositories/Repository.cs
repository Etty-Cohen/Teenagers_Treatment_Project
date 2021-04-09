using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using BE;
namespace DAL.Repositories
{
    public class Repository : IRepository
    {

        #region update db
        public void AddVolunteer(Volunteer volunteer)
        {
            using (var ctx = new TreatmentContext())
            {
                ctx.Volunteers.Add(volunteer);
                ctx.SaveChanges();
            }
        }

        public void RemoveVolunteer(Volunteer volunteer)
        {
            using (var ctx = new TreatmentContext())
            {
                var old = ctx.Volunteers.Find(volunteer.VolunteerId);
                old.IsActive = false;
                ctx.SaveChanges();
            }
        }

        public void AddAdmin(Admin admin)
        {
            using (var ctx = new TreatmentContext())
            {
                ctx.Admins.Add(admin);
                ctx.SaveChanges();
            }
        }

        public void RemoveAdmin(Admin admin)
        {
            using (var ctx = new TreatmentContext())
            {
                var old = ctx.Admins.Find(admin.AdminId);
                old.IsActive = false;
                ctx.SaveChanges();
            }
        }

        public void AddMentor(Mentor mentor)
        {
            using (var ctx = new TreatmentContext())
            {
                ctx.Mentors.Add(mentor);
                ctx.SaveChanges();
            }
        }

        public void RemoveMentor(Mentor mentor)
        {
            using (var ctx = new TreatmentContext())
            {
                var old = ctx.Mentors.Find(mentor.MentorId);
                old.IsActive = false;
                ctx.SaveChanges();
            }
        }

        public void AddTeenager(Teenager teenager)
        {
            using (var ctx = new TreatmentContext())
            {
                ctx.Teenagers.Add(teenager);
                ctx.SaveChanges();
            }
        }

        public void RemoveTeenager(Teenager teenager)
        {
            using (var ctx = new TreatmentContext())
            {
                var old = ctx.Teenagers.Find(teenager.TeenagerId);
                old.IsActive = false;
                ctx.SaveChanges();
            }
        }

        public void AddTreatment(Treatment treatment)
        {
            using (var ctx = new TreatmentContext())
            {
                ctx.Treatments.Add(treatment);
                ctx.SaveChanges();
            }
        }


        public void UpdateTreatment(Treatment treatment)
        {
            using (var context = new TreatmentContext())
            {
                var old = context.Treatments.Find(treatment.TreatmentId);
                old.VolunteerId = treatment.VolunteerId;
                old.TreatmentId = treatment.TreatmentId;
                old.TreatmentMethod = treatment.TreatmentMethod;
                old.StartTime = treatment.StartTime;
                old.TreatDurMin = treatment.TreatDurMin;
                old.Conclusion = treatment.Conclusion;
                old.Status = treatment.Status;
                context.SaveChanges();
            }
        }

        public void AddAppointment(Appointment appointment)
        {
            using (var ctx = new TreatmentContext())
            {
                ctx.Appointments.Add(appointment);
                ctx.SaveChanges();
            }
        }


        public void UpdateAppointment(Appointment appointment)
        {
            using (var context = new TreatmentContext())
            {
                var old = context.Appointments.Find(appointment.AppointmentId);
                old.AppointmentId = appointment.AppointmentId;
                old.AdminId = appointment.AdminId;
                old.MentorId = appointment.MentorId;
                old.TeenagerId = appointment.TeenagerId;
                old.Conclusion = appointment.Conclusion;
                old.AppointmentDate = appointment.AppointmentDate;
                context.SaveChanges();
            }
        }
        #endregion


        #region fetch from db
        public List<Volunteer> GetAllVolunteers(Func<Volunteer, bool> predicate = null)
        {
            List<Volunteer> result = new List<Volunteer>();
            using (var context = new TreatmentContext())
            {
                if (predicate == null)
                    result = context.Volunteers.ToList();
                else
                {
                    result = context.Volunteers.Where(predicate).ToList();
                }
            }
            return result;
        }

        public List<Volunteer> GetAllVolunteersWithSelect(Func<Volunteer, bool> predicate = null)
        {
            List<Volunteer> result = new List<Volunteer>();
            using (var context = new TreatmentContext())
            {
                if (predicate == null)
                    result = context.Volunteers
                        .Select(v =>  v.FirstName)
                        .ToList();
                else
                {
                    result = context.Volunteers.Include(v => v.FirstName).Include(Address).Include().Where(predicate).ToList();
                }
            }
            return result;
        }

        public List<Admin> GetAllAdmins(Func<Admin, bool> predicate = null)
        {
            List<Admin> result = new List<Admin>();
            using (var context = new TreatmentContext())
            {
                if (predicate == null)
                    result = context.Admins.ToList();
                else
                {
                    result = context.Admins.Where(predicate).ToList();
                }
            }
            return result;
        }

        public List<Mentor> GetAllMentors(Func<Mentor, bool> predicate = null)
        {
            List<Mentor> result = new List<Mentor>();
            using (var context = new TreatmentContext())
            {
                if (predicate == null)
                    result = context.Mentors.ToList();
                else
                {
                    result = context.Mentors.Where(predicate).ToList();
                }
            }
            return result;
        }


        public List<Teenager> GetAllTeenagers(Func<Teenager, bool> predicate = null)
        {
            List<Teenager> result = new List<Teenager>();
            using (var context = new TreatmentContext())
            {
                if (predicate == null)
                    result = context.Teenagers.ToList();
                else
                {
                    result = context.Teenagers.Where(predicate).ToList();
                }
            }
            return result;
        }

        public List<Treatment> GetAllTreatments(Func<Treatment, bool> predicate = null)
        {
            List<Treatment> result = new List<Treatment>();
            using (var context = new TreatmentContext())
            {
                if (predicate == null)
                    result = context.Treatments.ToList();
                else
                {
                    result = context.Treatments.Where(predicate).ToList();
                }
            }
            return result;
        }


        public List<Appointment> GetAllAppointments(Func<Appointment, bool> predicate = null)
        {
            List<Appointment> result = new List<Appointment>();
            using (var context = new TreatmentContext())
            {
                if (predicate == null)
                    result = context.Appointments.ToList();
                else
                {
                    result = context.Appointments.Where(predicate).ToList();
                }
            }
            return result;
        }

        #endregion

    }
}

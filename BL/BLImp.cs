using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL.Interfaces;
using DAL.Interfaces;
using DAL.Repositories;
namespace BL
{
    class BLImp : IBL
    {
        public IRepository IRepository { get; set; }

        public BLImp()
        {
            IRepository = new Repository();
        }


        #region update db
        void AddVolunteer(Volunteer volunteer)
        {
            IRepository.AddVolunteer(volunteer);
        }
        void RemoveVolunteer(Volunteer volunteer)
        {
            IRepository.RemoveVolunteer(volunteer);
        }

        void AddAdmin(Admin admin)
        {
            IRepository.AddAdmin(admin);
        }
        void RemoveAdmin(Admin admin)
        {
            IRepository.RemoveAdmin(admin);
        }

        void AddMentor(Mentor mentor)
        {
            IRepository.AddMentor(mentor);
        }

        void RemoveMentor(Mentor mentor)
        {
            IRepository.RemoveMentor(mentor);
        }

        void AddTeenager(Teenager teenager)
        {
            IRepository.AddTeenager(teenager);
        }

        void RemoveTeenager(Teenager teenager)
        {
            IRepository.RemoveTeenager(teenager);
        }

        void AddTreatment(Treatment treatment)
        {
            IRepository.AddTreatment(treatment);
        }

        void UpdateTreatment(Treatment treatment)
        {
            IRepository.UpdateTreatment(treatment);
        }

        void AddAppointment(Appointment appointment)
        {
            IRepository.AddAppointment(appointment);
        }

        void UpdateAppointment(Appointment appointment)
        {
            IRepository.UpdateAppointment(appointment);
        }

        #endregion


        #region fetch from db
        List<Volunteer> GetAllVolunteers(Func<Volunteer, bool> predicate = null)
        {

        }
        List<Admin> GetAllAdmins(Func<Admin, bool> predicate = null)
        {

        }
        List<Mentor> GetAllMentors(Func<Mentor, bool> predicate = null)
        {

        }
        List<Teenager> GetAllTeenagers(Func<Teenager, bool> predicate = null)
        {

        }
        List<Treatment> GetAllTreatments(Func<Treatment, bool> predicate = null)
        {

        }
        List<Appointment> GetAllAppointments(Func<Appointment, bool> predicate = null)
        {

        }

        #endregion


        #region Machtes
        List<Volunteer> FindClosetVolunteers(Address address)
        {
            List<Volunteer> result = new List<Volunteer>();
            Func<Volunteer, bool> predicate = null;
            result = GetAllVolunteers(predicate);
            return result;
        }
        int FindClosetAdmin()
        {
            int adminId = 0; // To Do אולי לפי מיקום
            // להתחבר לנתונים להוציא עם הפונקציה של קבלת אדמין את כל האדמינים באזור של המנטור ואז מתוכם לבחור את באדמין עם הכי פחות מנטורים ומתנדבים
            return adminId;
        }

        #endregion
    }

}

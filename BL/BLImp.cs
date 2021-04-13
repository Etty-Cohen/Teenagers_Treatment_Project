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
            // return a list of all volunteers at teenager's city.
            result = GetAllVolunteers(a => a.Address.City == address.City);     
            return result; 
        }‏


         public int GetCEOAdmin()
        {
            List<Admin> CEO = GetAllAdmins(a => a.IsCEO == true);
            try{
                return CEO.ElementAt(0).AdminId;
            }
            catch(Exception){
                throw new NoCEOException("CEO not exist");
            }
        }

        int FindClosetAdmin(Areas area)
        {
            List<Admin> result = new List<Admin>(); 
            // get the admin(s) at the given area.
            result = GetAllAdmins(a => a.Area == area);
            int adminId = GetCEOAdmin(); // might throw an "NoCEOException" exception
            double minVal = double.PositiveInfinity;
            int count;  
            foreach (var admin in result) {
                if ((count = admin.Volunteers.Count + admin.Mentors.Count) < minVal){//that admin has less volunteers
                    minVal = count;
                    adminId = admin.AdminId;
                }       // To Do אולי לפי מיקום     // להתחבר לנתונים להוציא עם הפונקציה של קבלת אדמין את כל האדמינים באזור של המנטור ואז מתוכם לבחור את באדמין עם הכי פחות מנטורים ומתנדבים     
            }
            return adminId;
        }‏


            #endregion
        }

    }

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

    public class BLImp : IBL
    {
        public IRepository IRepository { get; set; }

        public BLImp()
        {
            IRepository = new Repository();
        }


        #region update db
        public void AddVolunteer(Volunteer volunteer)
        {
            IRepository.AddVolunteer(volunteer);
        }
        public void RemoveVolunteer(Volunteer volunteer)
        {
            IRepository.RemoveVolunteer(volunteer);
        }

        public void UpdateVolunteer(Volunteer volunteer)
        {
            IRepository.UpdateVolunteer(volunteer);
        }

        public void AddAdmin(Admin admin)
        {
            IRepository.AddAdmin(admin);
        }
        public void RemoveAdmin(Admin admin)
        {
            IRepository.RemoveAdmin(admin);
        }
        public void UpdateAdmin(Admin admin)
        {
            IRepository.UpdateAdmin(admin);
        }

        public void AddMentor(Mentor mentor)
        {
            IRepository.AddMentor(mentor);
        }

        public void RemoveMentor(Mentor mentor)
        {
            IRepository.RemoveMentor(mentor);
        }
        public void UpdateMentor(Mentor mentor)
        {
            IRepository.UpdateMentor(mentor);
        }
        public void AddTeenager(Teenager teenager)
        {
            IRepository.AddTeenager(teenager);
        }

        public void RemoveTeenager(Teenager teenager)
        {
            IRepository.RemoveTeenager(teenager);
        }
        public void UpdateTeenager(Teenager teenager)
        {
            IRepository.UpdateTeenager(teenager);
        }


        public void AddTreatment(Treatment treatment)
        {
            IRepository.AddTreatment(treatment);
        }

        public void UpdateTreatment(Treatment treatment)
        {
            IRepository.UpdateTreatment(treatment);
        }

        public void AddAppointment(Appointment appointment)
        {
            IRepository.AddAppointment(appointment);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            IRepository.UpdateAppointment(appointment);
        }

        //To Do
        public bool ChangePhoneNumber(String phoneNumber) { return true; }
        public bool ChangeAddress(Address Address) { return true; }
        public bool ChangePassword(String password) { return true; }

        #endregion


        #region fetch from db
        public List<Volunteer> GetAllVolunteers(Func<Volunteer, bool> predicate = null)
        {
            return IRepository.GetAllVolunteers(predicate);
        }
        public List<Admin> GetAllAdmins(Func<Admin, bool> predicate = null)
        {
            return IRepository.GetAllAdmins(predicate);

        }
        public List<Mentor> GetAllMentors(Func<Mentor, bool> predicate = null)
        {
            return IRepository.GetAllMentors(predicate);
        }
        public List<Teenager> GetAllTeenagers(Func<Teenager, bool> predicate = null)
        {
            return IRepository.GetAllTeenagers(predicate);
        }
        public List<Treatment> GetAllTreatments(Func<Treatment, bool> predicate = null)
        {
            return IRepository.GetAllTreatments(predicate);
        }
        public List<Appointment> GetAllAppointments(Func<Appointment, bool> predicate = null)
        {
            return IRepository.GetAllAppointments(predicate);
        }

        #endregion


        #region Machtes

        public List<Volunteer> FindClosetVolunteers(Address address)
        {
            List<Volunteer> result = new List<Volunteer>();
            // return a list of all volunteers at teenager's city.
            result = GetAllVolunteers(a => a.Address.City == address.City);
            return result;
        }

        /// <summary>
        /// That function return the id of the main admin.
        /// </summary>
        /// <exception>Thrown when there is no main admin.</exception>
        /// <returns></returns>
         public int GetMainAdmin()
        {
            List<Admin> Main = GetAllAdmins(a => a.IsMainAdmin == true);
            try{
                return Main.ElementAt(0).AdminId;
            }
            catch(Exception){
                throw new NoMainAdminException("MainAdmin not exist");
            }
        }

        /// <summary>
        /// That function is looking for the admin in the given area,
        /// with the fewest volunteers & mentors.
        /// if there are no admin to that area- return the main admin id
        /// </summary>
        /// <param name="area"></param>
        /// <returns>adminId</returns>
        public int FindClosetAdmin(Areas area)
        {
            List<Admin> result = new List<Admin>();
            // get the admin(s) at the given area.
            result = GetAllAdmins(a => a.Area == area);
            int adminId = GetMainAdmin(); // might throw an "NoCEOException" exception
            double minVal = double.PositiveInfinity;
            int count;
            foreach (var admin in result)
            {
                if ((count = admin.Volunteers.Count + admin.Mentors.Count) < minVal)
                {//that admin has less volunteers
                    minVal = count;
                    adminId = admin.AdminId;
                }
            }
            return adminId;

        }


        #endregion
    }

    }

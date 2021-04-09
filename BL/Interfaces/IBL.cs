using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL.Interfaces
{
    public interface IBL
    {
        void AddVolunteer(Volunteer person);
        void RemoveVolunteer(Volunteer person);
        void AddAdmin(Admin person);
        void RemoveAdmin(Admin person);
        void AddMentor(Mentor person);
        void RemoveMentor(Mentor person);
        void AddTeenager(Teenager person);
        void RemoveTeenager(Teenager person);
        void AddTreatment(Treatment treatment);
        void UpdateTreatment(Treatment treatment);
        void AddAppointment(Appointment appointment);
        void UpdateAppointment(Appointment appointment);

        List<Volunteer> GetAllVolunteers(Func<Volunteer, bool> predicate = null);
        List<Admin> GetAllAdmins(Func<Admin, bool> predicate = null);
        List<Mentor> GetAllMentors(Func<Mentor, bool> predicate = null);
        List<Teenager> GetAllTeenagers(Func<Teenager, bool> predicate = null);
        List<Treatment> GetAllTreatments(Func<Treatment, bool> predicate = null);
        List<Appointment> GetAllAppointments(Func<Appointment, bool> predicate = null);

        List<Volunteer> FindClosetVolunteers(Address address);
        int FindClosetAdmin();
    }
}

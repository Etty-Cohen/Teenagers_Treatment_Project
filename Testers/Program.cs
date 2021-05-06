using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
using BL.Interfaces;

namespace Testers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tester tester = new Tester();
            IBL BL = new BLImp();
            
            Address addressA1 = new Address("Jerusalem", Areas.והסביבה_ירושלים, "Hafetz Haim", 2);
            Admin mainAdmin = new Admin("Haim", "Klar", "0533111111", "admin@gmail.com", addressA1, "0533111111", true);
            BL.AddAdmin(mainAdmin);

            Address addressV1 = new Address("Beitar", Areas.והסביבה_ירושלים, "Hafetz Haim", 6);
            int adminIdV1 = BL.FindClosetAdmin(addressV1.Area);
            Volunteer v1 = new Volunteer("Etty", "Cohen", "0533333333", "1@gmail.com",addressV1, "0533333333", adminIdV1);
            BL.AddVolunteer(v1);
            
            
            List<Admin> Admins;
            Console.WriteLine("Admins:\n");
            Admins = BL.GetAllAdmins();
            foreach (var admin in Admins)
            {
                Console.WriteLine(admin.GetFirstName());
                Console.WriteLine(admin.GetLastName());
            }
            /*
            List<Volunteer> volunteers;
            volunteers = BL.GetAllVolunteers();
            Console.WriteLine("Volunteers:\n");
            foreach (var volunteer in volunteers)
            {
                Console.WriteLine(volunteer.GetFirstName(), volunteer.GetLastName());
            }
            */
            /*List<Admin> Admins = BL.GetAllAdmins(p => p.IsMainAdmin=true);
            foreach (var a in Admins)
            {
                if(a.AdminId == 2)
                    BL.RemoveAdmin(a);
            }*/
            

        }
    }
}

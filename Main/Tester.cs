using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
using BL.Interfaces;

namespace Main
{
    
    public class Tester
    {
        // Main Method
        public static void Main(String[] args)
        {

            //Tester tester = new Tester();
            IBL BL = new BLImp();
            List<Volunteer> volunteers;
            volunteers = BL.GetAllVolunteers();
            foreach (var volunteer in volunteers)
            {
                Console.WriteLine(volunteer.GetFirstName(), volunteer.GetLastName());
            }

            List<Admin> Admins;
            Admins = BL.GetAllAdmins();
            Console.WriteLine("Main Method");
        }
    }

       

    }


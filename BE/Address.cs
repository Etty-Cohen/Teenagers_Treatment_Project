using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Address     /*add/*
    {

        public string City { get; set; }

        public Areas Area { get; set; }

        public string Street { get; set; }
        public int BuildingNumber { get; set; }
    

        public Address(string City, Areas Area, string Street, int BuildingNumber)
        {
            this.City = City;
            this.Area = Area;
            this.Street = Street;
            this.BuildingNumber = BuildingNumber;
        }

        public Address(Address address)
        {
            City = address.City;
            Area = address.Area;
            Street = address.Street;
            BuildingNumber = address.BuildingNumber;
        }

        public override string ToString()
        {
            return Street + " " + BuildingNumber + " " + City + " " + Area;
        }
    }
}

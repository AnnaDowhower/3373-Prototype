using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Household
    {
        public string House_ID;
        public string HouseLastName;
        public string Address;
        public string Email;

        public Household()
        {
            House_ID = null;
            HouseLastName = null;
            Address = null;
            Email = null;
        }

        public Household(string houseID, string lastName, string address, string email)
        {
            House_ID = houseID;
            HouseLastName = lastName;
            Address = address;
            Email = email;
        }

        public override string ToString()
        {
            return $"ID: {House_ID}, Last Name: {HouseLastName}, Address: {Address}, Email: {Email}";
        }
    }
}

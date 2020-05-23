using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Scholarship_Resident : Resident
    {
        //Child class of Resient fo making Scholarship_Resident Objects
        public string Scholarship_Type { get; set; }
        public double Scholarship_Amount { get; set; }

        public Scholarship_Resident(string name, int id, int floor, string type, int room, double fee, string scholarshipType, double scholarshipAmount) //Constructor
        {
            this.Name = name;
            this.Id_Number = id;
            this.Floor = floor;
            this.Resident_Type = type;
            this.Room_Number = room;
            this.Boarding_Fee = fee;
            this.Scholarship_Type = scholarshipType;
            this.Scholarship_Amount = scholarshipAmount;
        }
    }
}

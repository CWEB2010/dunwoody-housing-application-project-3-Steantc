using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Scholarship_Resident : Resident
    {
        public string Scholarship_Type { get; set; }
        public double Scholarship_Amount { get; set; }

        public Scholarship_Resident(string name, int id, int floor, string type, string scholarshipType, double scholarshipAmount)
        {
            this.Name = name;
            this.Id_Number = id;
            this.Floor = floor;
            this.Resident_Type = type;
            this.Scholarship_Type = scholarshipType;
            this.Scholarship_Amount = scholarshipAmount;
        }
    }
}

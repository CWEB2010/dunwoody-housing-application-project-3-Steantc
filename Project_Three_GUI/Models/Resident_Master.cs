using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Resident_Master : Resident
    {
        public string Sport { get; set; }
        public string Role { get; set; }
        public string Job { get; set; }
        public double Hourly_pay { get; set; }
        public string Scholarship_Type { get; set; }
        public double Scholarship_Amount { get; set; }

        public Resident_Master(string name, int id, int floor, string type, string sport, string role, string job, double pay, string scholarshipType, double scholarshipAmount)
        {
            this.Name = name;
            this.Id_Number = id;
            this.Floor = floor;
            this.Resident_Type = type;
            this.Sport = sport;
            this.Role = role;
            this.Job = job;
            this.Hourly_pay = pay;
            this.Scholarship_Type = scholarshipType;
            this.Scholarship_Amount = scholarshipAmount;
        }
    }
}

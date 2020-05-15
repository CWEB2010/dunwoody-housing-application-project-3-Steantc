using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Student_Worker : Resident
    {
        public string Job { get; set; }
        public double Hourly_pay { get; set; }

        public Student_Worker(string name, int id, int floor, string type, string job, double pay)
        {
            this.Name = name;
            this.Id_Number = id;
            this.Floor = floor;
            this.Resident_Type = type;
            this.Job = job;
            this.Hourly_pay = pay;
        }
    }
}

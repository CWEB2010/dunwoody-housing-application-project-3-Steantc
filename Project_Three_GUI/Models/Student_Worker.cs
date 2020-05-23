using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Student_Worker : Resident
    {
        //Child class of Resient fo making Student_Worker Objects
        public int Hours_Worked { get; set; }
        public double Hourly_pay { get; set; }

        public Student_Worker(string name, int id, int floor, string type, int room, double fee, int hours, double pay) //Constructor
        {
            this.Name = name;
            this.Id_Number = id;
            this.Floor = floor;
            this.Resident_Type = type;
            this.Room_Number = room;
            this.Boarding_Fee = fee;
            this.Hours_Worked = hours;
            this.Hourly_pay = pay;
        }
    }
}

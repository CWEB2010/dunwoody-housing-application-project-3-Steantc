using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Athlete_Resident : Resident
    {
        public string Sport { get; set; }
        public string Role { get; set; }

        public Athlete_Resident(string name, int id, int floor, string type, int room, double fee, string sport, string role)
        {
            this.Name = name;
            this.Id_Number = id;
            this.Floor = floor;
            this.Resident_Type = type;
            this.Room_Number = room;
            this.Boarding_Fee = fee;
            this.Sport = sport;
            this.Role = role;
        }
    }
}

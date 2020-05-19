using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
     abstract class Resident
    {
        public string Name { get; set; }
        public int Id_Number { get; set; }
        public int Floor { get; set; }
        public string Resident_Type { get; set; }

        //public Resident(string name, int id, int floor, string type)
        //{
        //    this.Name = name;
        //    this.Id_Number = id;
        //    this.Floor = floor;
        //    this.Resident_Type = type;
        //}
    }
}

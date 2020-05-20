using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class DataSource
    {
		//DECLARATIONS
		const string PATH = @"C:\Users\steantc\Documents\CWEB2010\dunwoody-housing-application-project-3-Steantc-master\residentList.csv";

		//FileStream input;
		//StreamReader read;
		string line;
		string[] data;
		ObservableCollection<Resident> residentList;//Global

		/**Mehod that reads the data into the program **/
		public ObservableCollection<Resident> readData()
		{
			string line;
			string[] data;
			ObservableCollection<Resident> residentList = null;
			try
			{
				FileStream input = new FileStream(PATH, FileMode.Open, FileAccess.Read);
				StreamReader read = new StreamReader(input);
				line = read.ReadLine();
				residentList = new ObservableCollection<Resident>();

				//Looping structure to read in all records
				while (!read.EndOfStream)
				{
					data = read.ReadLine().Split(',');
					if (data[3] == "Worker")
					{
						residentList.Add(new Student_Worker(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2]), data[3], Convert.ToInt32(data[4]), Convert.ToDouble(data[5]), Convert.ToInt32(data[6]), Convert.ToDouble(data[7])));
						Console.WriteLine(residentList[residentList.Count - 1]);
					}
					if (data[3] == "Scholarship")
					{
						residentList.Add(new Scholarship_Resident(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2]), data[3], Convert.ToInt32(data[4]), Convert.ToDouble(data[5]), data[8], Convert.ToDouble(data[9])));
						Console.WriteLine(residentList[residentList.Count - 1]);
					}
					if (data[3] == "Athlete")
					{
						residentList.Add(new Athlete_Resident(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2]), data[3], Convert.ToInt32(data[4]), Convert.ToDouble(data[5]), data[10], (data[11])));
						Console.WriteLine(residentList[residentList.Count - 1]);
					}
				}
				read.Dispose();
				input.Dispose();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return residentList;
		}//End of readData() method

		public void writeData(ObservableCollection<Resident> residentList)
		{
			FileStream output = new FileStream(PATH, FileMode.Create, FileAccess.Write);
			StreamWriter write = new StreamWriter(output);
			write.WriteLine("Name,Id_Number,Floor,Resident_Type,Room,Boarding_Fee,Hours_Worked,Hourly_Pay,Scholarship_Type,Scholarship_Amount,Sport,Role");
			foreach (Student_Worker x in residentList)
			{
				write.WriteLine($"{x.Name},{x.Id_Number},{x.Floor},{x.Resident_Type},{x.Room_Number},{x.Boarding_Fee},{x.Hours_Worked}, {x.Hourly_pay}");
			}
			foreach (Scholarship_Resident x in residentList)
			{
				write.WriteLine($"{x.Name},{x.Id_Number},{x.Floor},{x.Resident_Type},{x.Room_Number},{x.Boarding_Fee},'','',{x.Scholarship_Type}, {x.Scholarship_Amount}");
			}
			foreach (Athlete_Resident x in residentList)
			{
				write.WriteLine($"{x.Name},{x.Id_Number},{x.Floor},{x.Resident_Type},{x.Room_Number},{x.Boarding_Fee},'','','','',{x.Sport}, {x.Role}");
			}
			write.Dispose();
			output.Dispose();

		}//End of writeData
	}
}

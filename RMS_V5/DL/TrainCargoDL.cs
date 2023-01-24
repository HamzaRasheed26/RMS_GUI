using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RMS_V5.BL;

namespace RMS_V5.DL
{
    internal class TrainCargoDL
    {
        private static List<TrainCargo> cargoList = new List<TrainCargo>();

        public static List<TrainCargo> CargoList { get => cargoList; set => cargoList = value; }

        public static void addIntoList(TrainCargo cargo)
        {
            cargoList.Add(cargo);
        }

        public static List<TrainCargo> getCargoList()
        {
            return cargoList;
        }

        public static TrainCargo getSingleObject(int index)
        {
            if(index >= 0 || index < cargoList.Count)
            {
                return cargoList[index];
            }
            return null;
        }

        public static int ListCount()
        {
            return cargoList.Count;
        }

        public static void loadDataFromFile(string path)
        {
            string line;
            // reding cargo booked data from file
            if (File.Exists(path))
            {
                StreamReader cargo_File = new StreamReader(path);
                while ((line = cargo_File.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');
                    string TrainName = splittedRecord[0];      // cargo booked train name
                    string From = splittedRecord[1];        // departure station
                    string To = splittedRecord[2];          // arrival station
                    float Weight = int.Parse(splittedRecord[3]);     // weight of cargo
                    float Price = int.Parse(splittedRecord[4]);    // cargo booking price
                    int Booking_no = int.Parse(splittedRecord[5]); // booking number
                    float day = float.Parse(splittedRecord[6]);   // booking day
                    float month = float.Parse(splittedRecord[7]); // booking month
                    float year = float.Parse(splittedRecord[8]);  // booking year
                    float date = float.Parse(splittedRecord[9]); // calculated date for applying conditions

                    TrainCargo cargo = new TrainCargo(TrainName, From, To, Weight, Price, Booking_no, day, month, year, date);

                    addIntoList(cargo); // adding into list of bookaed cargos

                }
                cargo_File.Close(); // closing file
            }
        }

        public static void storeDataIntoFile(string path)
        {
            // writing cargo booking data into file
            StreamWriter cargo_File = new StreamWriter(path);
            int idx = 0;
            foreach (TrainCargo c in cargoList)
            {
                cargo_File.Write(c.TrainName + "," + c.From + "," + c.To + ",");
                cargo_File.Write(c.Weight + "," + c.Price + "," + c.Booking_no + ",");
                cargo_File.Write(c.Day + "," + c.Month + "," + c.Year + "," + c.Date + ",");

                if (idx < cargoList.Count - 1)
                {
                    cargo_File.WriteLine();
                }
                idx++;
            }
            cargo_File.Close(); // closing file
        }
        public static List<TrainCargo> sortCargoList()
        {
            if (cargoList != null)
            {
                List<TrainCargo> sortedCargoList = cargoList.OrderBy(o => o.Date).ToList();
                return sortedCargoList;
            }

            return null;
        }

        

        public static bool isDateValid(int d, int m, int y)
        {
            // check on year
            if (y == 2022)
            {
                // check on month
                if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                {
                    // check on day range from 1 to 31
                    if (d >= 1 && d <= 31)
                    {
                        return true;
                    }
                }
                // check on month
                else if (m == 4 || m == 6 || m == 9 || m == 11)
                {
                    // check on  day range from 1 to 30
                    if (d >= 1 && d <= 30)
                    {
                        return true;
                    }
                }
                // check on month of febuary
                else if (m == 2)
                {
                    // check on day range from 1 to 28
                    if (d >= 1 && d <= 28)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }
}

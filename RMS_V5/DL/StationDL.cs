using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RMS_V5.BL;

namespace RMS_V5.DL
{
    public class StationDL
    {
        private static List<string> stationsList = new List<string>();

        public static List<string> StationsList { get => stationsList; set => stationsList = value; }

        public static List<string> getList()
        {
            return stationsList;
        }

        public static string GetSingleSingleByIndex(int idx)
        {
            if (idx >= 0 && idx < stationsList.Count)
            {
                return stationsList[idx];
            }
            return null;
        }

        public static void addIntoList(string station)
        {
            stationsList.Add(station);
        }

        // function for adding new station in array
        public static void add_station_to_array( string st)
        {
            int n1 = 0;

            for (int i = 0; i < stationsList.Count; i++) // loop for checking is name already exist or not
            {

                if (stationsList[i] != st) // checking name in station array
                {
                    n1++;
                    if (n1 == stationsList.Count) // if name does not find
                    {
                        stationsList.Add(st); // than add it in array

                    }
                }
                else
                {
                    break;
                }
            }
        }

        public static void loadDataFromFile(string path)
        {
            string line;
            // reading stations names from file
            if (File.Exists(path))
            {
                StreamReader st_file = new StreamReader(path);// variable for reading stations name
                while ((line = st_file.ReadLine()) != null)
                {
                   addIntoList(line);
                }
                st_file.Close(); // closing file
            }
        }

        public static void storeDataIntoFile(string path)
        {
            // writing stations names into file
            StreamWriter st_file = new StreamWriter(path);
           
            for (int idx = 0; idx < stationsList.Count; idx++)
            {
                st_file.Write(stationsList[idx]);
                if (idx < stationsList.Count - 1)
                {
                    st_file.WriteLine();
                }
            }
            st_file.Close();
        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_V5
{
    internal class Utility
    {
        private static string notice = "No Notice Available"; 

        private static string routePath = "Train_Routes_Data.txt";
        private static string ticketPath = "tickets_data.txt";
        private static string cargoPath = "booked_cargo_data.txt";
        private static string stationPath = "stations.txt";
        private static string credentialFilePath = "Credentials.txt";

        public static string RoutePath { get => routePath; set => routePath = value; }
        public static string TicketPath { get => ticketPath; set => ticketPath = value; }
        public static string CargoPath { get => cargoPath; set => cargoPath = value; }
        public static string StationPath { get => stationPath; set => stationPath = value; }
        public static string CredentialFilePath { get => credentialFilePath; set => credentialFilePath = value; }
        public static string Notice { get => notice; set => notice = value; }
    }
}

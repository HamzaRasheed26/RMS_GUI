namespace RMS_V5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DL.MUserDL.readData(Utility.CredentialFilePath);
            DL.RouteDL.LoadDataFromFile(Utility.RoutePath);
            DL.TrainTicketDL.loadDataFromFile(Utility.TicketPath);
            DL.TrainCargoDL.loadDataFromFile(Utility.CargoPath);
            DL.StationDL.loadDataFromFile(Utility.StationPath);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.FrmLoginPage());
        }
    }
}
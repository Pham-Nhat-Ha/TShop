using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;

namespace PRN_TShop
{
    internal static class Program
    {
        public static string ConnectionString;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ConnectionString = ConfigurationManager.ConnectionStrings["EmployeeJobTitleDb"].ConnectionString;
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var configuration = builder.Build();

            //Get connectionstring 
            ConnectionString = configuration.GetSection("ConnectionStrings").GetSection("DrinkAllDB").Value;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}

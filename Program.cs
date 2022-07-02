using System;
using System.IO;
using System.Windows.Forms;
using DateConverter.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace DateConverter
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            var defaultCity = configuration.GetSection("DefaultCity").Value;
            var timeService = new TimeService();

            Application.Run(new Main(timeService, defaultCity));
        }
    }
}

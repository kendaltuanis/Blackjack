using Blackjack.Cartas;
using System;
using System.Windows.Forms;
using DBAccess;
using System.Configuration;

namespace Blackjack
{
    static class Program
    {
        public static DBAccess.DBAccess connection;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string path = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            string connectionString = ConfigurationManager.ConnectionStrings["lite"].ConnectionString;

            Program.connection = new SqliteAccess(connectionString);

            Application.Run(new Blackjack.Vistas.Juego());
        }
    }
}

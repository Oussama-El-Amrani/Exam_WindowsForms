using System.Data.SqlClient;
using Exam_WindowsForms.Model;
using Exam_WindowsForms.Persistence;
using Exam_WindowsForms.Persistence.util;
using Exam_WindowsForms.View;

namespace Exam_WindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            //DatabaseConnectionManager databaseConnectionManager = new DatabaseConnectionManager();
            //SqlConnection connection = databaseConnectionManager.getConnection();
            //ProfesseurDAO professeurDao = new ProfesseurDAO(connection);
            //List<Professeur> professeurs = professeurDao.findAll(1);
            //professeurs.ForEach(x=> Console.WriteLine(x.NomComplet + x.Cne + x.Email + x.ProfesseurId));

            var FormAuth = new FormAuth();
            FormAuth.ShowDialog();
        }
    }
}
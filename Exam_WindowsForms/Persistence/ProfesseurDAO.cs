using System.CodeDom;
using System.Data;
using System.Data.SqlClient;
using Exam_WindowsForms.Model;
using Exam_WindowsForms.Persistence.util;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Exam_WindowsForms.Persistence;

public class ProfesseurDAO : DataAccessObject<Professeur>
{
    private static readonly string INSERT = @"INSERT INTO Professeur(nomComplet,cne,email) 
                                         VALUES(@nomComplet,@cne,@email); 
                                         SELECT CAST(SCOPE_IDENTITY() AS int);";

    private static readonly string GET_ONE = "SELECT professeur.professeurId,nomComplet,cne,email,examId,examNom,dateDebut,Duree " +
                                             "FROM professeur,Exam " +
                                             "WHERE professeur.professeurId = @id" +
                                             " OR Exam.professeurId = professeur.professeurId";

    private static readonly string GET_ALL = "SELECT professeur.professeurId,nomComplet,cne,email,examId,examNom,dateDebut,Duree " +
                                             "FROM professeur,Exam " +
                                             "WHERE Exam.professeurId = professeur.professeurId";
    public ProfesseurDAO(SqlConnection cnx) : base(cnx)
    {
    }

    public override Professeur findById(long id)
    {
        Professeur professeur = new Professeur();
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, Connection);
            command.CommandText = GET_ONE;
            SqlParameter idParameter = new SqlParameter("@id",SqlDbType.Int,0);
            idParameter.Value = id;
            command.Parameters.Add(idParameter);
            command.Prepare();
            SqlDataReader sqlDataReader = command.ExecuteReader();
            long professeurId = 0;
            List<Exam> exams = new List<Exam>();
            while (sqlDataReader.Read())
            {
                if (professeurId == 0)
                {
                    professeur.ProfesseurId = sqlDataReader.GetInt32("professeurId");
                    professeur.Cne = sqlDataReader.GetString("cne");
                    professeur.Email = sqlDataReader.GetString("email");
                    professeur.NomComplet = sqlDataReader.GetString("nomComplet");
                    professeur.Exams = exams;
                    professeurId = professeur.ProfesseurId;
                }

                ExamDAO examDAO = new ExamDAO(this.Connection);
                long examId = sqlDataReader.GetInt32("examId");
                Exam exam = examDAO.findById(examId);
                professeur.Exams.Add(exam);
            }
            Connection.Close();
        }
        return professeur;
    }

    public override List<Professeur> findAll()
    {
        List<Professeur> professeurs = new List<Professeur>();
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, Connection);
            command.CommandText = GET_ALL;
            command.Prepare();
            SqlDataReader sqlDataReader = command.ExecuteReader();
            long professeurId = 0;
            Professeur professeur = null;
            while (sqlDataReader.Read())
            {
                long localProfesseur = sqlDataReader.GetInt32("professeurId");
                if (localProfesseur!= professeurId)
                {
                    professeur = new Professeur();
                    professeurs.Add(professeur);
                    professeurId = sqlDataReader.GetInt32("professeurId");
                    professeur.ProfesseurId = professeurId;
                    professeur.Cne = sqlDataReader.GetString("cne");
                    professeur.Email = sqlDataReader.GetString("email");
                    professeur.NomComplet = sqlDataReader.GetString("nomComplet");
                    List<Exam> exams = new List<Exam>();
                    professeur.Exams = exams;
                }
                long examId = sqlDataReader.GetInt32("examId");
                ExamDAO examDAO = new ExamDAO(this.Connection);
                Exam exam = examDAO.findById(examId);
                
                professeur.Exams.Add(exam);
            }
        }
        return professeurs;
    }

    public override Professeur update(Professeur dto)
    {
        throw new NotImplementedException();
    }

    public override Professeur create(Professeur dto)
    {
        //using (this.Connection)
        //{
            Connection.Open();
            SqlCommand command = new SqlCommand(null, Connection);
            command.CommandText = INSERT;
            SqlParameter nomCompletParameter = new SqlParameter("@nomComplet", SqlDbType.VarChar, 100);
            SqlParameter cneParameter = new SqlParameter("@cne", SqlDbType.VarChar, 10);
            SqlParameter emailParameter = new SqlParameter("@email", SqlDbType.VarChar, 250);
            nomCompletParameter.Value = dto.NomComplet;
            cneParameter.Value = dto.Cne;
            emailParameter.Value = dto.Email;
            command.Parameters.Add(nomCompletParameter);
            command.Parameters.Add(cneParameter);
            command.Parameters.Add(emailParameter);
            command.Prepare();
            int id = (int)command.ExecuteScalar();
            Connection.Close();
            //long id = getLastVal(LAST_VAL);
            dto.ProfesseurId = id;
        //}
        //return this.findById(id);
        return dto;

    }

    public override void delete(long id)
    {
        throw new NotImplementedException();
    }
}
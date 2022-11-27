using System.Data;
using System.Data.SqlClient;
using Exam_WindowsForms.Model;
using Exam_WindowsForms.Persistence.util;

namespace Exam_WindowsForms.Persistence;

public class ExamDAO : DataAccessObject<Exam>
{
    private static readonly string INSERT =
        "INSERT INTO Exam(examNom,dateDebut,Duree,professeurId)" +
        "VALUES(@examNom,@dateDebut,@Duree,@professeurId)";
    private static readonly string GET_ONE =
        @"SELECT ex.examId, examNom, dateDebut, Duree, professeurId,
          QCM.questionId AS QCMId, QO.questionId AS questionOuverteId,
          e.etudiantId
          FROM Exam AS ex, Etudiant AS e, QuestionChoixMultiple AS QCM,
          QuestionOuverte AS QO, Etudiant_Exam AS e_ex
          WHERE ex.examId = @examId
          AND QCM.examId = ex.examId
          AND QO.examId = ex.examId
          AND ex.examId = e_ex.examId
          AND e_ex.etudiantId = e.etudiantId";
    private static readonly string GET_ALL =
        @"SELECT ex.examId, examNom, dateDebut, Duree, professeurId,
          QCM.questionId AS QCMId, QO.questionId AS questionOuverteId,
          e.etudiantId
          FROM Exam AS ex, Etudiant AS e, QuestionChoixMultiple AS QCM,
          QuestionOuverte AS QO, Etudiant_Exam AS e_ex
          WHERE QCM.examId = ex.examId
          AND QO.examId = ex.examId
          AND ex.examId = e_ex.examId
          AND e_ex.etudiantId = e.etudiantId";
    private static readonly string LAST_VAL =
        "SELECT examId " +
        "FROM Exam " +
        "WHERE examId = @@Identity";
    public ExamDAO(SqlConnection cnx) : base(cnx)
    {
    }

    public override Exam findById(long id)
    {
        Exam exam = new Exam();
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, Connection);
            command.CommandText = GET_ONE;
            SqlParameter idParameter = new SqlParameter("@examId", SqlDbType.Int, 0);
            idParameter.Value = id;
            command.Parameters.Add(idParameter);
            command.Prepare();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            long examId = 0;
            List<QuestionChoixMultiple> questionChoixMultiples = new List<QuestionChoixMultiple>();
            List<QuestionOuverte> questionOuvertes = new List<QuestionOuverte>();
            List<Etudiant> etudiants = new List<Etudiant>();
            while (sqlDataReader.Read())
            {
                if (examId == 0)
                {
                    exam.Nom = sqlDataReader.GetString("examNom");
                    exam.DateDebut = sqlDataReader.GetDateTime("dateDebut");
                    exam.Duree = sqlDataReader.GetInt32("Duree");
                    exam.ExamId = sqlDataReader.GetInt32("ex.examId");
                    examId = exam.ExamId;

                    long professeurId = sqlDataReader.GetInt32("professeurId");
                    ProfesseurDAO professeurDAO = new ProfesseurDAO(this.Connection);
                    exam.Professeur = professeurDAO.findById(professeurId);

                    exam.Etudiants = etudiants;
                    exam.QuestionChoixMultiples = questionChoixMultiples;
                    exam.QuestionOuvertes = questionOuvertes;
                }

                QuestionChoixMultipleDAO questionChoixMultipleDAO = new QuestionChoixMultipleDAO(this.Connection);
                QuestionChoixMultiple questionChoixMultiple =
                    questionChoixMultipleDAO.findById(sqlDataReader.GetInt32("QCMId"));

                QuestionOuverteDAO questionOuverteDAO = new QuestionOuverteDAO(this.Connection);
                QuestionOuverte questionOuverte =
                    questionOuverteDAO.findById(sqlDataReader.GetInt32("questionOuverteId"));

                EtudiantDAO etudiantDao = new EtudiantDAO(this.Connection);
                Etudiant etudiant = etudiantDao.findById(sqlDataReader.GetInt32("etudiantId"));

                exam.QuestionOuvertes.Add(questionOuverte);
                exam.QuestionChoixMultiples.Add(questionChoixMultiple);
                exam.Etudiants.Add(etudiant);
            }
            Connection.Close();
            return exam;
        }
    }

    public override List<Exam> findAll()
    {
        List<Exam> exams = new List<Exam>();
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, this.Connection);
            command.CommandText = GET_ALL;
            command.Prepare();
            SqlDataReader sqlDataReader = command.ExecuteReader();
            long examId = 0;
            Exam exam = null;
            while (sqlDataReader.Read())
            {
                long localExam = sqlDataReader.GetInt32("ex.examId");
                if (localExam != examId)
                {
                    exam = new Exam();
                    exams.Add(exam);
                    examId = sqlDataReader.GetInt32("ex.examId");
                    exam.ExamId = examId;
                    exam.Nom = sqlDataReader.GetString("examNom");
                    exam.DateDebut = sqlDataReader.GetDateTime("dateDebut");
                    exam.Duree = sqlDataReader.GetInt32("Duree");

                    long professeurId = sqlDataReader.GetInt32("professeurId");
                    ProfesseurDAO professeurDAO = new ProfesseurDAO(this.Connection);
                    exam.Professeur = professeurDAO.findById(professeurId);

                    List<QuestionChoixMultiple> questionChoixMultiples = new List<QuestionChoixMultiple>();
                    List<QuestionOuverte> questionOuvertes = new List<QuestionOuverte>();
                    List<Etudiant> etudiants = new List<Etudiant>();

                    exam.Etudiants = etudiants;
                    exam.QuestionOuvertes = questionOuvertes;
                    exam.QuestionChoixMultiples = questionChoixMultiples;
                }

                long etudiantId = sqlDataReader.GetInt32("etudiantId");
                EtudiantDAO etudiantDAO = new EtudiantDAO(this.Connection);
                Etudiant etudiant = etudiantDAO.findById(etudiantId);

                long qcmId = sqlDataReader.GetInt32("QCMId");
                QuestionChoixMultipleDAO qcmDAO = new QuestionChoixMultipleDAO(this.Connection);
                QuestionChoixMultiple qcm = qcmDAO.findById(qcmId);

                long questionOuverteId = sqlDataReader.GetInt32("questionOuverteId");
                QuestionOuverteDAO questionOuverteDao = new QuestionOuverteDAO(this.Connection);
                QuestionOuverte questionOuverte = questionOuverteDao.findById(questionOuverteId);

                exam.Etudiants.Add(etudiant);
                exam.QuestionOuvertes.Add(questionOuverte);
                exam.QuestionChoixMultiples.Add(qcm);
            }
            Connection.Close();
            return exams;
        }
    }

    public override Exam update(Exam dto)
    {
        throw new NotImplementedException();
    }

    public override Exam create(Exam dto)
    {
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, this.Connection);
            command.CommandText = INSERT;

            SqlParameter examNomParameter = new SqlParameter("@examNom", SqlDbType.Int);
            SqlParameter dateDebutParameter = new SqlParameter("@dateDebut", SqlDbType.Date);
            SqlParameter dureeParameter = new SqlParameter("@Duree", SqlDbType.Int);
            SqlParameter professeurIdParameter = new SqlParameter("@professeurId", SqlDbType.Int);

            examNomParameter.Value = dto.Nom;
            dateDebutParameter.Value = dto.DateDebut;
            professeurIdParameter.Value = dto.Professeur.ProfesseurId;
            dureeParameter.Value = dto.Duree;
            command.Parameters.Add(examNomParameter);
            command.Parameters.Add(dateDebutParameter);
            command.Parameters.Add(dureeParameter);
            command.Parameters.Add(professeurIdParameter);
            command.Prepare();
            command.ExecuteNonQuery();
            Connection.Close();
            //
            long id = getLastVal(LAST_VAL);
            return this.findById(id);
        }
    }

    public override void delete(long id)
    {
        throw new NotImplementedException();
    }
}
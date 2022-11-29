using System.Data;
using System.Data.SqlClient;
using Exam_WindowsForms.Model;
using Exam_WindowsForms.Persistence.util;

namespace Exam_WindowsForms.Persistence;

public class QuestionOuverteDAO : DataAccessObject<QuestionOuverte>
{
    private static readonly string INSERT =
        @"INSERT INTO questionOuverte(enonce,examId)
        VALUES(@enonce,@examId);
        SELECT CAST(SCOPE_IDENTITY() AS int);";

    private static readonly string GET_ONE =
        "SELECT questionId,enonce,reponse,examId" +
        "FROM QuestionOuverte" +
        "WHERE questionId = @questionId";

    private static readonly string GET_ALL =
        "SELECT enonce,reponse,examId" +
        "FROM QuestionOuverte";
    private static readonly string LAST_VAL =
        "SELECT questionId " +
        "FROM QuestionOuverte " +
        "WHERE questionId = @@Identity";

    public QuestionOuverteDAO(SqlConnection cnx) : base(cnx)
    {
    }

    public override QuestionOuverte findById(long id)
    {
        QuestionOuverte questionOuverte = new QuestionOuverte();
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, this.Connection);
            command.CommandText = GET_ONE;
            SqlParameter qcmIdParameter = new SqlParameter("@questionId", SqlDbType.Int);
            qcmIdParameter.Value = id;
            command.Parameters.Add(qcmIdParameter);
            command.Prepare();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                questionOuverte.QuestionId = sqlDataReader.GetInt32(0);
                questionOuverte.Enonce = sqlDataReader.GetString(1);
                questionOuverte.Reponse = sqlDataReader.GetString(2);
                long examId = sqlDataReader.GetInt32(3);
                ExamDAO examDAO = new ExamDAO(this.Connection);
                Exam exam = examDAO.findById(examId);
                questionOuverte.Exam = exam;
            }
            Connection.Close();
            return questionOuverte;
        }
    }

    public override List<QuestionOuverte> findAll()
    {
        List<QuestionOuverte> questionOuvertes = new List<QuestionOuverte>();
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, this.Connection);
            command.CommandText = GET_ALL;
            command.Prepare();
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                QuestionOuverte questionOuverte = new QuestionOuverte();
                questionOuverte.QuestionId = sqlDataReader.GetInt32(0);
                questionOuverte.Enonce = sqlDataReader.GetString(1);
                questionOuverte.Reponse = sqlDataReader.GetString(2);
                long examId = sqlDataReader.GetInt32(3);
                ExamDAO examDAO = new ExamDAO(this.Connection);
                Exam exam = examDAO.findById(examId);
                questionOuverte.Exam = exam;

                questionOuvertes.Add(questionOuverte);
            }
            Connection.Close();
            return questionOuvertes;
        }
    }

    public override QuestionOuverte update(QuestionOuverte dto)
    {
        throw new NotImplementedException();
    }

    public override QuestionOuverte create(QuestionOuverte dto)
    {
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null,this.Connection);
            command.CommandText = INSERT;
            SqlParameter enonceQcmParameter = new SqlParameter("@enonce", SqlDbType.VarChar, -1);
            SqlParameter examIdQcmParameter = new SqlParameter("@examId", SqlDbType.Int);

            enonceQcmParameter.Value = dto.Enonce;
            examIdQcmParameter.Value = dto.Exam.ExamId;

            command.Parameters.Add(enonceQcmParameter);
            command.Parameters.Add(examIdQcmParameter);

            command.Prepare();
            int id = (int)command.ExecuteScalar();
            Connection.Close();

            //long id = getLastVal(LAST_VAL);
            dto.QuestionId = id;
            return dto;
        }
    }

    public override void delete(long id)
    {
        throw new NotImplementedException();
    }
}
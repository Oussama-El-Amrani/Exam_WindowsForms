using System.Data;
using System.Data.SqlClient;
using Exam_WindowsForms.Model;
using Exam_WindowsForms.Persistence.util;

namespace Exam_WindowsForms.Persistence;

public class QuestionChoixMultipleDAO : DataAccessObject<QuestionChoixMultiple>
{
    private static readonly string GET_ONE =
        "SELECT QCM.enonce,QCM.nombrePoint, " +
        "QCM.questionId,p.propositionId " +
        "examId " +
        "FROM QuestionChoixMultiple AS QCM, " +
        "Proposition AS p " +
        "WHERE QCM.questionId = @qcmId " +
        "AND QCM.questionId = p.questionId ";

    private static readonly string GET_ALL =
        "SELECT QCM.enonce,QCM.nombrePoint, " +
        "QCM.questionId,p.propositionId " +
        "examId " +
        "FROM QuestionChoixMultiple AS QCM, " +
        "Proposition AS p " +
        "WHERE QCM.questionId = p.questionId ";
    private static readonly string INSERT =
        "INSERT INTO Poposition(vrai,Contenu,questionId) " +
        "VALUES(@vrai,@Contenu,@questionId)";
    private static readonly string LAST_VAL =
        "SELECT questionId " +
        "FROM QuestionChoixMultiple " +
        "WHERE questionId = @@Identity";

    public QuestionChoixMultipleDAO(SqlConnection cnx) : base(cnx)
    {
    }

    public override QuestionChoixMultiple findById(long id)
    {
        QuestionChoixMultiple qcm = new QuestionChoixMultiple();
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, this.Connection);
            command.CommandText = GET_ONE;
            SqlParameter qcmIdParameter = new SqlParameter("@qcmId", SqlDbType.Int);
            qcmIdParameter.Value = id;
            command.Parameters.Add(qcmIdParameter);
            command.Prepare();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            long qcmId = 0;
            List<Proposition> propositions= new List<Proposition>();
            while (sqlDataReader.Read())
            {
                if (qcmId == 0)
                {
                    qcmId = sqlDataReader.GetInt32(2);
                    qcm.QuestionId = qcmId;
                    qcm.Enonce = sqlDataReader.GetString(0);
                    qcm.nombrePoint = sqlDataReader.GetInt32(1);
                    long examId = sqlDataReader.GetInt32(4);
                    ExamDAO examDAO = new ExamDAO(this.Connection);
                    qcm.Exam = examDAO.findById(examId);
                    qcm.propositions = propositions;
                }

                long propositionId = sqlDataReader.GetInt32(3);
                PropositionDAO propositionDAO = new PropositionDAO(this.Connection);
                Proposition proposition = propositionDAO.findById(propositionId);
                propositions.Add(proposition);
            }
            Connection.Close();
            return qcm;
        }
    }

    public override List<QuestionChoixMultiple> findAll()
    {
        List<QuestionChoixMultiple> qcms = new List<QuestionChoixMultiple>();
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, this.Connection);
            command.CommandText = GET_ALL;
            command.Prepare();
            SqlDataReader sqlDataReader = command.ExecuteReader();
            long qcmId = 0;
            QuestionChoixMultiple qcm = null;
            while (sqlDataReader.Read())
            {
                long localQcm = sqlDataReader.GetInt32(2);
                if (localQcm != qcmId)
                {
                    qcm = new QuestionChoixMultiple();
                    qcms.Add(qcm);
                    qcmId = localQcm;
                    qcm.QuestionId = qcmId;
                    qcm.Enonce = sqlDataReader.GetString(0);
                    qcm.nombrePoint = sqlDataReader.GetInt32(1);
                    long examId = sqlDataReader.GetInt32(4);
                    ExamDAO examDAO = new ExamDAO(this.Connection);
                    qcm.Exam = examDAO.findById(examId);

                    List<Proposition> propositions = new List<Proposition>();
                    qcm.propositions = propositions;
                }

                long propositionId = sqlDataReader.GetInt32(3);
                PropositionDAO propositionDao = new PropositionDAO(this.Connection);
                Proposition proposition = propositionDao.findById(propositionId);
                
                qcm.propositions.Add(proposition);
            }

            return qcms;
        }
    }

    public override QuestionChoixMultiple update(QuestionChoixMultiple dto)
    {
        throw new NotImplementedException();
    }

    public override QuestionChoixMultiple create(QuestionChoixMultiple dto)
    {
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = INSERT;
            SqlParameter enonceQcmParameter = new SqlParameter("@enonce",SqlDbType.VarChar,-1);
            SqlParameter nombrePoint = new SqlParameter("@nombrePoint", SqlDbType.Int);
            SqlParameter examIdQcmParameter = new SqlParameter("@examId", SqlDbType.Int);

            enonceQcmParameter.Value = dto.Enonce;
            nombrePoint.Value = dto.nombrePoint;
            examIdQcmParameter.Value = dto.Exam.ExamId;

            command.Parameters.Add(enonceQcmParameter);
            command.Parameters.Add(nombrePoint);
            command.Parameters.Add(examIdQcmParameter);

            command.Prepare();
            command.ExecuteNonQuery();
            Connection.Close();

            long id = getLastVal(LAST_VAL);
            return findById(id);
        }
    }

    public override void delete(long id)
    {
        throw new NotImplementedException();
    }
}
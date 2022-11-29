using System.Data;
using System.Data.SqlClient;
using Exam_WindowsForms.Model;
using Exam_WindowsForms.Persistence.util;

namespace Exam_WindowsForms.Persistence;

public class PropositionDAO : DataAccessObject<Proposition>
{
    private static readonly string INSERT =
        @"INSERT INTO Poposition(vrai,Contenu,questionId)
        VALUES(@vrai,@Contenu,@questionId);
         SELECT CAST(SCOPE_IDENTITY() AS int);";

    private static readonly string GET_ONE =
        "SELECT vrai,Contenu,QCM.questionId,propositionId " +
        "FROM QuestionChoixMultiple AS QCM,Proposition AS p " +
        "WHERE p.questionId = @propositionId  " +
        "AND p.questionId = QCM.questionId";
    private static readonly string GET_ALL =
        "SELECT vrai,Contenu,QCM.questionId,propositionId " +
        "FROM QuestionChoixMultiple AS QCM,Proposition AS p " +
        "WHERE p.questionId = QCM.questionId";

    //private static readonly string LAST_VAL =
    //    "SELECT propositionId " +
    //    "FROM proposition " +
    //    "WHERE propositionId = @@Identity";
    public PropositionDAO(SqlConnection cnx) : base(cnx)
    {
    }

    public override Proposition findById(long id)
    {
        Proposition proposition = new Proposition();
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, this.Connection);
            command.CommandText = GET_ONE;
            SqlParameter propositionIdParameter = new SqlParameter("@propositionId", SqlDbType.Int);
            propositionIdParameter.Value = id;
            command.Parameters.Add(propositionIdParameter);
            command.Prepare();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                proposition.Contenu = sqlDataReader.GetString(1);
                proposition.Vrai = sqlDataReader.GetBoolean(0);
                proposition.PropositionId = sqlDataReader.GetInt32(3);

                long qcmId = sqlDataReader.GetInt32(2);
                QuestionChoixMultipleDAO qcmDAO = new QuestionChoixMultipleDAO(this.Connection);
                QuestionChoixMultiple qcm = qcmDAO.findById(qcmId);

                proposition.QCM = qcm;
            }
            Connection.Close();
            return proposition;
        }
    }

    public override List<Proposition> findAll()
    {
        List<Proposition> propositions = new List<Proposition>();
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, this.Connection);
            command.CommandText = GET_ALL;
            command.Prepare();
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Proposition proposition = new Proposition();
                proposition.Contenu = sqlDataReader.GetString(1);
                proposition.Vrai = sqlDataReader.GetBoolean(0);
                proposition.PropositionId = sqlDataReader.GetInt32(3);

                long qcmId = sqlDataReader.GetInt32(2);
                QuestionChoixMultipleDAO qcmDAO = new QuestionChoixMultipleDAO(this.Connection);
                QuestionChoixMultiple qcm = qcmDAO.findById(qcmId);

                proposition.QCM = qcm;
                propositions.Add(proposition);
            }
            Connection.Close();
            return propositions;
        }
    }

    public override Proposition update(Proposition dto)
    {
        throw new NotImplementedException();
    }

    public override Proposition create(Proposition dto)
    {
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, this.Connection);
            command.CommandText = INSERT;

            SqlParameter vraiPropositionParameter = new SqlParameter("@vrai", SqlDbType.Bit);
            SqlParameter contenuPropositionParameter = new SqlParameter("@Contenu", SqlDbType.VarChar, -1);
            SqlParameter questionIdParameter = new SqlParameter("@questionId", SqlDbType.Int);

            vraiPropositionParameter.Value = dto.Vrai;
            contenuPropositionParameter.Value = dto.Contenu;
            questionIdParameter.Value = dto.QCM.QuestionId;

            command.Parameters.Add(vraiPropositionParameter);
            command.Parameters.Add(contenuPropositionParameter);
            command.Parameters.Add(questionIdParameter);

            command.Prepare();
            int id = (int)command.ExecuteScalar();
            Connection.Close();
            //long id = getLastVal(LAST_VAL);
            dto.PropositionId = id;
            return dto;
        }
    }

    public override void delete(long id)
    {
        throw new NotImplementedException();
    }
}
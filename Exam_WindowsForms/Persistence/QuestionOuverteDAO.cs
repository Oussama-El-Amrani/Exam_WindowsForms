using System.Data.SqlClient;
using Exam_WindowsForms.Model;
using Exam_WindowsForms.Persistence.util;

namespace Exam_WindowsForms.Persistence;

public class QuestionOuverteDAO : DataAccessObject<QuestionOuverte>
{
    public QuestionOuverteDAO(SqlConnection cnx) : base(cnx)
    {
    }

    public override QuestionOuverte findById(long id)
    {
        throw new NotImplementedException();
    }

    public override List<QuestionOuverte> findAll(long id)
    {
        throw new NotImplementedException();
    }

    public override QuestionOuverte update(QuestionOuverte dto)
    {
        throw new NotImplementedException();
    }

    public override QuestionOuverte create(QuestionOuverte dto)
    {
        throw new NotImplementedException();
    }

    public override void delete(long id)
    {
        throw new NotImplementedException();
    }
}
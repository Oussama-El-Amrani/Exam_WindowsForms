using System.Data.SqlClient;
using Exam_WindowsForms.Model;
using Exam_WindowsForms.Persistence.util;

namespace Exam_WindowsForms.Persistence;

public class EtudiantDAO : DataAccessObject<Etudiant>
{
    public EtudiantDAO(SqlConnection cnx) : base(cnx)
    {
    }

    public override Etudiant findById(long id)
    {
        throw new NotImplementedException();
    }

    public override List<Etudiant> findAll()
    {
        throw new NotImplementedException();
    }

    public override Etudiant update(Etudiant dto)
    {
        throw new NotImplementedException();
    }

    public override Etudiant create(Etudiant dto)
    {
        throw new NotImplementedException();
    }

    public override void delete(long id)
    {
        throw new NotImplementedException();
    }
}
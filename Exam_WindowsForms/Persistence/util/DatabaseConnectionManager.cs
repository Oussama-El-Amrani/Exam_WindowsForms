using System.CodeDom;
using System.Data.SqlClient;

namespace Exam_WindowsForms.Persistence.util;

public class DatabaseConnectionManager
{
    private const string chaine
        = @"Data Source=DESKTOP-TDEF4LS;Initial Catalog=Exam;Integrated Security=True";

    private static SqlConnection cnx;

    public DatabaseConnectionManager()
    {
        cnx = new SqlConnection(chaine);
    }

    public SqlConnection getConnection()
    {
        return cnx;
    }

}
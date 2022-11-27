using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Exam_WindowsForms.Persistence.util;

public abstract class DataAccessObject <T> : DataTransferObject
{
    protected SqlConnection Connection{get; set; }

    protected DataAccessObject(SqlConnection cnx)
    {
        this.Connection = cnx;
    }

    public abstract T findById(long id);
    public abstract List<T> findAll();
    public abstract T update(T dto);
    public abstract T create(T dto);
    public abstract void delete(long id);

    protected long getLastVal(String lastVal)
    {
        long key = 0;
        using (this.Connection)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(null, Connection);
            command.CommandText = lastVal;
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    key = (long)sqlDataReader[0];
                }
            }
            Connection.Close();
        }
        return key;
    }
    
}
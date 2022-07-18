using System.Data.SqlClient;

namespace Funcionarios.Models.Contracts.Repositories
{
    public interface IConnectionManager
    {
        SqlConnection GetConnection();
    }
}

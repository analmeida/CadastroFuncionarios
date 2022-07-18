using Funcionarios.Models.Contracts.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace Funcionarios.Models.Contexts
{
    public class ConnectionManager : IConnectionManager
    {
        private static string _connectionName = "Funcionarios";
        private static SqlConnection connection = null;

        public ConnectionManager(IConfiguration configuration)
        {
            var connStr = configuration.GetConnectionString(_connectionName);
            if (connection == null)
                connection = new SqlConnection(connStr);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}

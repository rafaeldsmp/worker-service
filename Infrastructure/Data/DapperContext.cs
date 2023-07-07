using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace WorkerSample.Infrastructure.Data
{
    public class DapperContext : IDisposable
    {
        public IDbConnection eletronicos_user { get; }
        public IDbConnection eletronicos_datalake { get; }

        public DapperContext(IConfiguration configuration)
        {
            eletronicos_user = new SqlConnection(configuration.GetConnectionString("eletronicos_user"));
            eletronicos_datalake = new SqlConnection(configuration.GetConnectionString("eletronicos_datalake"));
        }

        public void Dispose()
        {
            eletronicos_user?.Dispose();
            eletronicos_datalake?.Dispose();
        }
    }
}

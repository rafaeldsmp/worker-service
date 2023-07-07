
using Dapper;
using System.Data;
using WorkerSample.Domain.IRepository;
using WorkerSample.Domain.Model;
using WorkerSample.Infrastructure.Data;

namespace WorkerSample.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        public readonly DapperContext _dapper;
        public ProductRepository(DapperContext dapper)
        {
            _dapper= dapper;
        }

        public List<Product> ClearDataEletronicosDatalake()
        {
            var connection = _dapper.eletronicos_datalake;
            {
                connection.Open();
                string query = string.Format(Resource.DeleteData);
                List<Product> product = (connection.Query<Product>(sql: query)).ToList();
                return product;
            }
        }

        public List<Product> SelectProdutoEletronicosUser()
        {
            var connection = _dapper.eletronicos_user;
            string query = string.Format(Resource.SelectEletronicosUser);
            List<Product> product = (connection.Query<Product>(sql: query)).ToList();
            return product;
        }

        public List<Product> InsertDataEletronicosDatalake(List<Product> product)
        {
            var connection = _dapper.eletronicos_datalake;
            string query = string.Format(Resource.InsertDatalake);
            connection.Execute(sql:query, param:product);
            return product;
        }
    }
}

using WorkerSample.Domain.Model;

namespace WorkerSample.Domain.IRepository
{
    public interface IProductRepository
    {
        List<Product> SelectProdutoEletronicosUser();
        List<Product> InsertDataEletronicosDatalake(List<Product> product);
        List<Product> ClearDataEletronicosDatalake();
    }
}

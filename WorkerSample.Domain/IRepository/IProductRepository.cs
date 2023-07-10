using WorkerSample.Domain.Model;

namespace WorkerSample.Domain.IRepository
{
    public interface IProductRepository
    {
        List<Product> SelectProductEletronicosUser();
        List<Product> InsertDataEletronicosDatalake(List<Product> product);
        List<Product> ClearDataEletronicosDatalake();
    }
}

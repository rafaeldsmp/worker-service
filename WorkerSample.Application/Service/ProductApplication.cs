using Application.IService;
using NLog;
using WorkerSample.Domain.IRepository;

namespace Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;
        private readonly NLog.Logger _logger;

        public ProductApplication(IProductRepository productRepository, Logger logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public void GetAllEletronicosUserAndInsert()
        {
            try
            {
                _logger.Info("Deleting old table data on [estoque].[eletronicos] on eletronicos_datalake. ");
                _productRepository.ClearDataEletronicosDatalake();
                _logger.Info("deleted data.");

                _logger.Info("Extract new datas on table [estoque].[eletronicos] on eletronicos_user.");
                var eletronic = _productRepository.SelectProductEletronicosUser();
                _logger.Info(@"{} New extracted data.", eletronic.Count);

                _logger.Info("Insert new data on table [estoque].[eletronicos] on eletronicos_datalake.");
                _productRepository.InsertDataEletronicosDatalake(eletronic);
                _logger.Info("Inserting new datas.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Operation error.");
            }
        }
    }
}

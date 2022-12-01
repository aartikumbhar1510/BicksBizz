using bricksnetcoreapi.Models;

namespace bricksnetcoreapi.Repository
{
    public class ProductionRepository : IProductionRepository
    {
        public Task<ProductionModel> GetProductionDetailByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}

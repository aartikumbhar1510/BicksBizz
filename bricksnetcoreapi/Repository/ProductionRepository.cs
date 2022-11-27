using bricksnetcoreapi.Model;

namespace bricksnetcoreapi.Repository
{
    public class ProductionRepository : IProductionRepository
    {
        public Task<ProductionDetail> GetProductionDetailByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}

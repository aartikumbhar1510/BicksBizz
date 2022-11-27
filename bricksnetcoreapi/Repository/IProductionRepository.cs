using bricksnetcoreapi.Model;

namespace bricksnetcoreapi.Repository
{
    public interface IProductionRepository
    {
        Task<ProductionDetail> GetProductionDetailByCode(string code);
    }
}

using bricksnetcoreapi.Models;

namespace bricksnetcoreapi.Repository
{
    public interface IProductionRepository
    {
        Task<ProductionModel> GetProductionDetailByCode(string code);
    }
}

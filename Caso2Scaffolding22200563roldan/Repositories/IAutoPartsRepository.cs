using Caso2Scaffolding22200563roldan.Models;

namespace Caso2Scaffolding22200563roldan.Repositories
{
    public interface IAutoPartsRepository
    {
        Task<IEnumerable<AutoParts>> GetAllAutoPartsAsync();
        Task<AutoParts> GetAutoPartByIdAsync(int id);
        Task AddAutoPartAsync(AutoParts autoPart);
        Task UpdateAutoPartAsync(AutoParts autoPart);
        Task DeleteAutoPartAsync(int id);
    }

}

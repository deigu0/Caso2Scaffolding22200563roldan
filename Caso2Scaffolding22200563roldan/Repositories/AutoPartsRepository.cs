using Caso2Scaffolding22200563roldan.Models;

namespace Caso2Scaffolding22200563roldan.Repositories
{
    public class AutoPartsRepository
    {
        private readonly ParcialDbContext _context;

        public AutoPartsRepository(ParcialDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AutoParts>> GetAllAutoPartsAsync()
        {
            return await _context.AutoParts.ToListAsync();
        }

        public async Task<AutoParts> GetAutoPartByIdAsync(int id)
        {
            return await _context.AutoParts.FindAsync(id);
        }

        public async Task AddAutoPartAsync(AutoParts autoPart)
        {
            await _context.AutoParts.AddAsync(autoPart);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAutoPartAsync(AutoParts autoPart)
        {
            _context.AutoParts.Update(autoPart);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAutoPartAsync(int id)
        {
            var autoPart = await _context.AutoParts.FindAsync(id);
            if (autoPart != null)
            {
                _context.AutoParts.Remove(autoPart);
                await _context.SaveChangesAsync();
            }
        }
    }

}

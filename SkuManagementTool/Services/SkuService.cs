using Microsoft.EntityFrameworkCore;
using SkuManagementTool.Data;
using SkuManagementTool.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkuManagementTool.Services
{
    public class SkuService
    {
        // Service for managing SKU operations
        private readonly ApplicationDbContext _context;
       
        // Constructor injecting the database context.
        public SkuService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Retrieves all active SKUs.
        public async Task<List<Sku>> GetActiveSkusAsync()
        {
            return await _context.Skus.Where(s => s.IsActive).ToListAsync();
        }
        
        // Retrieves all deactivated SKUs.
        public async Task<List<Sku>> GetDeactivatedSkusAsync()
        {
            return await _context.Skus.Where(s => !s.IsActive).ToListAsync();
        }

        // Retrieves a SKU by its ID.
        public async Task<Sku> GetSkuByIdAsync(int id)
        {
            return await _context.Skus.FindAsync(id);
        }

        // Adds a new SKU to the database.
        public async Task AddSkuAsync(Sku sku)
        {
            _context.Skus.Add(sku);
            await _context.SaveChangesAsync();
        }

        // Updates an existing SKU.
        public async Task UpdateSkuAsync(Sku sku)
        {
            _context.Skus.Update(sku);
            await _context.SaveChangesAsync();
        }

        // Deactivates a SKU by setting its IsActive flag to false.
        public async Task DeactivateSkuAsync(int id)
        {
            var sku = await _context.Skus.FindAsync(id);
            if (sku != null)
            {
                sku.IsActive = false;
                await _context.SaveChangesAsync();
            }
        }

        // Reactivates a SKU by setting its IsActive flag to true.
        public async Task ReactivateSkuAsync(int id)
        {
            var sku = await _context.Skus.FindAsync(id);
            if (sku != null)
            {
                sku.IsActive = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}

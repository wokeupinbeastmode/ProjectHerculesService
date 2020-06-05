using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectHerculesService.Data.Models;
using ProjectHerculesService.Models;
using ProjectHerculesService.Repository.Extensions;
using ProjectHerculesService.Repository.Interface;

namespace ProjectHerculesService.Repository.Implementation
{
    public class SalesTypeRepository : ISalesTypeRepository
    {
        private readonly IContextContainer _context;

        public SalesTypeRepository(IContextContainer context)
        {
            _context = context;
        }

        public async Task<SalesTypesModel> GetSalesTypeAsync(int id)
        {
            SalesTypesModel result;

            using (var context = _context.GetHerculesServiceContextInstance())
            {
                SalesTypes salesType = new SalesTypes();

                salesType = await context.SalesTypes.FindAsync(id);

                result = salesType.ToModel();
            }

            return result;
        }

        public async Task<SalesTypesModel> CreateSalesTypeAsync(SalesTypesModel model)
        {
            SalesTypesModel result;

            using (var context = _context.GetHerculesServiceContextInstance())
            {
                SalesTypes domain = model.ToDomain();

                await context.SalesTypes.AddAsync(domain);
                await context.SaveChangesAsync();

                result = domain.ToModel();
            }

            return result;
        }

        public async Task<List<SalesTypesModel>> GetSalesTypesAsync()
        {
            List<SalesTypesModel> result;

            using (var context = _context.GetHerculesServiceContextInstance())
            {
                List<SalesTypes> salesTypes = new List<SalesTypes>();
                salesTypes = await context.SalesTypes.ToListAsync();

                result = salesTypes.ToModel();
            }

            return result;
        }
    }
}
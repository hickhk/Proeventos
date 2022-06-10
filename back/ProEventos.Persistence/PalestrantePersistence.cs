using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Model;
using ProEventos.Persistence.Contextos;

namespace ProEventos.Persistence
{
    public class PalestrantePersistence : IPalestrantePersistence
    {
        private readonly ProEventoContext _context;

        public async Task<Palestrante> GetPalestranteByIdAsync(int id, bool includeEvento = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.AsNoTracking()
             .Include(p => p.RedesSociais);

            query.OrderBy(p => p.Id);

            if(includeEvento){
              query
              .Include(p => p.PalestrantesEventos)
              .ThenInclude(p => p.Evento);
            }
            
            query.Where(
                p => p.Id == id);

            return await query.FirstAsync();
        }
        public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEvento)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.AsNoTracking()
             .Include(p => p.RedesSociais);

            query.OrderBy(p => p.Id);

            if(includeEvento){
              query
              .Include(p => p.PalestrantesEventos)
              .ThenInclude(p => p.Evento);
            }
            
            query.Where(
                p => p.Nome.ToLower()
                .Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsync(string nome, bool includeEvento = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.AsNoTracking()
            .Include(p => p.RedesSociais);

            query.OrderBy(p => p.Id);

            if(includeEvento){
              query
              .Include(p => p.PalestrantesEventos)
              .ThenInclude(p => p.Evento);
            }

            return await query.ToArrayAsync();
        }
    }
}
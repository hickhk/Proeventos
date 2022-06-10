using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Model;
using ProEventos.Persistence.Contextos;
using ProEventos.Persistence.Interfaces;

namespace ProEventos.Persistence
{
    public class EventosPersistence : IEventosPersistence
    {
        private readonly ProEventoContext _context;

        public EventosPersistence(ProEventoContext context)
        {
            _context = context;
            //_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        
        public async Task<Evento> GetEventoByIdAsync(int id, bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos.AsNoTracking()
            .Include(e => e.Lotes)
            .Include(e => e.RedesSociais).Where(ev => ev.Id == id );

            query.OrderBy(e => e.Id);

            if(includePalestrantes){
              query
              .Include(e => e.PalestrantesEventos)
              .ThenInclude(e => e.Palestrante);
            }
            
            query.Where(
                e => e.Id == id);

            return await query.FirstAsync();
        }

        public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos.AsNoTracking()
            .Include(e => e.Lotes)
            .Include(e => e.RedesSociais).Where(ev => ev.Tema.ToLower().Contains(tema.ToLower()));

            query.OrderBy(e => e.Id);

            if(includePalestrantes){
              query
              .Include(e => e.PalestrantesEventos)
              .ThenInclude(e => e.Palestrante);
            }
            
            query.Where(
                e => e.Tema.ToLower()
                .Contains(tema.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos.AsNoTracking()
            .Include(e => e.Lotes)
            .Include(e => e.RedesSociais);

            query.OrderBy(e => e.Id);

            if(includePalestrantes){
              query
              .Include(e => e.PalestrantesEventos)
              .ThenInclude(e => e.Palestrante);
            }

            return await query.ToArrayAsync();
             
        }
    }
}
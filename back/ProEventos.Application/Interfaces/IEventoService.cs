using ProEventos.Domain.Model;
using System.Threading.Tasks;

namespace ProEventos.Application.Interfaces
{
    public interface IEventoService
    {
         Task<Evento> AddEvento(Evento model);
         Task<Evento> UpdateEvento(int id, Evento model);
         Task<bool> DeleteEvento(int id);

         Task<Evento> GetEventoByIdAsync(int id, bool includePalestrantes);
         Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
         Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
    }
}
using System.Threading.Tasks;
using ProEventos.Domain.Model;

namespace ProEventos.Persistence
{
    public interface IPalestrantePersistence
    {
         Task<Palestrante> GetPalestranteByIdAsync(int id, bool includeEvento);
         Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEvento);
         Task<Palestrante[]> GetAllPalestrantesAsync(string nome, bool includeEvento);
    }
}
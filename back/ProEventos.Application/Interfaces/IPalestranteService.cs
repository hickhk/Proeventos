using ProEventos.Domain.Model;
using System.Threading.Tasks;

namespace ProEPalestrantes.Application.Interfaces
{
    public interface IPalestranteService
    {
        Task<Palestrante> AddEPalestrante(Palestrante model);
         Task<Palestrante> UpdateEPalestrante(int id, Palestrante model);
         Task<bool> DeleteEPalestrante(int id);

         Task<Palestrante> GetEPalestranteByIdAsync(int id, bool includePalestrantes);
         Task<Palestrante[]> GetAllEPalestrantesByNomeAsync(string tema, bool includePalestrantes);
         Task<Palestrante[]> GetAllEPalestrantesAsync(bool includePalestrantes); 
    }
}
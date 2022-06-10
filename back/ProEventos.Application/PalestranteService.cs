using ProEPalestrantes.Application.Interfaces;
using ProEventos.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application
{
    public class PalestranteService : IPalestranteService
    {
        public Task<Palestrante> AddEPalestrante(Palestrante model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEPalestrante(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllEPalestrantesAsync(bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllEPalestrantesByNomeAsync(string tema, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> GetEPalestranteByIdAsync(int id, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> UpdateEPalestrante(int id, Palestrante model)
        {
            throw new NotImplementedException();
        }
    }
}

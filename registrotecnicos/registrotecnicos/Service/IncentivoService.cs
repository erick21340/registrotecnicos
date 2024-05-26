using Microsoft.EntityFrameworkCore;
using registrotecnicos.DAL;
using registrotecnicos.Models;
using System.Linq.Expressions;

namespace registrotecnicos.Service
{
    public class IncentivoService
    {
        private readonly contexto _contexto;

        public IncentivoService(contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Guardar(Incentivos incentivo)
        {
            try
            {
                _contexto.incentivosTecnicos.Add(incentivo);
                await _contexto.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                // Manejar el error
                return false;
            }
        }

        public async Task<List<Incentivos>> Listar(Expression<Func<Incentivos, bool>> criterio)
        {
            return await _contexto.incentivosTecnicos.Where(criterio).ToListAsync();
        }

        public async Task<bool> Modificar(Incentivos incentivo)
        {
            try
            {
                _contexto.Entry(incentivo).State = EntityState.Modified;
                await _contexto.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                // Manejar el error
                return false;
            }
        }

        public async Task<bool> Eliminar(int incentivoId)
        {
            try
            {
                var incentivo = await _contexto.incentivosTecnicos.FindAsync(incentivoId);
                if (incentivo != null)
                {
                    _contexto.incentivosTecnicos.Remove(incentivo);
                    await _contexto.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                // Manejar el error
                return false;
            }
        }

        public async Task<Incentivos> Buscar(int incentivoId)
        {
            return await _contexto.incentivosTecnicos.FindAsync(incentivoId);
        }
    }

}


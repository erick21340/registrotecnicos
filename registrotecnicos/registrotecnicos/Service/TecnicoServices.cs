using Microsoft.EntityFrameworkCore;
using registrotecnicos.DAL;
using registrotecnicos.Models;
using System.Linq.Expressions;

namespace registrotecnicos.Service
{
    public class TecnicoServices
    {
        private readonly contexto _contexto;

        public TecnicoServices(contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Existe(int id)
        {
            return await _contexto.Tecnicos.AnyAsync(t => t.TecnicoId == id);
        }

        public async Task<bool> Insertar(Tecnicos tecnico)
        {
            _contexto.Tecnicos.Add(tecnico);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Modificar(Tecnicos tecnico)
        {
            _contexto.Tecnicos.Update(tecnico);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Crear(Tecnicos tecnico)
        {
            if (!await Existe(tecnico.TecnicoId))
                return await Insertar(tecnico);
            else
                return await Modificar(tecnico);
        }

        public async Task<bool> Eliminar(int id)
        {
            var Tecnicos = await _contexto.Tecnicos.
                Where(t => t.TecnicoId == id).ExecuteDeleteAsync();
            return Tecnicos > 0;
        }

        public async Task<Tecnicos?> Buscar(int id)
        {
            return await _contexto.Tecnicos.AsNoTracking().
                FirstOrDefaultAsync(t => t.TecnicoId == id);
        }

        public async Task<List<Tecnicos>> Listar(Expression<Func<Tecnicos, bool>> criterio)
        {
            return _contexto.Tecnicos.
                AsNoTracking()
                .Where(criterio)
                .ToList();
        }
        public async Task<bool> Guardar(Tecnicos tecnicos)
        {
            if (!await Existe(tecnicos.TecnicoId))
            {
                return await Insertar(tecnicos);
            }
            else
            {
                return await Modificar(tecnicos);
            }
        }

    }
}

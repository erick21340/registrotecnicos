using Microsoft.EntityFrameworkCore;
using registrotecnicos.Models;

namespace registrotecnicos.DAL
{
    public class contexto :DbContext
    {
        public contexto(DbContextOptions<contexto>options) 
        :base(options) { }

        public DbSet<Tecnicos> Tecnicos { get; set;}

        public DbSet<Incentivos> incentivosTecnicos { get; set; }
    }
}

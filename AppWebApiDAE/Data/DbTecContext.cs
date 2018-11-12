using Microsoft.EntityFrameworkCore;
using AppWebApiDAE.Models;

namespace AppWebApiDAE.Data
{
    public class DbTecContext : DbContext
    {
        public DbTecContext(DbContextOptions<DbTecContext> options)
            : base(options)
        {
        }

        public DbSet<Eva_cat_edificios> eva_Cat_Edificios { get; set; }
        public DbSet<Eva_cat_espacios> eva_Cat_Espacios { get; set; }
        public DbSet<Eva_cat_tipo_competencia> eva_Cat_Tipo_Competencia { get; set; }
        public DbSet<Eva_cat_competencias> eva_Cat_Competencias { get; set; }
        public DbSet<Eva_cat_conocimientos> eva_Cat_Conocimientos { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class OgameTrackerContext : DbContext
    {

        public OgameTrackerContext(DbContextOptions<OgameTrackerContext> options) : base(options)
        {


        }





        public DbSet<Planeta> Planetas { get; set; }
        public DbSet<Edificio> Edificios { get; set; }

    }
}

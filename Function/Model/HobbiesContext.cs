using Microsoft.EntityFrameworkCore;

namespace Function.Model
{
    public class HobbiesContext : DbContext
    {
        public HobbiesContext(DbContextOptions<HobbiesContext> context) : base(context) { }
        public HobbiesContext() { }
        public DbSet<Hobby> Hobbies {get;set;}
    }
}
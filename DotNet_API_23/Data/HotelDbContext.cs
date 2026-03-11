using DotNet_API_23.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_API_23.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext (DbContextOptions<HotelDbContext> options):base(options) { }

        public DbSet<Hotel> Hotels => Set<Hotel>();
    }
}

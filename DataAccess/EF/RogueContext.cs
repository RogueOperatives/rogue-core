using Microsoft.EntityFrameworkCore;
using Rogue.Contracts;

namespace Rogue.DataAccess.EF
{
    public class RogueContext : DbContext
    {
        public DbSet<Unit> Units { get; set; }
    }
}

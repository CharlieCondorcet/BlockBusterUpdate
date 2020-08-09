using Microsoft.EntityFrameworkCore;

/// <summary>
/// Namespace to db.
/// </summary>
namespace Blockbuster.Data
{
    /// <summary>
    /// Implementation to DbContext from ORM.
    /// </summary>
    public class BlockbusterContext : DbContext
    {
        public BlockbusterContext(
            DbContextOptions<BlockbusterContext> options)
            : base(options)
        {
        }

        public DbSet<Blockbuster.Models.Movie> Movie { get; set; }
    }
}
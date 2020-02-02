using System.ComponentModel.Composition;
using Demo2.Models;
using Demo2.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Demo2
{
    [Export("EF", typeof(DbContext))]
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }

        private string connection;
        public DataContext(string connection)
        {
            this.connection = connection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrWhiteSpace(connection))
            {
                optionsBuilder.UseMySQL(connection);
            }
        }

        public DbSet<Movie> movies { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<MainUser> MainUserss { get; set; }
        public DbSet<RecipeType> RecipeTypes { get; set; }
        public DbSet<DinnerTable> DinnerTables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderRecipe> OrderRecipes { get; set; }
        public DbSet<UploadFile> Files { get; set; }
        public DbSet<PaceType> PaceTypes { get; set; }
    }
}
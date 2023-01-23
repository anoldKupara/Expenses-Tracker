using Microsoft.EntityFrameworkCore;

namespace Expenses_Tracker.DbContexts
{
    public class ExpenseTrackerDbContext : DbContext
    {
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ExpenseTracker;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
using Expenses_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Expenses_Tracker.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ANOLD-KUPARA;Initial Catalog=ExpensesDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
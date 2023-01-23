namespace Expenses_Tracker.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Budget> Budgets { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}

using FamilyBudgetSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudgetSystem.DAL
{
    public class FamilyBudgetSystemDataContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}

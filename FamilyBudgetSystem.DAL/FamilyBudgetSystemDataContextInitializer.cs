using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyBudgetSystem.Core.Models;

namespace FamilyBudgetSystem.DAL
{
    public class FamilyBudgetSystemDataContextInitializer : DropCreateDatabaseAlways<FamilyBudgetSystemDataContext>
    {
        protected override void Seed(FamilyBudgetSystemDataContext context)
        {
            Expense expense = new Expense() { ExpenseName = "Кафе", ExpenseAmount = decimal.Parse("25"), ExpenseDate = DateTime.Parse("01.01.20")};
            context.Expenses.Add(expense);

            Income income = new Income() { IncomeName = "Заплата", IncomeAmount = decimal.Parse("250"), IncomeDate = DateTime.Parse("01.02.20")};
            context.Incomes.Add(income);

            Account account = new Account() {Ballance = decimal.Parse("100") };
            context.Accounts.Add(account);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}

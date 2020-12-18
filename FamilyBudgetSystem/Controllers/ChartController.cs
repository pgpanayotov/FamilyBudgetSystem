using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FamilyBudgetSystem.DAL;
using FamilyBudgetSystem.Models;

namespace FamilyBudgetSystem.Controllers
{
    public class ChartController : Controller
    {
        private FamilyBudgetSystemDataContext db = new FamilyBudgetSystemDataContext();
        // GET: Chart
        public ActionResult Index()
        {
            decimal incomeSum = 0;
            decimal expenseSum = 0;
            if (db.Expenses.Count() != 0)
            {
                expenseSum = db.Expenses.Sum(e => e.ExpenseAmount);
            }
            if (db.Incomes.Count() != 0)
            {
            incomeSum = db.Incomes.Sum(i => i.IncomeAmount);
            }
            
            ChartVM viewModel = new ChartVM();
            viewModel.Incomes = incomeSum;
            viewModel.Expenses = expenseSum;
            return View(viewModel);
        }
    }
}
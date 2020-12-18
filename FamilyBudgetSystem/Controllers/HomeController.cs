using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using FamilyBudgetSystem.Core.Models;
using FamilyBudgetSystem.DAL;
using FamilyBudgetSystem.Models;

namespace FamilyBudgetSystem.Controllers
{
    public class HomeController : Controller
    {
        private FamilyBudgetSystemDataContext db = new FamilyBudgetSystemDataContext();

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

            decimal ballance = incomeSum - expenseSum;

            HomeVM viewModel = new HomeVM();
            viewModel.Ballance = ballance;

            return View(viewModel);
        }
    }
}
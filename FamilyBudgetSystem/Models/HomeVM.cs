using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace FamilyBudgetSystem.Models
{
    public class HomeVM
    {
        [DisplayName("Налични пари")] 
        public decimal Ballance { get; set; }
        [DisplayName("Общо приходи")]
        public decimal Incomes { get; set; }
        [DisplayName("Общо разходи")]
        public decimal Expenses { get; set; }
    }

}
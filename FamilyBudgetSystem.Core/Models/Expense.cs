using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudgetSystem.Core.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        [Required()]
        [StringLength(200, MinimumLength = 2)]
        public string ExpenseName { get; set; }
        [Required()]
        [DataType(DataType.Currency)]
        public decimal ExpenseAmount { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime ExpenseDate { get; set; } = DateTime.Now;

        //public int UserID { get; set; }
        //public virtual User User { get; set; }
    }
}

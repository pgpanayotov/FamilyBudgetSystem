using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudgetSystem.Core.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        [DataType(DataType.Currency)]
        public decimal Ballance { get; set; }
    }
}

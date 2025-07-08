using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Form.Models
{
    public class Finance
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public decimal SalaryPercent { get; set; }
        public decimal BalanceAfter { get; set; }
        public bool IsCredit { get; set; }
        public bool IsDebit { get; set; }

        public int TypeId { get; set; }
        public int CategoryId { get; set; }  
        public Category Categories { get; set; }
        public TransactionType TransactionType { get; internal set; }
    }

}

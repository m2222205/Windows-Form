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
        public decimal Доход { get; set; }
        public decimal Расход { get; set; }
        public decimal Кредит { get; set; }
        public decimal Дебит { get; set; }
        public decimal Зарплата { get; set; }

        public int CategoryId { get; set; }
        public Category Categories { get; set; } // навига

    }

}

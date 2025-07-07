using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form.Models;
using Windows_Form.repository;

namespace Windows_Form.Service
{
    public class FinanceService
    {
        private readonly FinanceRepository _repository;

        public FinanceService()
        {
            _repository = new FinanceRepository();
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Некорректный ID для удаления");

            // Можно также проверить: существует ли запись с таким ID (опционально)
            var allFinances = _repository.GetAll();
            var financeToDelete = allFinances.FirstOrDefault(f => f.ID == id);

            if (financeToDelete == null)
                throw new Exception("Запись не найдена");

            _repository.Delete(id);
        }

        public void Add(Finance finance)
        {
            if (finance == null) throw new ArgumentNullException("Property can not be null");

            if (finance.Доход < 0 || finance.Расход < 0)
                throw new ArgumentException("Доход и расход не могут быть отрицательными.");

            _repository.Add(finance);
        }

    }
}

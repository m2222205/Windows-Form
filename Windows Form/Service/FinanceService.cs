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

            _repository.Delete(id);
        }

        public int Add(Finance finance)
        {
            if (finance == null)
                throw new ArgumentNullException("Поля не могут быть пустыми");

            return _repository.Add(finance);
        }


        public Finance Update(Finance finance)
        {
            if (finance.ID <= 0)
                throw new ArgumentException("Некорректный ID для обновления");


            _repository.Update(finance);

            return _repository.GetById(finance.ID);
        }

        public List<Finance> GetAll()
        {
            return _repository.GetAll();
        }



    }
}

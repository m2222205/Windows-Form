using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form.Models;
using Windows_Form.repository;

namespace Windows_Form.Service
{
    public class TransactionService
    {
        private readonly TransactionTypeRepository _transactionTypeRepository;
        public TransactionService()
        {
            _transactionTypeRepository = new TransactionTypeRepository();
        }

        public List<TransactionType> GetAllTransactionTypes()
        {
            return _transactionTypeRepository.GetAllTransactionTypes();
        }

    }
}

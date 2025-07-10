using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form.Models;
using Windows_Form.repository;

namespace Windows_Form.Service
{
    public class CategoryService
    {
        private readonly CategoryRepository categoryRepository;
        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }
        public List<Category> GetAllCategories() 
        {
            return categoryRepository.GetCategories();
        }


    }
}

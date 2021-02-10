using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
   public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager()
        {
        }

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            //İş kodları
            return _categoryDal.GetAll().ToList();
        }

        public Category GetByID(int categoryId)
        {
            return _categoryDal.Get(p => p.CategoryId == categoryId);
        }
    }
}

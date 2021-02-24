using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

       
        public IDataResult<List<Category>> GetAll()
        {
            //İş kodları
            return new SuccesDataResult<List<Category>>( _categoryDal.GetAll().ToList());
        }

        public IDataResult<Category> GetByID(int categoryId)
        {
            return new SuccesDataResult<Category>(_categoryDal.Get(p => p.CategoryId == categoryId));
        }
        private IResult CheckIfProductNameExist(string productName)//Product product şeklindede olabilir.
        {
            var result = _categoryDal.GetAll().Count;
            if (result>=15)
            {
                return new ErrorResult(Messages.CategoryLimitIsExceded);
            }
            return new SuccesResutl();
        }
    }
}

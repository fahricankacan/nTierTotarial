using Core.DataAcces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface metotları default publictir.İnterface in kendisi değil.
   public interface IProductDal:IEntityRepository<Product>
    {

    
    }
}

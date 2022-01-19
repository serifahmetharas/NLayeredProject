using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.Entity_Framework
{
    public class EfCategoryDal :EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal

    {
    }
}
 
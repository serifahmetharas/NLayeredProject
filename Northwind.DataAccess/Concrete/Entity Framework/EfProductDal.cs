﻿using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.Entity_Framework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal // Bir Class çıplak olmamalıdır. Aşağıdaki methodlar IProductDal interface inin implementi aracılığıyla gelmelidir.
    {

    }
}

using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        // Dependency Injection:
        // İş katmanımızda EntityFramework veye NHibernate classlarını ayrı ayrı newlemek yerine bu şekilde IProductDal tanımlarız.
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal) // ProductManager çağırırken productDal
                                                      // Entity veya NHibernate olarak belirtilerek çağırılır ve kod ona göre çalışır.
        {
            _productDal = productDal;
        }

        List<Product> IProductService.GetAll()
        {
            // Business Code (Data çekiyor ama çekebilir mi? Uygun mu? Çekilsin mi? gibi kodlar.)

            return _productDal.GetAll();
        }
    }
}

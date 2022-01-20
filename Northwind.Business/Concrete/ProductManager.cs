using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

        public void Add(Product product) // Add özelliğini ekledikten sonra generate method diyerek
                                         // IProductServicede bir method oluşturmuş oluyoruz.
                                         // O da Product Manager içinde işlendiğinden orada implement ediliyor.
                                         // İçine işleyerek işlemi tamamlıyoruz.
        {
            // Ekleme işlemi için validation uygulayıp daha sonra işlemi gerçekleştirelim.
            // Business katmanında validate işlemini yaptığımız için burada sadece method girmemiz yeterli.
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            // İş katmanı hata yönetimi yapılan yer olduğu için,
            // Olası bir veritabanı hatasına karşılık bu işlem gerçekleştirildi.
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Silme işlemi gerçekleşemedi.");
            }

        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product) // Tıpkı Add özelliği gibi implement edildi.
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }

        List<Product> IProductService.GetAll()
        {
            // Business Code (Data çekiyor ama çekebilir mi? Uygun mu? Çekilsin mi? gibi kodlar.)

            return _productDal.GetAll();
        }
    }
}

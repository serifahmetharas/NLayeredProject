using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);

            } // Eğer validasyon hatası var ise hata fırlat.
              // Arayüzde de try catch içerisine alarak hatayı uygulamada yazdırırız.
              // Tekrar tekrar bu işlemi her operasyonda yapmamak için böyle bir Tool oluşturduk ve method olarak her istediğimizde kullanabilicez.
        
        }
    }
}

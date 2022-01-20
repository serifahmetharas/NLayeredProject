using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product> // Ürün için kurallar.
    {
        public ProductValidator() // ctor+2tab ile bir constructor oluşturuyoruz. (Snippet)
        {
            // Boş olamazlar.
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz.");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2); // 2.Kategorideki ürünler 10 dan pahalı olmalıdır kuralı.

            
        }
    }
}

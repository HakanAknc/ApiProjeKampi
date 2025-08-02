using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin!");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Ürün adı en az 2 karakter olmalıdır!");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("Ürün adı en fazla 50 karakter olmalıdır!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatını boş geçmeyin!")
                .GreaterThan(0).WithMessage("Ürün fiyatı negatif olamaz!")
                .LessThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz! Girdiğiniz değeri kontrol edin!");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklamasını boş geçmeyin!");
        }
    }
}

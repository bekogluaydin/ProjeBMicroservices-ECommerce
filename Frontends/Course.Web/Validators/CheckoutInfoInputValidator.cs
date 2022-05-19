using Course.Web.Models.Orders;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Validators
{
    public class CheckoutInfoInputValidator: AbstractValidator<CheckoutInfoInput>
    {
        public CheckoutInfoInputValidator()
        {
            RuleFor(x => x.CardName).NotEmpty().WithMessage("Kart isim alanı boş olamaz.");

            RuleFor(x=> x.CardNumber).NotEmpty().WithMessage("Kart alanı boş olamaz").MinimumLength(16).WithMessage("Kart numarasını eksik girdiniz.").
                MaximumLength(16).WithMessage("Kart numarasını fazla girdiniz.");

            RuleFor(x=> x.CVV).NotEmpty().WithMessage("CVV/CVC alanı boş olamaz").MinimumLength(3).WithMessage("CVV/CVC numarasını eksik girdiniz").
                MaximumLength(3).WithMessage("CVV/CVC numarasını fazla girdiniz");

            RuleFor(x=> x.Expiration).NotEmpty().WithMessage("Kart son kullanma tarihi boş olamaz.");


        }
    }
}

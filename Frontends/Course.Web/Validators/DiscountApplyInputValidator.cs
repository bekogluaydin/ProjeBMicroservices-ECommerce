﻿using Course.Web.Models.Discounts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Validators
{
    public class DiscountApplyInputValidator:AbstractValidator<DiscountApplyInput>
    {
        public DiscountApplyInputValidator()
        {
            RuleFor(x => x.Code).NotEmpty().WithMessage("İndirim alanı boş olamaz");
        }
    }
}

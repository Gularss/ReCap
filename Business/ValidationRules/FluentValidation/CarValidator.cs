using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p=>p.CarName).MinimumLength(2);
            RuleFor(p=>p.CarName).NotEmpty();
            RuleFor(p=>p.DailyPrice).NotEmpty();
            RuleFor(p=>p.DailyPrice).GreaterThan(0);
            RuleFor(p=>p.DailyPrice).GreaterThanOrEqualTo(10).When(p=>p.BrandId==1);
            RuleFor(p => p.ModelYear).NotEmpty();
            RuleFor(p => p.ModelYear).GreaterThanOrEqualTo(1990).WithMessage("1990 modelden eski araçları sistem kabul etmemektedir.");
        }
    }
}

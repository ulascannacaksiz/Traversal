using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator:AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş olamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş olamaz");
            RuleFor(x => x.Name).MinimumLength(4).WithMessage("İsim 4 Karakterden az olamaz");
        }
    }
}

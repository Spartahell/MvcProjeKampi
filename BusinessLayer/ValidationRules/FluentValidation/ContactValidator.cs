using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.UserMail).NotEmpty().WithMessage("Mail Boş Geçilemez");
            RuleFor(c => c.Subject).NotEmpty().WithMessage("Konu adı  boş  geçemezsiniz");
            RuleFor(c => c.UserName).NotEmpty().WithMessage("Adı boş  geçemezsiniz");
            RuleFor(c => c.Subject).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(c => c.UserName).MinimumLength(3).WithMessage("3 karakterden az olamaz");
            RuleFor(c => c.Subject).MaximumLength(50).WithMessage("50 karakterden fazla olmaz");
        }
    }
}

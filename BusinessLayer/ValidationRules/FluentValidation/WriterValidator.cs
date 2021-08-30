using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(c => c.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Geçilemez");
            RuleFor(c => c.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş  geçemezsiniz");
            RuleFor(c => c.WriterAbout).NotEmpty().WithMessage("Yazar hakkında boş  geçemezsiniz");
            RuleFor(c => c.WriterSurName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(c => c.WriterSurName).MaximumLength(50).WithMessage("50 karakterden fazla olamaz");
            RuleFor(x => x.WriterAbout).Must(x => x != null && x.ToUpper().Contains("A")).WithMessage("Hakkında kısmında en az bir a harfi içermelidir");
        }
    }
}

using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(c => c.Subject).NotEmpty().WithMessage("Konu Boş Geçilemez");
            RuleFor(c => c.ReceiverMail).NotEmpty().WithMessage("Alıcı Mail Boş Geçilemez");
            RuleFor(c => c.MessageContent).NotEmpty().WithMessage("Mesaj Boş Geçilemez");
            RuleFor(c => c.Subject).MaximumLength(100).WithMessage("100 karakterden fazla olamaz");
        }
    }
}

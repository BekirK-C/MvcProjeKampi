using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresini Boş Geçemezsiniz!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş Geçemezsiniz!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj Alanını Boş Geçemezsiniz!");
            RuleFor(x => x.Subject).MaximumLength(30).WithMessage("En Fazla 30 Karakter Girişi Yapılabilir!");
            RuleFor(x => x.MessageContent).MaximumLength(500).WithMessage("En Fazla 500 Karakter Girişi Yapılabilir!");
        }
    }
}

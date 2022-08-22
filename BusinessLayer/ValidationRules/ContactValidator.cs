using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz!");
            RuleFor(x => x.Subjact).NotEmpty().WithMessage("Konu Adını Boş Geçemezsiniz!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz!");
            RuleFor(x => x.Subjact).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapınız!");
            RuleFor(x => x.Subjact).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapınız!");
            RuleFor(x => x.UserName).MinimumLength(50).WithMessage("En Fazla 50 Karakter Girişi Yapılabilir!!");
        }
    }
}

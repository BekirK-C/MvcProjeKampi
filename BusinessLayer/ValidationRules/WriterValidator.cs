using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Olamaz!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Adı Boş Olamaz!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("YHakkında Kısmı Boş Olamaz!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("YHakkında Kısmı Boş Olamaz!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En Az 2 Karakter Girişi Yapınız!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En Fazla 50 Karakter Girişi Yapılabilir!");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("En Az 2 Karakter Girişi Yapınız!");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("En Fazla 50 Karakter Girişi Yapılabilir!");
        }
    }
}

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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş Geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar Mail Kısmı Boş Geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar Mail Kısmı Boş Geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar Mail Kısmı Boş Geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar Adı En az 2 harfden oluşmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(2).WithMessage("Yazar Adı En fazla 50 harfden oluşabilir.");




        }
    }
}

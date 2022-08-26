using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı soyadı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez.")
                   .MinimumLength(8).WithMessage("Şifreniz en az 8 karakterden oluşmalı.")
                   .MaximumLength(32).WithMessage("Şifreniz en fazla 32 karakterden oluşmalı.")
                   .Matches(@"[A-Z]+").WithMessage("Şifreniz büyük harf içermeli.")
                   .Matches(@"[a-z]+").WithMessage("Şifreniz küçük harf  içermeli.")
                   .Matches(@"[0-9]+").WithMessage("Şifreniz en az 1 sayı içermeli..")
                   .Matches(@"[\!\?\*\.]+").WithMessage("Şifreniz (!? *.). özel karakterlerinden birini içermeli. ");

            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı en az 2 karakter olmalı.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar adı en fazla 50 karakter olmalı.");
        }
    }
}

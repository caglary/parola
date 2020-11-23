using FluentValidation;
using parola.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parola.Business.FluentValidation
{
    public class ParolaValidator : AbstractValidator<Parola>
    {
        public ParolaValidator()
        {
            RuleFor(p => p.isim).NotEmpty().WithMessage("İsim boş olamaz.");
            //RuleFor(p => p.kullaniciadi).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.");
            //RuleFor(p => p.parola_).NotEmpty().WithMessage("Parola boş olamaz.");
            
        }
    }
}

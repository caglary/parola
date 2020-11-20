using FluentValidation;
namespace parola.ValidatonRules.FluentValidation
{
    public class ParolaValidator:AbstractValidator<parola>
    {
        public ParolaValidator()
        {
            RuleFor(p => p.isim).NotEmpty().WithMessage("İsim değeri boş geçilemez");
            RuleFor(P => P.kullaniciadi).NotEmpty().WithMessage("Kullanıcı adı giriniz."); 
            RuleFor(p => p.parola_).NotEmpty().WithMessage("Parola girmediniz.");
        }
    }
}

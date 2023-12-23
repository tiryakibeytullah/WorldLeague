using FluentValidation;
using WorldLeague.API.Features.Commands.Countries.CreateCountry;
using WorldLeagure.Repository.Consts;

namespace WorldLeague.API.Validators.Countries
{
    public class CreateCountryValidator : AbstractValidator<CreateCountryCommandRequest>
    {
        public CreateCountryValidator()
        {
            RuleFor(c => c.Name)
               .NotEmpty()
                     .WithMessage("Lütfen Ülke Adı giriniz.")
               .NotNull()
                    .WithMessage("Lütfen Ülke Adı giriniz.")
               .MaximumLength(CountryConst.NameMaxLength)
                    .WithMessage($"Ülke Adı 1 ila {CountryConst.NameMaxLength} karakter arasında uzunluğa sahip olmalıdır.");

        }
    }
}

using FluentValidation;
using WorldLeague.API.Features.Commands.Teams.UpdateTeam;
using WorldLeagure.Repository.Consts;

namespace WorldLeague.API.Validators.Teams
{
    public class UpdateTeamValidator : AbstractValidator<UpdateTeamCommandRequest>
    {
        public UpdateTeamValidator()
        {
            RuleFor(c => c.Id)
              .NotEmpty()
              .NotNull()
                  .WithMessage("Lütfen Guid tipinde bir Id değişkeni giriniz.");

            RuleFor(c => c.CountryId)
              .NotEmpty()
              .NotNull()
                  .WithMessage("Lütfen Guid tipinde bir CountryId değişkeni giriniz.");

            RuleFor(c => c.Name)
              .NotEmpty()
                    .WithMessage("Lütfen Takım Adı giriniz.")
              .NotNull()
                   .WithMessage("Lütfen Takım Adı giriniz.")
              .MaximumLength(TeamConst.NameMaxLength)
                   .WithMessage($"Takım Adı 1 ila {TeamConst.NameMaxLength} karakter arasında uzunluğa sahip olmalıdır.");
        }
    }
}

using FluentValidation;
using WorldLeague.API.Features.Commands.Groups.CreateGroup;
using WorldLeagure.Repository.Consts;

namespace WorldLeague.API.Validators.Groups
{
    public class CreateGroupValidator : AbstractValidator<CreateGroupCommandRequest>
    {
        public CreateGroupValidator()
        {
            RuleFor(c => c.Name)
              .NotEmpty()
                    .WithMessage("Lütfen Grup Adı giriniz.")
              .NotNull()
                   .WithMessage("Lütfen Grup Adı giriniz.")
              .MaximumLength(GroupConst.NameMaxLength)
                   .WithMessage($"Grup Adı 1 ila {GroupConst.NameMaxLength} karakter arasında uzunluğa sahip olmalıdır.");
        }
    }
}

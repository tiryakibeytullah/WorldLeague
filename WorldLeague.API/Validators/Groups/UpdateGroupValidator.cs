using FluentValidation;
using WorldLeague.API.Features.Commands.Groups.UpdateGroup;
using WorldLeagure.Repository.Consts;

namespace WorldLeague.API.Validators.Groups
{
    public class UpdateGroupValidator : AbstractValidator<UpdateGroupCommandRequest>
    {
        public UpdateGroupValidator()
        {
            RuleFor(c => c.Id)
              .NotEmpty()
              .NotNull()
                  .WithMessage("Lütfen Guid tipinde bir Id değişkeni giriniz.");

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

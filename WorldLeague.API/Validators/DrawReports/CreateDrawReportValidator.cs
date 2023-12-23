using FluentValidation;
using WorldLeague.API.Features.Commands.DrawReports.CreateDrawReport;
using WorldLeagure.Repository.Consts;

namespace WorldLeague.API.Validators.DrawReports
{
    public class CreateDrawReportValidator : AbstractValidator<CreateDrawReportCommandRequest>
    {
        public CreateDrawReportValidator()
        {
            RuleFor(c => c.Firstname)
               .NotEmpty()
                     .WithMessage("Lütfen Adınızı giriniz.")
               .NotNull()
                    .WithMessage("Lütfen Adınızı giriniz.")
               .MaximumLength(DrawReportConst.FirstnameMaxLength)
                    .WithMessage("Adınız 1 ila 50 karakter arasında uzunluğa sahip olmalıdır.");

            RuleFor(c => c.Surname)
              .NotEmpty()
                    .WithMessage("Lütfen Soyadınızı giriniz.")
              .NotNull()
                   .WithMessage("Lütfen Soyadınızı giriniz.")
              .MaximumLength(DrawReportConst.SurnameMaxLength)
                   .WithMessage("Soyadınız 1 ila 50 karakter arasında uzunluğa sahip olmalıdır.");

            RuleFor(c => c.GroupCount)
             .NotEmpty()
                    .WithMessage("Lütfen Grup Sayısını giriniz.")
               .NotNull()
                    .WithMessage("Lütfen Grup Sayısını giriniz.")
               .Must(g => g == 4 || g == 8)
                    .WithMessage("Grup sayısı 4 ya da 8 olmalıdır.");
        }
    }
}

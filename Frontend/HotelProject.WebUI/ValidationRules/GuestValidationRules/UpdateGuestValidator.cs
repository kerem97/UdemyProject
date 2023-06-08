using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Giriniz");
            RuleFor(x => x.Name).MaximumLength(12).WithMessage("Lütfen En Fazla 12 Karakter Giriniz");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Giriniz");
            RuleFor(x => x.Surname).MaximumLength(12).WithMessage("Lütfen En Fazla 12 Karakter Giriniz");
            RuleFor(x => x.City).MinimumLength(4).WithMessage("Lütfen En Az 4 Karakter Giriniz");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Giriniz");
        }
    }
}

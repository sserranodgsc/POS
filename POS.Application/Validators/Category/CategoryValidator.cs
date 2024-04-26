using FluentValidation;
using POS.Application.Dtos.Requests;

namespace POS.Application.Validators.Category
{
    public class CategoryValidator : AbstractValidator<CategoryRequestDto>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("El campo nombre no puede ser nulo")
                .NotEmpty().WithMessage("El campo nombre no puede estar vacio");

            RuleFor(x => x.Description)
                .NotNull().WithMessage("El campo descripción no puede ser nulo")
                .NotEmpty().WithMessage("El campo descripción no puede estar vacio");
        }
    }
}

using FluentValidation;
using ProductAPI.ViewModel;

namespace ProductAPI.Validators
{
    public class AddProductViewModelValidator : AbstractValidator<AddProductViewModel>
    {
        public AddProductViewModelValidator() 
        {
            RuleFor(x=>x.ProductName)
                .NotEmpty()
                .NotNull()
                .Length(8,20);

            RuleFor(x=>x.ProductDescription) 
                .NotEmpty()
                .NotNull()
                .Length(10,20);
        }

    }
}

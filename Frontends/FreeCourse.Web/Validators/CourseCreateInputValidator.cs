using FluentValidation;
using FreeCourse.Web.Models.Catalogs;

namespace FreeCourse.Web.Validators
{
    public class CourseCreateInputValidator : AbstractValidator<CourseCreateInput>
    {
        public CourseCreateInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("name can not be null");
            RuleFor(x => x.Description).NotEmpty().WithMessage("description can not be null");
            RuleFor(x => x.Feature.Duration).InclusiveBetween(1, int.MaxValue).WithMessage("duration can not be null");

            RuleFor(x => x.Price).NotEmpty().WithMessage("price area can not be null")
                .ScalePrecision(2, 6).WithMessage("error price format");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("select category");
        }
    }
}

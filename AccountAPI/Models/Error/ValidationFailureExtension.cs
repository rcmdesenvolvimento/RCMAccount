using FluentValidation.Results;

namespace AccountAPI.Models.Error
{
    public static class ValidationFailureExtension
    {
        public static IList<CustomValidatonFailure> ToCustomValidationFailure(this IList<ValidationFailure> failures)
        {
            return failures.Select(f => new CustomValidatonFailure(f.PropertyName, f.ErrorMessage)).ToList();
        }
    }
}
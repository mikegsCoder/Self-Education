namespace CustomValidationApp
{
    using System.ComponentModel.DataAnnotations;

    public class PersonNameValidator : ValidationAttribute
    {
        string[] names;

        public PersonNameValidator(string[] names)
        {
            this.names = names;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (names.Contains(value?.ToString()))
            {
                return new ValidationResult("Invalid name provided!");
            }

            return ValidationResult.Success;
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Core.Validate;

public class RequiredIfAttribute : ValidationAttribute
{
    private readonly string _comparisonProperty;
    private readonly object _comparisonValue;

    public RequiredIfAttribute(string comparisonProperty, object comparisonValue)
    {
        _comparisonProperty = comparisonProperty;
        _comparisonValue = comparisonValue;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var property = validationContext.ObjectType.GetProperty(_comparisonProperty);
        if (property == null)
            throw new ArgumentException("Property with this name not found");

        var comparisonValue = property.GetValue(validationContext.ObjectInstance);
        if (Equals(comparisonValue, _comparisonValue) && value == null)
        {
            return new ValidationResult(ErrorMessage);
        }

        return ValidationResult.Success;
    }
}
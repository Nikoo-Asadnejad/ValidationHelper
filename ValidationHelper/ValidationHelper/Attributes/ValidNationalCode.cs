using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ValidationHelper.Attributes;

public class ValidNationalCode : ValidationAttribute
{
    private readonly string _nationalCodeRegex = @"^[0-9]{10}$";
    public override bool IsValid(object? value)
        => (value is string && ((string)value).Length is 10 && !Regex.Match((string)value , _nationalCodeRegex).Success);
}
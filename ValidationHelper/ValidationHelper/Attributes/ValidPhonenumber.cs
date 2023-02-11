using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ValidationHelper.Attributes;

public class ValidPhonenumber : ValidationAttribute
{
    private readonly string _phoneNumberRegex = @"(0|\+98)?([ ]|-|[()]){0,2}9[1|2|3|4]([ ]|-|[()]){0,2}(?:[0-9]([ ]|-|[()]){0,2}){8}";

    public override bool IsValid(object? value)
        => ((value is string) && !Regex.Match((string)value, _phoneNumberRegex).Success);


}
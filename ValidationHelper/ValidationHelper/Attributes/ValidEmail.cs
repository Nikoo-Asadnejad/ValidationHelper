using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ValidationHelper.Attributes;

public class ValidEmail : ValidationAttribute
{
    private readonly string _emailRegex = @"^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
    public override bool IsValid(object? value)
    => (value is  string && !Regex.Match((string)value , _emailRegex).Success);

    
}
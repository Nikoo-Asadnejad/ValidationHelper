using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ValidationHelper.Attributes;

public class ValidPhonenumber : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        string regex = @"(0|\+98)?([ ]|-|[()]){0,2}9[1|2|3|4]([ ]|-|[()]){0,2}(?:[0-9]([ ]|-|[()]){0,2}){8}";
        if ((value is not string ) || !Regex.Match((string)value , regex).Success) return false;
        return true; 
    }
}
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ValidationHelper.Attributes;

public class ValidEmail : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        string regex = "^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
        if (value is not string || !Regex.Match((string)value , regex).Success) return false;
        return true; 
    }
}
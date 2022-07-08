using System.ComponentModel.DataAnnotations;

namespace Asp_MVCCore.Attribute
{
    public class VallidateCheckBox: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if ((bool)value == true)
                return true;

            return false;
        }
    }
}

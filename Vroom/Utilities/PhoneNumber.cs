using System.ComponentModel.DataAnnotations;
namespace Vroom.Utilities
{
    public class PhoneNumber : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string[] strings = value.ToString().Split("");

            string firstCapitalLetter = strings[0];
            if (firstCapitalLetter[0] == '+' && firstCapitalLetter[1] == '9' && firstCapitalLetter[2] == '6' && firstCapitalLetter[3] == '6') 
            {
                return true;
            }
            else if ((int)firstCapitalLetter[0] >= 65 && (int)firstCapitalLetter[14] <= 90 || (int)firstCapitalLetter[0] >= 97 && (int)firstCapitalLetter[14] <= 122)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Vroom.Utilities
{
    public class FirstCapitalLetter : ValidationAttribute
    {

        public override bool IsValid(object? value)
        {
            string[] strings = value.ToString().Split("");
            
            string firstCapital = strings[0];
            char CapitalLetter = firstCapital[0];
            if (CapitalLetter >= 'A' && CapitalLetter <= 'Z')
            {
                return true;
            }
            else if ((int)CapitalLetter >= 97 && (int)CapitalLetter <= 122 || (int)CapitalLetter >= 33 && (int)CapitalLetter <= 47 || (int)CapitalLetter >=91 && (int)CapitalLetter >= 96)
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


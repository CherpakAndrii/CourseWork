using System.Text.RegularExpressions;

namespace WinFormsApp1.Model
{
    public class InputValidator
    {
        private static Regex regex = new Regex(@"^[\+-]? *(?:\d+ *\*? *)?x *(?:[\+-] *\d+)? *[><]=? *\d+ *$");

        public static bool ValidateInput(string textFildContent)
        {
            if (string.IsNullOrEmpty(textFildContent) || !regex.IsMatch(textFildContent)) return false;
            return true;
        }


        public static string ReformatInput(string input)
        {
            return input;
        }
    }
}
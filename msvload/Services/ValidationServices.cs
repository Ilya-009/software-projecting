using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msvload.Services
{
    public class ValidationServices
    {
        public static bool IsValidEmail(string email)
        {
            string[] emailProviders = new string[] { "gmail.com", "mail.ru", "hotmail.com",
                "yandex.ru", "outlook.com", "mail.co.uk"};

            string res = new System.Text.RegularExpressions.Regex(@"@(\S*)")
                .Match(email)
                .Value
                .Replace("@", string.Empty);

            if (!emailProviders.Contains(res))
            {
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPassword(string password)
        {
            if (password.Length == 0)
                return false;

            if (password.Length < 6 || password.Length > 18)
            {
                return false;
            }

            return true;
        }

        public static int CalcProgressDiagram(long? correct, long? wrong, bool ChooseCorrect)
        {
            if (correct == null || wrong == null)
                return -1;

            if (ChooseCorrect)
            {
                return (int)Math.Round((double)(correct * 100 / (correct + wrong)));
            }
            else
            {
                return (int)Math.Round((double)(wrong * 100 / (correct + wrong)));
            }
        }

        public static int CalcProgressDiagram(int done, int required)
        {
            if (done == 0 || required == 0)
                return 0;

            return (int)Math.Round((double)(done * 100 / required));

        }

    }
}

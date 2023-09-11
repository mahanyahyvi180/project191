using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp69
{
    class cValid
    {
        public static string GetPurText(int lengh, string text)
        {
            if (text.Length <= lengh)
            {
                char[] c;
                c = text.ToCharArray();
                string temp = "";
                foreach (char t in c)
                    if (char.IsLetter(t))
                        temp = temp + t.ToString();
                return (temp);
            }

            else

                return "";
        }

        public int Lenght
        {
            get;
            set;
        }

        private string ct;

        public string Text
        {
            get
            {
                return ct;
            }

            set
            {
                if (value.Length <= Lenght)
                {
                    char[] c;

                    c = value.ToCharArray();
                    string temp = "";
                    foreach (char t in c)
                    {
                        if (char.IsLetter(t))
                            temp = temp + t.ToString();
                    }
                }
            }
        }
    }
}

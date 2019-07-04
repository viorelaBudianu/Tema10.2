using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    public class GoatLatin
    {

        private static bool isVowel(char c)
        {
            return (c == 'A' || c == 'E' ||
            c == 'I' || c == 'O' ||
            c == 'U' || c == 'a' ||
            c == 'e' || c == 'i' ||
            c == 'o' || c == 'u');
        }
        public static string Translate(string text)
        {
            if (text == null)
                throw new ArgumentNullException("Text is null, no operation will be made");
            else
            {
                StringBuilder sb = new StringBuilder();
                string[] words = text.Split(' ');
                int count = 0;
                foreach (var w in words)
                {
                    count++;
                    if (isVowel(w[0]))
                    {
                        sb.Append(w).Append("ma");

                    }
                    else
                    {
                        for (var i = 1; i < w.Length; i++)
                        {
                            sb.Append(w[i]);
                        }
                        sb.Append(w[0]).Append("ma");
                    }

                    for (var i = 0; i < count; i++) //dupa fiecare cuvant sa adaug spatiu si aa
                    {
                        sb.Append('a');
                    }
                    if (count < words.Length)
                    {
                        sb.Append(" ");
                    }
                }
                return sb.ToString();
            }
        }
    }
}

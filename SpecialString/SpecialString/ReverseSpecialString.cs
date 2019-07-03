using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialString
{
    public class ReverseSpecialString
    {
        //given string should be put in test
        public string text;

        public static void reverseSpecial(char[] str)
        {

            if (text == null)
                throw new ArgumentNullException("String cannot be null in order to make the Special Reverse!");
            else
            {
                char[] charArray = text.ToCharArray();

                Console.WriteLine("Input string: " + text);
                reverseSpecial(charArray);
                String revStr = new String(charArray);

                Console.WriteLine("Output string: " + revStr);
            }
            // "pointeri" stanga si dreapta, si plecam din exterior spre interior sa facem verificarile
            int right = str.Length - 1;
            int left = 0;

            while (left < right)
            {
                // daca e caracter special, merg din stanga mai departe
                if (!char.IsLetter(str[left]))
                    left++;
                //daca nu, merg din dreapta spre mijloc
                else if (!char.IsLetter(str[right]))
                    right--;

                // daca nici catacterul din dreapta nici cel din stanga nu e special, le interschimb 
                else
                {
                    char tmp = str[left];
                    str[left] = str[right];
                    str[right] = tmp;
                    left++;
                    right--;
                }
            }
        }
    }
}

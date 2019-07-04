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

        public static string reverseSpecial(string text)
        {

            if (text == null)
                throw new ArgumentNullException("String cannot be null in order to make the Special Reverse!");
            else
            {
               // Console.WriteLine($"Input: {text}");
                char[] str = text.ToArray();
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

                    // daca nici caracterul din dreapta nici cel din stanga nu e special, le interschimb 
                    else
                    {
                        char tmp = str[left];
                        str[left] = str[right];
                        str[right] = tmp;
                        left++;
                        right--;

                    }
                }
                string output = new String(str);
                // Console.WriteLine($"Output: {str.ToString()}");
                return output;
            }
        }
    }
}
  
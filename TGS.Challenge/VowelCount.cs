using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            //convert string to char array
            char[] charValue = value.ToCharArray();
            int ocurrences = 0;
            foreach(char val in charValue)
            {
                switch (val)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    ocurrences += 1;
                    break;
                    default:
                        break;
                }
            }
            return ocurrences;
        }
    }
}

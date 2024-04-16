using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {

        }
        //Task 1
        static int countChars(string sentence)
        {
            int count = 0;
            foreach (char c in sentence)
            {
                if(c != ' ')
                {
                    count++;
                }
            }
            return count;
        }
        static int countWords(string sentence)
        {
            string[] words = sentence.Split(' ');

            return words.Length;
        }
        static string reverseSentance(string sentence)
        {
            string reverse = null;
            for(int i = sentence.Length-1; i >=0; i--) 
            {
                reverse += sentence[i];
            }
            return reverse;
        }
        static bool isPalindrome(string sentence)
        {
            string str = reverseSentance(sentence.ToLower());
            if (str.Equals(sentence.ToLower()))
            {
                return true;
            }
            return false;
        }
        static string count(string sentence)
        {
            int vowel=0; 
            int consonant=0;
            int integer = 0;
            int specialCharacter=0;
            foreach (char c in sentence) 
            { 
                int type = checkChar(c);
                switch(type)
                {
                    case 1:
                        consonant++;
                        break;
                    case 2:
                        integer++;
                        break;
                    case 3:
                        vowel++;
                        break;
                    case 4:
                        specialCharacter++;
                        break;
                }
            }
            return "Vowels: " + vowel + " Consonants: " + consonant + " Integers: " + integer + " Special Characters: "+specialCharacter;

        }
        internal static int checkChar(char ch)
        {
            int ascii = ch;
            if (ascii >= 65 && ascii <= 90 && !isVowel(ch)  || ascii >= 97 && ascii <= 122 && !isVowel(ch))
            {
               
                return 1; //Consonant
            }
            else if (ascii >= 48 && ascii <= 57)
            {
               
                return 2; //Integer
            }
            else if (isVowel(ch))
            {
               
                return 3; //Vowel
            }
            else
            {
                
                return 4; // Special Character
            }

        }
        internal static bool isVowel(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                return true;
            }
            return false;
        }

        //Task 2
        static bool compare(string s1, string s2)
        {
           return s1.Equals(s2);
        }
        static string copyto(string s1,string s2)
        {
            s1.CopyTo(s2);
            return s2;
        }
    }
}

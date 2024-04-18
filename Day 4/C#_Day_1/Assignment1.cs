namespace ConsoleApp1
{
    internal class Assignment1
    {
        public static void Main(string[] args)
        {
           
        }
        // Task 1
        internal static void getNumbers()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        // Task 2
        internal static void getTable()
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"5 * {i} = {5 * i}");
            }
        }
        // Task 3
        internal static void checkChar(char ch)
        {
            int ascii = ch;
            if (ascii >= 65 && ascii <= 90 && !isVowel(ch) || ascii >= 97 && ascii <= 122 && !isVowel(ch))
            {
                Console.WriteLine($"{ch} is a Consonant");
            }
            else if (ascii >= 48 && ascii <= 57)
            {
                Console.WriteLine($"{ch} is an Integer");
            }
            else if (isVowel(ch))
            {
                Console.WriteLine($"{ch} is a Vowel");
            }
            else
            {
                Console.WriteLine($"{ch} is a special character");
            }

        }
        private static bool isVowel(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                return true;
            }
            return false;
        }
        // Task 4
        internal static bool isPrime(int n)
        {
            bool flag = true;
            int sr = (int)Math.Sqrt(n);
            if (n <= 0)
            {
                return false;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            for (int i = 2; i <= sr; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return flag;
        }
        // Task 5
        internal static int sum()
        {
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                result += i;
            }
            return result;
        }
        //Task 7
        internal static char[] nameToArray(string name)
        {
            char[] nameArray = new char[name.Length];
            int i = 0;
            foreach (char ch in name)
            {
                nameArray[i++] = ch; 
            }
            return nameArray;
        }
        //Task 8
        internal static int countVowels(string name)
        {
            int count = 0;
            foreach(char ch in name)
            {
                if(isVowel(ch))
                {
                    count++;
                }
            }
            return count;
        }
        //Task 10
        internal static void display()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

    }

}

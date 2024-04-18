namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int[] SliceArray(int[] array, int start, int end)
        {
            int[] result = new int[end - start];
            int j = 0;
            for (int i = start; i < end; i++)
            {
                result[j++] = array[i];
            }
            return result;
        }
        public static int fib(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = helper(i);
            }
            return array[n - 1];
        }
        private static int helper(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return helper(n - 1) + helper(n - 2);
        }
    }
}

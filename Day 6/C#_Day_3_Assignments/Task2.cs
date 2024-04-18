namespace C__Day_3_Assignments
{
    internal class Task2
    {
        // Brute Force Sort
        static void bruteForceSort(int[] arr)
        {
            for (int partIndex = arr.Length - 1; partIndex >= 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
        }
        // Linear Search
        static int linearSearch(int[] arr, int target)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

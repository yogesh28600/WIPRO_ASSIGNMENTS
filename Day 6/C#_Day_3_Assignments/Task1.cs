namespace C__Day_3_Assignments
{
    internal class Task1
    {
        //Create a function named InitializeArray that initializes an array with a given size and fills it with random integers.

        // Develop functions named InsertElement, DeleteElement, UpdateElement,
        // and ReverseArray that perform the corresponding operations on an array. Provide a brief comment on each function describing its behavior."
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 ,6};
            Console.WriteLine(Task4.SumArray(arr));
 
        }
        static int[] arrInit( int size)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for(int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(1,100);
            }
            return arr;
        }
        static int[] insert(int[] arr, int x)
        {
            // We are creating new array as we cannot modify the size of array dynamically
            int[] result = new int[arr.Length + 1]; // Creates a new array with size of orginal array + 1
            Array.Copy(arr, result, arr.Length); //Copies the orginal array to new array
            result[arr.Length] = x; //Inserting the element at last index
            return result; // Returns new array

        }
        static int[] delete(int[] arr, int element)
        {
            int idx = Array.BinarySearch(arr, element); //Searches the element to be deleted and stores that index value in idx variable.If the element is not found then -1 is stored
            if (idx >= 0) // Checking if the index value is greater than or equal to 0
            {
                // We are creating new array as we cannot modify the size of array dynamically
                int[] result = new int[arr.Length - 1]; // creates new array with size decreased by 1 than the orginal array
                // This loop will copy all elements except the target element to be deleted to the new array
                for (int i = 0; i < result.Length; i++) 
                {
                    if (arr[i] != element)
                    {
                        result[i] = arr[i];

                    }
                }
                return result; //Returns new array
            }
            return arr; // If element is not found return orginal array
        }
        static void update(int[] arr, int index, int value)
        {
            arr[index] = value; // modifing theold value with new value at the index specified of orginal array.
        }
        static void reverse(int[] arr)
        {
            Array.Reverse(arr); // Array.Reverse() method reverses the orginal array in-place.
        }
    }
}

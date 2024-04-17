namespace C__Day_3_Assignments
{
    internal class Task3
    { 
        static int[] twoSum(int[] arr,int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == target)
                    {
                        return [i,j];
                    }
                }
            }
            return [-1, -1];
        } 
    }
}

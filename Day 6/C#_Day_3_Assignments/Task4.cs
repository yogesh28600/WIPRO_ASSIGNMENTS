namespace C__Day_3_Assignments
{
    internal class Task4
    {
        internal static int SumArray(int[] arr,int idx=0)
        {
            
            if(idx == arr.Length)
            {
                return 0;
            }
            return arr[idx] + SumArray(arr,idx+1);
        }

    }
}

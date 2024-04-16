using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace C__Day2
{
        //Write a program to perform following functions in integer array(MODULAR APPROACH)
        //ARRAY SHUD BE SORTED FIRST
        //1. insert element,
        //2. delete element
        //3. update element
        //4. reverse elements of an integer array
        //5. search element
        //    1. Linear Search
        //    2. Binary Search
        //6.Sort Array(Use Any Brute Force Algo) - Use Bubble Sort
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.Write("Array: ");
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.insert element");
                Console.WriteLine("2. delete element");
                Console.WriteLine("3. update element");
                Console.WriteLine("5. search element");
                Console.WriteLine("6.Sort Array");
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter element to insert");
                        int[] res = insert(arr, int.Parse(Console.ReadLine()));
                        foreach (int i in res)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter element to delete");
                        int[] res1 = delete(arr, int.Parse(Console.ReadLine()));
                        foreach (int i in res1)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter index of element to be updated ");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter a value to get updated");
                        int value = int.Parse(Console.ReadLine());
                        update(arr,index,value);
                        foreach (int i in arr)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        reverse(arr);
                        foreach (int i in arr)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("1.Linear Search");
                        Console.WriteLine("2. Binary Search");
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                Console.WriteLine("Enter Target Element");
                                Console.WriteLine(linearSearch(arr, int.Parse(Console.ReadLine())));
                                break;
                            case 2:
                                Console.WriteLine("Enter Target Element");
                                Console.WriteLine(binarySearch(arr, int.Parse(Console.ReadLine()),0,arr.Length-1));
                                break;
                        }
                        break;
                    case 6:
                        bubbleSort(arr);
                        foreach (int i in arr)
                        {
                            Console.Write(i); 
                        }
                        Console.WriteLine();
                        break;
                }
                
            }
        }
        static int[] insert(int[] arr, int x)
        {
            Array.Sort(arr);
            int[] result = new int[arr.Length+1];
            Array.Copy(arr, result, arr.Length);
            result[arr.Length] = x;
            Array.Sort(result);
            return result;
            
        }
        static int[] delete(int[] arr,int element)
        {
            Array.Sort(arr);
            int idx=linearSearch(arr, element);
            if (idx > 0)
            {
                int[] result = new int[arr.Length - 1];
                for (int i = 0; i < result.Length; i++)
                {
                    if (arr[i] != element)
                    {
                        result[i] = arr[i];

                    }
                }
                return result;
            }
            return arr;
        }
        static void update(int[] arr, int index, int value)
        {
            Array.Sort(arr);
            arr[index] = value;
        }
        static void reverse(int[] arr)
        {
            Array.Reverse(arr);
        }

        static int linearSearch(int[] arr, int target)
        {
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        static int binarySearch(int[] arr,int target,int start,int end)
        {
            Array.Sort(arr);
            int mid = start + (end - start) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            if (target < arr[mid])
            {
                binarySearch(arr, target, start, mid-1);
            }
            else if(target > arr[mid])
            {
                binarySearch(arr,target, mid+1, end);
            }
            return -1;
        }
        static void bubbleSort(int[] arr)
        {
            for(int partIndex = arr.Length-1; partIndex >= 0; partIndex--)
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
    }
}

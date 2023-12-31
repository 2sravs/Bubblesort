﻿using System;

namespace ConAppBubbleSort
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int noswap = 0;
            bool swapped;
            for(int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for(int j=0; j<n-i-1; j++)
                {
                    if (arr[j]>arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                        noswap++;

                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void Print(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Print Array without Sort");
            Print(arr);
            BubbleSort(arr);
            Console.WriteLine("After Bubble Sort");
            Print(arr);
            Console.ReadKey();
        }
    }
}

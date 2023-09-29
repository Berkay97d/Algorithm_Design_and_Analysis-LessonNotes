using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Algorithm_Design_and_Analysis.Algorithms;
using Algorithm_Design_and_Analysis.Algorithms.Homework1;
using Algorithm_Design_and_Analysis.Algorithms.Homework2;
using Algorithm_Design_and_Analysis.Algorithms.Searching;
using Algorithm_Design_and_Analysis.Algorithms.Searching.Brute_Force;
using Algorithm_Design_and_Analysis.Algorithms.Sorting;
using Algorithm_Design_and_Analysis.Algorithms.Sorting.Brute_Force;
using Algorithm_Design_and_Analysis.Algorithms.Sorting.Dicrease_and_Conqure;
using Algorithm_Design_and_Analysis.Algorithms.Sorting.Divide_and_Conqure;

namespace Algorithm_Design_and_Analysis
{
    internal class Program
    {
        public static bool isArrayUnique(int[] arr)
        {
            MergeSort.Sort(arr);
            
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1] )
                {
                    return false;
                }
            }

            return true;
        }
        
        
        
        
    }
}
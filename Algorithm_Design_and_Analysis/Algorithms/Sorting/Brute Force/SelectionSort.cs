using System;

namespace Algorithm_Design_and_Analysis.Algorithms.Sorting.Brute_Force
{
    public class SelectionSort
    {
        public static int[] SortInt(int[] arr)    
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var min = i;
                for (int j = i; j < arr.Length ; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        int temp = arr[j];
                        arr[j] = arr[min];
                        arr[min] = temp;
                    }
                }
            }
            return arr;
        }
        
         
        
        public static char[] SortString(char[] str)     
        {
            int index;
            
            for (int i = 0; i < str.Length - 1; i++)      
            {
                index = i;                                  
                for (int j = i+1; j < str.Length ; j++)    
                {
                    if (str[j] < str[index])            
                    {
                        index = j;
                    }

                    char smallerNum = str[index];     
                    str[index] = str[i];           
                    str[i] = smallerNum;
                }
            }
            return str;
        }
        
        
        
        
        
    }
}
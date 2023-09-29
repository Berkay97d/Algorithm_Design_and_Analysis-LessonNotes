using System;
using System.Collections.Generic;

namespace Algorithm_Design_and_Analysis.Algorithms
{
    public class LeetCodeSolutions
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n) // 1 2 4 0 0 0       3 5 6
        {
            int counter = 0;                                     
            for (int i = m; i < nums1.Length; i++)
            {
                nums1[i] = nums2[counter];
                counter++;
            }
            
            Array.Sort(nums1);
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(11));
        }

        public static List <string> solutions = new List<string>();
        
        public static int ClimbStairs(int n)
        {

            string a = "";
            for (int i = 0; i < n; i++)
            {
                a[a.Length + i] = '1';
            }

            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] == '1' && a[i+1] == '1' )
                {
                    if (i == 0)
                    {
                        string newString = '2' + a.Substring(i+2 , a.Length-(i+2)); 
                        solutions.Add(newString);
                        int newInt = Convert.ToInt32(newString);
                        ClimbStairs(newInt);
                    }
                    else
                    {
                        string newString = a.Substring(0,i)+ '2' + a.Substring(i+2 , a.Length-(i+2)); 
                        solutions.Add(newString);
                        int newInt = Convert.ToInt32(newString);
                        ClimbStairs(newInt); 
                    }
                    
                }
            }

            for (int i = 0; i < solutions.Count-1; i++)
            { 
                if (solutions[i].Equals(solutions[i+1]))
                {
                    solutions.Remove(solutions[i]);
                }
            }

            return solutions.Count;

        }
    }
}
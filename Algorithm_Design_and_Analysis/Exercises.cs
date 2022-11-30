using System;

namespace Algorithm_Design_and_Analysis
{
    public class Exercises
    {
        
        public static void Main(string[] args)
        {
            //int[] exercise1Arr = {1, 2, 3, 4, 5, 6, 7, 8};
            //Exercise1(exercise1Arr);

            //int n = 3;
            //Exercise2(n);
            
            //int[] exercise3Arr = {1, 2, 3, 4, 5, 6, 7, 8};
            //Exercise3(exercise3Arr);

            /*int i = 1, k = 1, counter = 0;

            while (k < 16)
            {
                i++;
                k = k + i;
                counter++;
            }
            
            Console.WriteLine(counter);
            */
            

            var a = RussianOeasabtMult(4, 3);
            Console.WriteLine(a);
        }

        private static void Exercise1(int[] arr)     //COMPUTING SUM OF n NUMBERS
        {
            int sum = 0;
            int functionCounter = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                functionCounter++;
                sum += arr[i];
            }
            
            Console.WriteLine("Function worked " + functionCounter + " times.");
            Console.WriteLine("Summarize = " + sum);
        }
        
        private static void Exercise2(int n)         //COMPUTING N!
        {
            int factorial = 1;
            int functionCounter = 0;
            
            for (int i = 1; i <= n; i++)
            {
                functionCounter++;
                factorial *= i;
            }
            
            Console.WriteLine("Function worked " + functionCounter + " times.");
            Console.WriteLine("Factorial = " + factorial);
        }

        private static void Exercise3(int[] arr)              //FINDING LARGEST in ARRAY    
        {
            int largest = arr[0];
            int functionCounter = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                functionCounter++;
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            
            Console.WriteLine("Function worked " + functionCounter + " times.");
            Console.WriteLine("Largest = " + largest);
        }

        private static int counter = 0;
        private static int deneme(int n)
        {
            counter++;
            if (n<=0)
            {
                return n;
            }

            return deneme(n - 1) + deneme(n - 2) + deneme(n - 3);
        }

        private static int RussianOeasabtMult(int x, int y)
        {
            if (x == 1)
            {
                return y;
            }

            if (x % 2 == 1)
            {
                return y + RussianOeasabtMult(x / 2, 2 * y);
            }
            
            return  RussianOeasabtMult(x / 2, 2 * y);
        }
        
        
        
        
        
        
    }
    
    
}
namespace Algorithm_Design_and_Analysis.Algorithms.Sorting.Brute_Force
{
    public class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {
            bool isSwaped = false;
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i ; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        isSwaped = true;
                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

                if (!isSwaped)
                {
                    return arr;
                }
                
            }
            return arr;
        }
        
        
    }
}
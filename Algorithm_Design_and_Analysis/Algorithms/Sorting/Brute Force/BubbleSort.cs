namespace Algorithm_Design_and_Analysis.Algorithms.Sorting.Brute_Force
{
    public class BubbleSort
    {
        public static int[] Sort(int[] arr)   // 3-2-1-0  length 4
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i ; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;

        }
        
    }
}
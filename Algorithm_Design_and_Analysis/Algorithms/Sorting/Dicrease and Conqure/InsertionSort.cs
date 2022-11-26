namespace Algorithm_Design_and_Analysis.Algorithms.Sorting.Dicrease_and_Conqure
{
    public class InsertionSort
    {
        public static int[] Sort(int[] arr) 
        {
            for (int i = 1; i < arr.Length; i++) 
            {
                int n1 = arr[i];
                int j = i - 1;  

                while (j >= 0 && arr[j]>n1) 
                {
                    arr[j + 1] = arr[j]; 
                    j--;
                }
                arr[j + 1] = n1;
            }

            return arr;
        }
    }
}
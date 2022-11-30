namespace Algorithm_Design_and_Analysis.Algorithms.Sorting.Dicrease_and_Conqure
{
    public class InsertionSort
    {
        public static int[] Sort(int[] arr) 
        {
            for (int i = 1; i < arr.Length; i++) //2-3-1
            {
                int n1 = arr[i];   // 1 in arr
                int j = i - 1;      //1

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
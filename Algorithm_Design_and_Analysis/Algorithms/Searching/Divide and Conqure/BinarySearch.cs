namespace Algorithm_Design_and_Analysis.Algorithms.Searching.Divide_and_Conqure
{
    public class BinarySearch //Binary search only work with ordered arrays
    {
        private static bool Search_Internal (int [] arr, int targetNum, int start, int end) // O (log(n)  )
        {
            
            var midIndex = (start + end) / 2 ;

            if (start > end)
            {
                return false;
            }
            
            if (arr[midIndex] == targetNum)
            {
                return true;
            }
            
            if (arr[midIndex] > targetNum)
            {
                return Search_Internal(arr, targetNum, start,midIndex -1 );
            }

            return Search_Internal(arr, targetNum, midIndex + 1, end);
            
        }

        public static bool Search(int[] arr, int target)
        {
            return Search_Internal(arr, target, 0, arr.Length -1 );
        }
        
    }
}
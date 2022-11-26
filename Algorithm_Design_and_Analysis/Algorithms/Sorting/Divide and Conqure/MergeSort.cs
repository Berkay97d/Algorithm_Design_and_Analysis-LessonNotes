namespace Algorithm_Design_and_Analysis.Algorithms.Sorting.Divide_and_Conqure
{
    public class MergeSort
    {
        private static void Merge(int[] arr, int start, int mid, int end)    
        {    
            int[] temp = new int[arr.Length];    
            int endOfLeft, num, pos;    
            endOfLeft = (mid - 1);    
            pos = start;   
            num = (end - start + 1);     
  
            while (start <= endOfLeft && mid <= end)    
            {    
                if (arr[start] <= arr[mid])    
                    temp[pos++] = arr[start++];    
                else    
                    temp[pos++] = arr[mid++];    
            }    
            while (start <= endOfLeft)    
                temp[pos++] = arr[start++];    
            while (mid <= end)    
                temp[pos++] = arr[mid++];   
            for (int i = 0; i < num; i++)    
            {    
                arr[end] = temp[end];    
                end--;    
            }    
        }   
  
        private static void Sort_Internal(int[] arr, int start, int end)
        {    
            int mid;
            
            if (end > start)    
            {    
                mid = (end + start) / 2;    
                Sort_Internal(arr, start, mid);    
                Sort_Internal(arr, (mid + 1), end);    
                Merge(arr, start, (mid + 1), end);    
            }    
        }

        public static void Sort(int[] arr)
        {
            Sort_Internal(arr,0,arr.Length -1 );
        }
    }
}
namespace Algorithm_Design_and_Analysis.Algorithms.Searching.Brute_Force
{
    public class SequentialSearch
    {

        public static bool Search(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return true;
                }
            }
            return false;
        }
        
        
    }
}
namespace Algorithm_Design_and_Analysis.Algorithms.Sorting.Brute_Force
{
    public class SelectionSort
    {
        public static int[] SortInt(int[] arr)    //SELECTION DEĞİL BU FİXLE HOCAM
        {
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i+1; j < arr.Length ; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
        
        
        public static char[] SortString(char[] str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                int index = i;
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
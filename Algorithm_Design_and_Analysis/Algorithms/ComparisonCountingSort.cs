namespace Algorithm_Design_and_Analysis.Algorithms
{
    public class ComparisonCountingSort
    {
        public static int[] Algorithm(int[] A)
        {
            int[] counter = new int[A.Length];
            
            for (int i = 0; i < A.Length - 1 ; i++)
            {
                counter[i] = 0;
            }
            
            for (int i = 0; i <= A.Length - 2 ; i++)        
            {
                for (int j = i+1; j <= A.Length - 1 ; j++)  
                {       
                    
                    if (A[i] < A[j])                      
                    {
                        counter[j] = counter[j] + 1;
                    }
                    else
                    {
                        counter[i] = counter[i] + 1;
                    }
                    
                } 
                
            }

            int[] sorted = new int[A.Length];
            for (int i = 0; i <= A.Length - 1 ; i++)
            {
                sorted[counter[i]] = A[i];
            }

            return sorted;

        }
        
        
    }
}
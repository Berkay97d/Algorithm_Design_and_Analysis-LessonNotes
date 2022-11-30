namespace Algorithm_Design_and_Analysis.Algorithms
{ 
    public class ConsecutiveIntegerChecking
    {
        
        public static int Algorithm(int m, int n)
        {
            int t;
            t = m<n ? m : n;

            while (true)
            {
                int reminder = m % t;

                if (reminder == 0)
                {
                    int reminder2 = n % t;
                    if (reminder2 == 0 )
                    {
                        return t;
                    }
                }

                t--;
            }
        }
        
        
        
    }
}
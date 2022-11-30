namespace Algorithm_Design_and_Analysis.Algorithms
{ 
    public class Euclid
    {
        
        
        public static int Algorithm(int m, int n)
        {
            while (n!=0)
            {
                int reminder = m % n;
                m = n;
                n = reminder;
            }

            return m;
        }
        
        
        
        
        
        
        
    }
}
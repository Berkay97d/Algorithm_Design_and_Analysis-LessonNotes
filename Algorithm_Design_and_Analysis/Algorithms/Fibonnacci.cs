namespace Algorithm_Design_and_Analysis.Algorithms
{
    public class Fibonnacci             // 0-1-1-2-3-5-8-13-21-34-55-89
    {

        public static int GiveFibNums(int n)
        {
            if (n == 0)
            {
                return n;
            }

            if (n == 1)
            {
                return n;
            }

            return GiveFibNums(n + 1) + GiveFibNums(n - 1);
        }
        
        
        
    }
}
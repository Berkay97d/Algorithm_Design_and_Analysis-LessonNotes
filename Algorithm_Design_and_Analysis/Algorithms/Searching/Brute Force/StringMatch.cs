namespace Algorithm_Design_and_Analysis.Algorithms.Searching.Brute_Force
{
    public static class StringMatch
    {

        public static int Match(string text, string target)
        {
            int index = -1;
            int counter = 0;

            for (int j = 0; j < text.Length; j++)
            {
                counter++;
                
                if (text[j] == target[0]) 
                {
                    for (int i = 0; i < target.Length; i++)
                    {
                        index = j;
                        if (text[j+i] != target[i])
                        {
                            index = -1;
                            break;
                        }
                    }
                }
            }
            return index;
        }
        
        
    }
}
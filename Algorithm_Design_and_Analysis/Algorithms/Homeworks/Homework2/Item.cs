namespace Algorithm_Design_and_Analysis.Algorithms.Homework2
{
    public class Item
    {
        private readonly int weight;
        private readonly int price;
        private readonly string name;
        
        public Item(string name, int weight, int price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

        public int GetWeight()
        {
            return this.weight;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public string GetName()
        {
            return this.name;
        }
        
        
        
        
    }
}
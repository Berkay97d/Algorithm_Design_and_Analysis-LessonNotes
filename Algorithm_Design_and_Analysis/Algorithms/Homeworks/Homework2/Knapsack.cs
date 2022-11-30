using System.Collections;
using System.Collections.Generic;

namespace Algorithm_Design_and_Analysis.Algorithms.Homework2
{
    public class Knapsack
    {
        private List<Item> items = new List<Item>();
        private readonly int maxWeight;

        public Knapsack( int maxWeight)
        {
            this.maxWeight = maxWeight;
        }

        public bool isOverloaded()
        {
            int weights = 0;
            foreach (Item item in items)
            {
                weights = weights+ item.GetWeight();
            }

            if (weights > maxWeight)
            {
                return true;
            }

            return false;
        }

        public int PricesInKnapsack()
        {
            int prices = 0;
            foreach (Item item in items)
            {
                prices += item.GetPrice();
            }

            return prices;
        }
        
        public int WeightsInKnapsack()
        {
            int weights = 0;
            foreach (Item item in items)
            {
                weights += item.GetPrice();
            }

            return weights;
        }
        public List<Item> GetItems()
        {
            return this.items;
        }

    }
}
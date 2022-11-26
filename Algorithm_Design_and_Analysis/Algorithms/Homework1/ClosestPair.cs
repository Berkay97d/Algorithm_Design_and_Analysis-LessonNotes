using System;
using System.Threading;

namespace Algorithm_Design_and_Analysis.Algorithms.Homework1
{
    public class ClosestPair
    {
        public static void FindClosest(Point[] points)
        {
            double difference = 10000;
            double newDifference;
            
            Point[] closest = new Point[2];
            
            for (int i = 0; i < points.Length -1; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                      newDifference = Math.Abs( Math.Sqrt
                                        (
                                        Math.Pow(points[i].GetX() - points[j].GetX(),2) +
                                        Math.Pow(points[i].GetY() - points[j].GetY(),2)
                                        ));
                     
                     if (newDifference < difference)
                     {
                         difference = newDifference;
                         closest[0] = points[i];
                         closest[1] = points[j];
                     }
                }
            }
            
            Console.WriteLine("En yakın 2 noktan: "+ closest[0].GetX() + "," + closest[0].GetY() + " ve "+ closest[1].GetX() + "," + closest[1].GetY());
        }
        
        
    }
}
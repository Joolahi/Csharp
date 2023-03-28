using System;

class Program
{
    static void Main(string[] args)
    { 
        int totalPoints = 0;  
        int[]points = new int[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Give points:");
            int givenPoints = Int32.Parse(Console.ReadLine());
            points[i] = givenPoints;    
        }

        int smallestPoint = int.MaxValue;
        int biggestPoint = int.MinValue;

        foreach (int point in points)
        {
            totalPoints+= point;
        }
        foreach (int point in points)
        {
            if (smallestPoint > point)
            {
                smallestPoint = point;
            }
            if (biggestPoint < point) 
            { biggestPoint = point; 
            }
        }
        totalPoints = totalPoints - smallestPoint - biggestPoint;
        Console.WriteLine(totalPoints);
    }
}

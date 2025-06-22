using System;

class FinancialForecasting
{
    
    static double PredictValueRecursive(double initialValue, double growthRate, int years)
    {
        if (years == 0)
            return initialValue;

        return PredictValueRecursive(initialValue, growthRate, years - 1) * (1 + growthRate);
    }

    static void Main()
    {
        double initialValue = 1000; 
        double growthRate = 0.1;    
        int years = 5;

        double result = PredictValueRecursive(initialValue, growthRate, years);
        Console.WriteLine($"Future value after {years} years: {result:F2}");
        Console.ReadLine();
    }
}

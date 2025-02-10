namespace moscow_zoo;

public class ReportGenerator
{
    public void PrintFoodReport(List<Animal> animals)
    {
        Console.WriteLine($"Total animals: {animals.Count}");
        Console.WriteLine($"Total food consumption: {animals.Sum(a => a.Food)} kg/day");
    }
}
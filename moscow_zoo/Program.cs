using Microsoft.Extensions.DependencyInjection;
namespace moscow_zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var services = new ServiceCollection()
                .AddTransient<IInventoryService, InventoryService>();
        }
    }
}
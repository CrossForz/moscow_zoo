using Microsoft.Extensions.DependencyInjection;
namespace moscow_zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masha is zyek");
            Console.WriteLine("Hello World!");

            var services = new ServiceCollection()
                .AddTransient<IInventoryService, InventoryService>()
                .BuildServiceProvider();

            var inventoryService = services.GetRequiredService<IInventoryService>();
            var zoo = new Zoo();

// Пример использования
            var rabbit = new Rabbit(1, 2, DateTime.Now, 5);
            var monkey = new Monkey(3, 6);

            zoo.AddAnimal(rabbit);
            zoo.AddAnimal(monkey);
            inventoryService.Register(rabbit);
            inventoryService.Register(monkey);

// Вывод контактных животных
            zoo.GetContactZooAnimals().ForEach(a => 
                Console.WriteLine($"{a.GetType().Name} (Инвентарный №{a.InventoryNumber})"));
        }
    }
}
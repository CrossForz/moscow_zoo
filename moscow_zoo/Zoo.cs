namespace moscow_zoo;

public class Zoo
{
    private readonly List<Animal> _animals = new();
    private readonly VeterinaryClinic _clinic = new();

    public void AddAnimal(Animal animal)
    {
        if (_clinic.CheckHealth(animal))
        {
            _animals.Add(animal);
            Console.WriteLine($"The animal {animal.GetType().Name} is added to the clinic");
        }
        else
        {
            Console.WriteLine("This animal is already existed");
        }
    }

    public List<Animal> GetContactZooAnimals() =>
        _animals.OfType<Herbo>().Where(h => h.CanInteract).ToList<Animal>();
    
    
}
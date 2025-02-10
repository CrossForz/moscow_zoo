namespace moscow_zoo;

public class Herbo : Animal
{
    public int KindnessLevel { get; set; }
    public bool CanInteract => KindnessLevel > 5 && KindnessLevel <= 10;

    public Herbo(int _kidnesslevel, int food)
    {
        Food = food;
        if(!CanInteract) { KindnessLevel = 0;}
        else { KindnessLevel = _kidnesslevel; }
        
    }
}
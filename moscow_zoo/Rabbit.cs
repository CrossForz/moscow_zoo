namespace moscow_zoo;

public class Rabbit : Herbo
{
    public Rabbit(int kindness, int food) : base(kindness, food) {}

    public Rabbit(int kindness, int food, DateTime _time, int num) : base(kindness, food)
    {
        InventoryNumber = num;
        LastMedicalCheck= _time;

    }
}
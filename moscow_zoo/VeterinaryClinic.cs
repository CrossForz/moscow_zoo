namespace moscow_zoo;

public class VeterinaryClinic
{
    public bool CheckHealth(Animal animal)
    {
        return animal.LastMedicalCheck.Date == DateTime.Now.Date;
    }
}
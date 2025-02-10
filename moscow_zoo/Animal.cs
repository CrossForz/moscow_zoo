namespace moscow_zoo;

public abstract class Animal : IAlive, IInventory
{

    public int Food { get; set; }
    public int InventoryNumber { get; set; }
    public DateTime LastMedicalCheck { get; set; }
}
namespace moscow_zoo;

public class InventoryService : IInventoryService
{
    private readonly List<IInventory> _items = new();
    public void Register(IInventory item) => _items.Add(item);
}
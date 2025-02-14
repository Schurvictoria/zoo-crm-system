namespace Щур_В_О_КПО_1;

public abstract class Animal : IInventory
{
    public int Number { get; set; }
    public string Name { get; set; }
    public double FoodPerDay { get; set; }
    public bool IsHealthy { get; set; } = true;

    public abstract bool CanInteractWithVisitors();
}
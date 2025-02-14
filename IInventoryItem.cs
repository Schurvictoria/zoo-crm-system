using System;
namespace Щур_В_О_КПО_1;

public interface IInventory
{
    int Number { get; set; }
}

public class IInventoryItem : IInventory
{
    public int Number { get; set; }
}

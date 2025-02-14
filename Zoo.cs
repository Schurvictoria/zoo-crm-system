using System;
namespace Щур_В_О_КПО_1;

public class Zoo
{
    private readonly List<Animal> _animals = new List<Animal>();
    private readonly List<Thing> _things = new List<Thing>();
    private readonly VeterinaryClinic _clinic;

    public Zoo(VeterinaryClinic clinic)
    {
        _clinic = clinic;
    }

    public void AddAnimal(Animal animal)
    {
        if (_clinic.CheckHealth(animal))
        {
            _animals.Add(animal);
            Console.WriteLine($"{animal.Name} добавлен в зоопарк.");
        }
        else
        {
            Console.WriteLine($"{animal.Name} не принят в зоопарк из-за проблем со здоровьем.");
        }
    }

    public void RemoveAnimal(Animal animal)
    {
        _animals.Remove(animal);
        Console.WriteLine("Животное удалено из списка.");
    }


    public void AddThing(Thing thing)
    {
        _things.Add(thing);
        Console.WriteLine($"{thing.Name} добавлен в инвентарь.");
    }

    public void PrintFoodReport()
    {
        double totalFood = 0;
        foreach (var animal in _animals)
        {
            totalFood += animal.FoodPerDay;
        }
        Console.WriteLine($"Общее количество еды в день: {totalFood} кг.");
    }

    public void PrintContactZooAnimals()
    {
        Console.WriteLine("Животные для контактного зоопарка:");
        foreach (var animal in _animals)
        {
            if (animal.CanInteractWithVisitors())
            {
                Console.WriteLine($"{animal.Name} (Инвентарный номер: {animal.Number})");
            }
        }
    }

    public void PrintInventory()
    {
        Console.WriteLine("Инвентарь зоопарка:");
        foreach (var thing in _things)
        {
            Console.WriteLine($"{thing.Name} (Инвентарный номер: {thing.Number})");
        }
    }
}
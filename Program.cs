using System;
using System.Collections.Generic;
namespace Щур_В_О_КПО_1;

class Program
{
    static void Main(string[] args)
    {
        var clinic = new VeterinaryClinic();
        var zoo = new Zoo(clinic);

        while (true)
        {
            Console.WriteLine(".\n╱▔▔╲▂▂▂╱▔▔╲\n╲╱╳╱▔╲╱▔╲╱▔\n┈┈┃▏▕▍▏▕▍▏\n┈┈┃╲▂╱╲▂╱╲┈╭━╮\n┈┈┃┊┳┊┊┊┊┊▔╰┳╯\n┈┈┃┊╰━━━┳━━━╯\n┈┈┃┊┊┊┊╭╯\n");
            Console.WriteLine("\nДобро пожаловать в CRM систему для управления зоопарком!\nВыберите действие, которое Вы хотите совершить:");
            Console.WriteLine("1. Добавить животное");
            Console.WriteLine("2. Добавить вещь для взаимодействия с животным");
            Console.WriteLine("3. Вывести отчет о еде");
            Console.WriteLine("4. Вывести список животных для контактного зоопарка");
            Console.WriteLine("5. Вывести инвентарь");
            Console.WriteLine("6. Выйти из программы");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddAnimal(zoo);
                    break;
                case "2":
                    AddThing(zoo);
                    break;
                case "3":
                    zoo.PrintFoodReport();
                    break;
                case "4":
                    zoo.PrintContactZooAnimals();
                    break;
                case "5":
                    zoo.PrintInventory();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void AddAnimal(Zoo zoo)
    {
        Console.WriteLine("Выберите тип животного:");
        Console.WriteLine("1. Обезьяна");
        Console.WriteLine("2. Кролик");
        Console.WriteLine("3. Тигр");
        Console.WriteLine("4. Волк");

        var choice = Console.ReadLine();
        Animal animal = null;

        switch (choice)
        {
            case "1":
                animal = new Monkey();
                break;
            case "2":
                animal = new Rabbit();
                break;
            case "3":
                animal = new Tiger();
                break;
            case "4":
                animal = new Wolf();
                break;
            default:
                Console.WriteLine("Неверный выбор!");
                return;
        }

        Console.WriteLine("Введите инвентарный номер:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            animal.Number = number;
            zoo.AddAnimal(animal);
        }
        else
        {
            Console.WriteLine("Неверный номер.");
        }
    }

    static void AddThing(Zoo zoo)
    {
        Console.WriteLine("Выберите тип вещи:");
        Console.WriteLine("1. Стол");
        Console.WriteLine("2. Компьютер");
        Console.WriteLine("3. Медицинское оборудование");

        var choice = Console.ReadLine();
        Thing thing = null;

        switch (choice)
        {
            case "1":
                thing = new Table();
                break;
            case "2":
                thing = new Computer();
                break;
            case "3":
                thing = new MedicalDev();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                return;
        }

        Console.WriteLine("Введите инвентарный номер:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            thing.Number = number;
            zoo.AddThing(thing);
        }
        else
        {
            Console.WriteLine("Неверный номер.");
        }
    }
}
using System;
using AdditionNumber.Models;
using AdditionNumber.Managers;

class Program
{
    public static void Main(string[] args)
    {
        AdditionNumberModel input = new AdditionNumberModel();
        Console.WriteLine("Enter Number1");
        input.Number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Number2");
        input.Number2 = int.Parse(Console.ReadLine());

        AdditionNumberManagers manager = new AdditionNumberManagers();
        AdditionNumberResultModel Output = manager.Add(input);

        Console.WriteLine($"Largest Number is : {Output.Result}");
        Console.ReadKey();

    }
}
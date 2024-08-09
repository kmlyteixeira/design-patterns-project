using System;
using System.Collections.Generic;

namespace DesignPatternsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n\nChoose a Design Pattern to execute:");
                Console.WriteLine("1 - Strategy");
                Console.WriteLine("2 - Mediator");
                Console.WriteLine("3 - Factory");
                Console.WriteLine("4 - Facade");
                Console.WriteLine("5 - Decorator");
                Console.WriteLine("6 - Builder");
                Console.WriteLine("7 - Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StrategyRunner.RunStrategyPattern();
                        break;

                    case "2":
                        MediatorRunner.RunMediatorPattern();
                        break;

                    case "3":
                        FactoryRunner.RunFactoryPattern();
                        break;

                    case "4":
                        FacadeRunner.RunFacadePattern();
                        break;

                    case "5":
                        DecoratorRunner.RunDecoratorPattern();
                        break;

                    case "6":
                        BuilderRunner.RunBuilderPattern();
                        break;
                    
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        break;
                }
            }
        }
    }
}

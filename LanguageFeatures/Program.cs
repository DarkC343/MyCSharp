using System;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures
{
    // 'string' does not need a null conditional operator (no 'string?')
    // 'Dictionary' keys cannot be null (no '[null]' in index initializer, no 'null' in normal assignment)
    class Program
    {
        static void Main(string[] args)
        {
            Gadget g = new Gadget();

            foreach (var gadget in g.GetAllGadgets())
            {
                // ? is null conditional operator: for not throwing an exception if the value is null
                // ?? coalescing operator: for assigning a value of the same type is the current value is null
                var name = gadget?.Name ?? "<No Name>";
                var price = gadget?.Price ?? 0M;
                var releaseDate = gadget?.ReleaseDate ?? null;
                var relatedName = gadget?.Related?.Name ?? "<Not Related>";
                // $"{}" is string interpolation: {}s are called holess
                Console.WriteLine($"name: {name}, price: {price}, releaseDate: {releaseDate}, related: {relatedName}");
            }

            Car c = new Car();
            foreach (var car in c.GetAllCars())
            {
                var name = car?.Name ?? "<No Name>";
                var model = car?.Model ?? "<No Model>";
                var category = car?.Category ?? "<No Category>";
                var quantity = car?.Quantity ?? 0;
                Console.WriteLine(string.Format("name: {0}, model: {1}, category: {2}, quantity: {3}", name, model, category, quantity));
            }

            Dictionary<string, Car> sportCars = new Dictionary<string, Car> {
                { "Ford", new Car { Model = "Mustang" } },
                { "Chevrolet", new Car { Model = "Corvette" } },
                { string.Empty, new Car {} }
            };
            Dictionary<int, int?> d = new Dictionary<int, int?>();
            // index initializer: an easier way for assignment, eliminating { }
            var dailyGadgets = new Dictionary<string, Gadget>
            {
                ["Apple"] = new Gadget { Name = "iPhone" },
                ["Dell"] = new Gadget { Name = "XPS 15" },
                [ string.Empty ] = null,
                ["Nokia"] = null
            };

            foreach(var car in sportCars)
            {
                Console.WriteLine($"Model: {car.Key}, Name: {car.Value?.Model ?? "<No Model>"}");
            }
            foreach(var gadget in dailyGadgets)
            {
                Console.WriteLine($"Model: {gadget.Key}, Name: {gadget.Value?.Name ?? "<No Name>"}");
            }

            object[] someDate = new object[] {
                "Cucumber",
                new Car(12) { Name = "Benz" },
                new Car(5) { Name = "BMW" },
                new Car { Name = null },
                new Gadget { Name = "GPS" },
                1201,
                12.01M,
                null,
                int.MaxValue
            };
            
            foreach (var data in someDate)
            {
                // pettern mathcing
                if(data is int number)
                {
                    Console.WriteLine($"Number: {number}");
                }
                else
                {
                    // pattern matching in switch statement: can apply 'when' to add other conditional statements
                    switch (data)
                    {
                        case Car car when car.Quantity > 10:
                            Console.WriteLine($"Car: {car.Name ?? "<No Name>"} has more than 10 times of copies");
                            break;
                        case Car car when car.Quantity == null:
                            Console.WriteLine($"Car: {car.Name ?? "<No Name>"} has no clear number of copies");
                            break;
                        default:
                            Console.WriteLine($"Other: {data ?? "<No Value>"}");
                            break;
                    }
                }
            }
        }
    }
}

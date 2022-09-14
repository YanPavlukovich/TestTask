using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Mushroom { };
    internal class Egg { };
    internal class Braed { };

    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Start to cook breakfast!");

            var eggsTask = FryEggsAsync(2);
            var breadTask = FryBreadSlicesAsync(2);
            var mushroomsTask = CutMushroomAsync(5);
            var mushroomsTask2 = FryMushroomAsync();

            var breakfastTasks = new List<Task> { eggsTask, breadTask,
                mushroomsTask, mushroomsTask2 };

            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);

                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finishedTask == breadTask)
                {
                    Console.WriteLine("bread is ready");
                }
                else if (finishedTask == mushroomsTask2)
                {
                    Console.WriteLine("mushrooms are ready");
                }
                breakfastTasks.Remove(finishedTask);
            }

            Console.WriteLine("Breakfast is ready!");

            Console.ReadLine();
        }

        private static async Task<Braed> FryBreadSlicesAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bread in the pan");
            Console.WriteLine("cooking first side of bread...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bread");
            }
            Console.WriteLine("cooking the second side of bread...");
            await Task.Delay(3000);
            Console.WriteLine("Put bread on plate");

            return new Braed();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static async Task<Mushroom> CutMushroomAsync(int howMany)
        {
            Console.WriteLine("Take out the vegetable plank and knife...");
            await Task.Delay(3000);
            Console.WriteLine("Rinse the mushrooms well in water...");
            Console.WriteLine($"cutting {howMany} mushrooms");
            await Task.Delay(3000);
            Console.WriteLine("put chopped mushrooms in a bowl...");
            Console.WriteLine("mushrooms sliced");

            return new Mushroom();
        }

        private static async Task<Mushroom> FryMushroomAsync()
        {

            await Task.Delay(7000);
            Console.WriteLine("Pour the mushrooms into the hot pan...");
            await Task.Delay(3000);
            Console.WriteLine("Cooking the mushrooms...");
            await Task.Delay(3000);
            Console.WriteLine("Put mushrooms on plate");

            return new Mushroom();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal(2,"black as night on a moonless night.");
            Animal animal2 = new Animal(6,"is like rust on an abandoned ferris wheel.");

            animal1.PrintAnimalInfo();
            animal2.PrintAnimalInfo();

            Cat cat1 = new Cat("Grumpy", "Short", false, "grey");
            cat1.PrintAnimalInfo();
            cat1.Speak();

            Fish fish1 = new Fish(5, true, true, "salt");
            fish1.PrintAnimalInfo();
            fish1.Swim();
            

            Console.ReadKey();

        }

    }

}

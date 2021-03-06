﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day1
{
    class Cat : Animal
    {

        //fields
        private string breed;
        private string furLength;

        private bool declawed;

        //constructor
        public Cat(string breed,string furLength, bool declawed, string color):base(4,6,12,color)
        {
            this.breed = breed;
            this.furLength = furLength;
            this.declawed = declawed;
            this.color = color;
            isGoodToEat = false;
        }

        public void Speak()
        {
            Console.WriteLine("MEEEEOOOWWWW!");
        }


    }
}

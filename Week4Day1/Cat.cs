using System;
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
        public Cat(string breed,string furLength, bool declawed):base(4,6,12)
        {
            this.breed = breed;
            this.furLength = furLength;
            this.declawed = declawed;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public string getMake()
        {
            return Make;
        }

        public string getModel()
        {
            return Model;
        }
    }
}

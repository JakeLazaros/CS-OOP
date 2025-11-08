using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class
{
    internal class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public bool IsDriving { get; private set; }

        private Dictionary<string, int> startChances = new Dictionary<string, int>
        {
            { "BMW", 10 }, // Talking from experience here, very realistic. 10% chance.
            { "Volvo", 2 }, // 50% chance (not realistic).
            { "Honda", 1 } // 100% chance.
        };

        private Random rand = new Random();

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            IsDriving = false;
        }

        public bool StartDrive()
        {
            int startChance = rand.Next(startChances[Make]);

            return (startChance == 0 ? true : false);
        }

        public bool StopDrive()
        {
            return IsDriving = false;
        }
    }
}

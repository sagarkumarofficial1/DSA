using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.SOLIDS
{
    public interface ICar
    {
        int run();
    }

    public class BMW : ICar
    {
        public int _miles { get; set; }
        public int run()
        {
            return ++_miles;
        }
    }

    public class Ford : ICar
    {
        public int _miles { get; set; }
        public int run()
        {
            return ++_miles;
        }
    }

    public class Audi : ICar
    {
        public int _miles { get; set; }
        public int run()
        {
            return ++_miles;
        }
    }

    public class Driver
    {
        ICar _car;
        public Driver(ICar car)
        {
            _car = car;
        }
        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} ",_car.GetType(),_car.run());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{

    public abstract class Car
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract long GetPrice();
    }

    public class CompactCar:Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }
        public override string GetDescription() => Description;
        public override long GetPrice() => 2000;
    }

    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "Full Size Car";
        }
        public override string GetDescription() => Description;
        public override long GetPrice() => 5000;
    }

    public class CarDecorator: Car
    {
        public Car _Car { get; set; }
        public CarDecorator(Car car)
        {
            _Car = car;
        }

        public override string GetDescription() => _Car.GetDescription();
        public override long GetPrice() => _Car.GetPrice();
    }

    public class LeatherSeat : CarDecorator
    {

        public LeatherSeat(Car car):base(car)
        {
            Description = "Leather Seat";
        }

        public override string GetDescription() => $"{_Car.GetDescription()} {Description}";
        public override long GetPrice() => _Car.GetPrice()+200;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car car = new CompactCar();
            car = new LeatherSeat(car);

            Console.WriteLine(car.GetDescription());
            Console.WriteLine(car.GetPrice());

            Console.ReadLine();
        }
    }
}


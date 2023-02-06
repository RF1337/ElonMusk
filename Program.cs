using System;

namespace ElonMusk
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            car.Colour = "Yellow";
            car2.Colour = "Red";
            car3.Colour = "Green";
            string carColour = car.Colour;
            string car2Colour = car2.Colour;
            string car3Colour = car3.Colour;

            car.Battery = 100;
            car2.Battery = 100;
            car3.Battery = 100;
            byte carBattery = car.Battery;
            byte car2Battery = car2.Battery;
            byte car3Battery = car3.Battery;

            car.Start();
            car2.Start();
            car3.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Drive();
                car2.Drive();
                car3.Drive();
            }
            Console.WriteLine($"Car has {car.Battery}% battery. Car 2 has {car2.Battery}% " +
                $"battery & car 3 has {car3.Battery}% battery.");

            Console.WriteLine($"Car has driven {car.Distance} metres. Car 2 has driven {car2.Distance} " +
                $"metres & car 3 has driven {car3.Distance} metres");
        }
    }
}


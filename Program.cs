using System;

namespace ElonMusk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating our car objects
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            //Giving a colour to our cars
            car.Colour = "Yellow";
            car2.Colour = "Red";
            car3.Colour = "Green";
            string carColour = car.Colour;
            string car2Colour = car2.Colour;
            string car3Colour = car3.Colour;

            //Giving the battery a start value of 100 for all cars
            car.Battery = 100;
            car2.Battery = 100;
            car3.Battery = 100;
            byte carBattery = car.Battery;
            byte car2Battery = car2.Battery;
            byte car3Battery = car3.Battery;

            //Starting the cars so they can drive, if this wasn't done then they 
            //wouldn't be able to use the drive method
            car.Start();
            car2.Start();
            car3.Start();

            //Creating a ReadLine that will determine how many times you wanna use the drive method
            Console.WriteLine("How many times do you wanna drive?");
            byte howManyTimes = byte.Parse(Console.ReadLine());

            //Loop that executes the method as many times as the user has typed in the ReadLine above
            for (int i = 0; i < howManyTimes; i++)
            {
                car.Drive();
                car2.Drive();
                car3.Drive();
            }
            //Prints in the console how much battery each car has remaining
            Console.WriteLine($"Car has {car.Battery}% battery. Car 2 has {car2.Battery}% " +
                $"battery & car 3 has {car3.Battery}% battery.");

            //Prints in the console how far each car has driven
            Console.WriteLine($"Car has driven {car.Distance} metres. Car 2 has driven {car2.Distance} " +
                $"metres & car 3 has driven {car3.Distance} metres");
        }
    }
}


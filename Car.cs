using System;

namespace ElonMusk
{
    class Car
    {
        //The variable that is used for determining if the car is started/turned on or not
        public bool started = false;

        //The variable that makes it possible to give the cars a colour
        private string _colour;
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        //The variable used to determine how much battery you have left
        private byte _battery;
        public byte Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }

        //The variable used to determine how far you have driven.
        private int _distance;
        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        //Method that gets used to determine if the car can drive or not, if this method has been executed
        //then it can start.
        public void Start()
        {
            started = true;
        }

        //Method that stops the car/turns it off, if the car has been stopped - then you won't be able to use 
        //the drive method.
        public void Stop()
        {
            started = false;
        }


        //Method that drains the battery and adds the amount of metres driven per time it's executed
        public void Drive()
        {
            //It only drains battery and adds distance if the car has been started.
            if (started == true)
            {
                _battery--;
                _distance += 20;
            }
            else
            {
                Console.WriteLine("You need to start the car.");
            }
        }
    }
}


using System;

namespace ElonMusk
{
    class Car
    {
        public bool started = false;

        private string _colour;

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        private byte _battery;

        public byte Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }

        private int _distance;

        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        public void Start()
        {
            started = true;
        }

        public void Stop()
        {
            started = false;
        }

        public void Drive()
        {
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcoverage1
{
    public class Car
    {
        private int gear;
        private int speed;
        private bool lightsOn;

        public Car()
        {
            gear = 0;
            speed = 0;
            lightsOn = false;
        }

        public void GearUp()
        {
            gear++;
            Console.WriteLine($"Gear increased to {gear}");
        }

        public void GearDown()
        {
            if (gear > 0)
            {
                gear--;
                Console.WriteLine($"Gear decreased to {gear}");
            }
            else
            {
                Console.WriteLine("Already in neutral");
            }
        }

        public void Accelerate(int amount)
        {
            speed += amount;
            Console.WriteLine($"Speed increased to {speed} km/h");
        }

        public void Brake(int amount)
        {
            speed -= amount;
            if (speed < 0) speed = 0;

            Console.WriteLine($"Speed decreased to {speed} km/h");
        }

        public void ToggleLights()
        {
            lightsOn = !lightsOn;
            Console.WriteLine($"Lights are {(lightsOn ? "ON" : "OFF")}");
        }

        public void ShowState()
        {
            Console.WriteLine("---- Car State ----");
            Console.WriteLine($"Gear: {gear}");
            Console.WriteLine($"Speed: {speed} km/h");
            Console.WriteLine($"Lights: {(lightsOn ? "ON" : "OFF")}");
            Console.WriteLine("-------------------");
        }
    }
}

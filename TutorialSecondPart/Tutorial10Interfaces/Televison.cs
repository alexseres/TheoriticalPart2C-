using System;

namespace Tutorial10Interfaces
{
    public class Televison : IElectronicDevice
    {
        public int Volume{get; set; }
        
        public void On()
        {
            Console.WriteLine("The tv is ON");
        }

        public void Off()
        {
            Console.WriteLine("The tv is off");
        }

        public void VolumeUp()
        {
            if (Volume != 100)
            {
                Volume++;
                Console.WriteLine($"The TV Voluma is at {Volume}");
            }
        }

        public void VolumeDown()
        {
            if (Volume != 0)
            {
                Volume--;
                Console.WriteLine($"The TV Voluma is at {Volume}");
            }
        }
    }
}
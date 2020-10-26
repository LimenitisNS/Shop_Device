using System;
using Shop_Device.Device.Interface;

namespace Shop_Device
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shop shop = new Shop();

                Console.Write("Selected device: ");
                string choiceDevice = Console.ReadLine();

                Console.WriteLine();

                IDevice device = shop.SetDevice(choiceDevice);

                device.GetInformationDevice();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

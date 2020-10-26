using System;
using Shop_Device.Components;
using Shop_Device.Device.Interface;

namespace Shop_Device.Device
{
    class Tablet : IDevice
    {
        Display display = new Display(Display.Format.UltraHD);
        CPU cpu = new CPU(CPU.NumberCore.Cores_8);
        RAM ram = new RAM(RAM.NumberRAM.Gb_2);
        ROM rom = new ROM(ROM.NumberROM.Gb_128);

        public IDevice Clone()
        {
            return new Tablet();
        }

        public void GetInformationDevice()
        {
            Console.WriteLine(
                $"Display: {display.ToString()}\n" +
                $"CPU: {cpu.ToString()}\n" +
                $"RAM: {ram.ToString()}\n" +
                $"ROM: {rom.ToString()}\n"
                );
        }
    }
}

using System;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage device = new SSD("Lexar", "NS100", 256, 156, 5);

            device.PrintDeviceInfo();
            Storage secondDevice = new DVD("Anonym", "DVD-RW", 9, 2, 7);

            try
            {
                device.CopyMemory(secondDevice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

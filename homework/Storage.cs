using System;

namespace homework
{
    internal abstract class Storage: IStorage
    {
        protected Storage(string vendor, string model, ushort maxMemory, double busyMemory, double speed)
        {
            Vendor = vendor;
            Model = model;
            MaxMemory = maxMemory;
            BusyMemory = busyMemory;
            Speed = speed;
        }

        public string Vendor { get; set; }
        public string Model { get; set; }

        public ushort MaxMemory { get; init; }
        public double BusyMemory { get; set; }
        public double Speed { get; init; }

        public virtual void CopyMemory(Storage other)
        {
            if (other.BusyMemory + BusyMemory > other.MaxMemory) throw new ArgumentException("little storage space!");

            other.BusyMemory += BusyMemory;
            Console.WriteLine("Copy...");
            System.Threading.Thread.Sleep(Convert.ToInt32(Speed * BusyMemory));
        }
        public double FreeMemory() => Convert.ToDouble(MaxMemory - BusyMemory);
        public virtual void PrintDeviceInfo()
        {
            Console.WriteLine("Device Vendor: {0, -10} Device Model: {1, -10}", Vendor, Model);
            Console.WriteLine("Max Memory: {0}\nFree Memory: {1}\nBusy Memory {2}\n", MaxMemory, FreeMemory(), BusyMemory);
        }
    }
}

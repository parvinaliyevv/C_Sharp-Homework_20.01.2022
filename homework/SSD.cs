using System;

namespace homework
{
    internal class SSD : Storage
    {
        public SSD(string vendor, string model, ushort maxMemory, double busyMemory, double speed) : base(vendor, model, maxMemory, busyMemory, speed)
        {
        }
    }
}

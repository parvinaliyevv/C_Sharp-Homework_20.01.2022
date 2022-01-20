using System;

namespace homework
{
    internal class Flash : Storage
    {
        public Flash(string vendor, string model, ushort maxMemory, double busyMemory, double speed) : base(vendor, model, maxMemory, busyMemory, speed)
        {
        }
    }
}

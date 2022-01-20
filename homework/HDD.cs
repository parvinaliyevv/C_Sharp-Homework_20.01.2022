using System;

namespace homework
{
    internal class HDD : Storage
    {
        public HDD(string vendor, string model, ushort maxMemory, double busyMemory, double speed) : base(vendor, model, maxMemory, busyMemory, speed)
        {
        }
    }
}

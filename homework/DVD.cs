using System;

namespace homework
{
    internal class DVD : Storage
    {
        public DVD(string vendor, string model, ushort maxMemory, double busyMemory, double speed) : base(vendor, model, maxMemory, busyMemory, speed)
        {
        }
    }
}

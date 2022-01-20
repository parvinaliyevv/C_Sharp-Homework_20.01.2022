using System;

namespace homework
{
    interface IStorage
    {
        ushort MaxMemory { get; init; }
        double BusyMemory { get; set; }
        double Speed { get; init; }

        void CopyMemory(Storage other);

        double FreeMemory();

    }
}

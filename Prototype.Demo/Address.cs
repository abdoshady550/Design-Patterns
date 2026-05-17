using System;

namespace Prototype.Demo
{
    public class Address : ICloneable
    {
        public int DoorNumber { get; set; }

        public string Street { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
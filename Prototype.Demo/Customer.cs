using System;

namespace Prototype.Demo
{
    internal class Customer : ICloneable
    {
        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public DateTime BirthDate { get; set; }

        public Address Address { get; set; } = default!;

        public object ShallowCopy()
        {
            return MemberwiseClone();
        }

        public object DeepCopy()
        {
            var clone = (Customer)MemberwiseClone();

            clone.Address =
                (Address)Address.Clone();

            return clone;
        }
        public object Clone()
        {
            return DeepCopy();
        }
    }
}
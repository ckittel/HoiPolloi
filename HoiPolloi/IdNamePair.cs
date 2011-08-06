using System;

namespace HoiPolloi
{

    /// <summary>
    /// An object to represent an id/name pairing.
    /// </summary>
    public class IdNamePair
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public IdNamePair() {}

        public IdNamePair(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Id + " - " + Name;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproduceLinqpad.Data.Enums
{
    public class GenderType
    {
        public static GenderType Other = new GenderType(null, "Other");
        public static GenderType Male = new GenderType(0, "Male");
        public static GenderType Female = new GenderType(1, "Female");

        public string DisplayName { get; }
        public int? Value { get; }

        public GenderType() { }

        private GenderType(int? value, string displayName)
        {
            DisplayName = displayName;
            Value = value;
        }

        public static GenderType FromValue(int? value)
        {
            switch (value)
            {
                case null:
                    return Other;
                case 0:
                    return Male;
                case 1:
                    return Female;
            }
            throw new ArgumentException($"Could not find a gender type with value {value}.");
        }

        public static implicit operator int?(GenderType instance)
        {
            return instance.Value;
        }
    }
}

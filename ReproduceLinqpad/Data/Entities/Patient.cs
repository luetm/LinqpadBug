using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReproduceLinqpad.Data.Enums;
using ReproduceLinqpad.Interfaces;

namespace ReproduceLinqpad.Data.Entities
{
    public class Patient : IPatient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public GenderType Gender
        {
            get => GenderType.FromValue(GenderValue);
            set => GenderValue = value;
        }
        public int? GenderValue { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}

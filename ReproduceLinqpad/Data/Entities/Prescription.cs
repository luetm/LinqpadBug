using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReproduceLinqpad.Interfaces;

namespace ReproduceLinqpad.Data.Entities
{
    public class Prescription : IPrescription
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        IPatient IPrescription.Patient
        {
            get => Patient;
            set => Patient = (Patient)value;
        }
    }
}

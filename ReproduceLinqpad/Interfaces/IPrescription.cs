using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproduceLinqpad.Interfaces
{
    public interface IPrescription
    {
        int Id { get; set; }
        string Text { get; set; }

        IPatient Patient { get; set; }
        int PatientId { get; set; }
    }
}

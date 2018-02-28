using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReproduceLinqpad.Data.Enums;

namespace ReproduceLinqpad.Interfaces
{
    public interface IPatient
    {
        int Id { get; set; }
        string Name { get; set; }

        GenderType Gender { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReproduceLinqpad.Data.Entities;

namespace ReproduceLinqpad.Data.Configuration
{
    public class PatientConfiguration : EntityTypeConfiguration<Patient>
    {
        public PatientConfiguration()
        {
            Property(p => p.Name)
                .HasMaxLength(100);
            Ignore(p => p.Gender);
        }
    }
}

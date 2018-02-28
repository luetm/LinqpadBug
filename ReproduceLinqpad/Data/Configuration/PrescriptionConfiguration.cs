using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReproduceLinqpad.Data.Entities;

namespace ReproduceLinqpad.Data.Configuration
{
    public class PrescriptionConfiguration : EntityTypeConfiguration<Prescription>
    {
        public PrescriptionConfiguration()
        {
            Property(p => p.Text)
                .HasMaxLength(200);
        }
    }
}

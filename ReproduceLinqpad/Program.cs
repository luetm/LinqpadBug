using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReproduceLinqpad.Data;
using ReproduceLinqpad.Data.Entities;
using ReproduceLinqpad.Data.Enums;

namespace ReproduceLinqpad
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TestContext())
            {
                // Use ReproduceLinqpad.exe --create
                if (args.Contains("--create"))
                {
                    var patients = new List<Patient>
                    {
                        new Patient {Name = "John Doe", Gender = GenderType.Male},
                        new Patient {Name = "Jane Doe", Gender = GenderType.Female},
                    };
                    db.Patients.AddRange(patients);
                    Console.WriteLine("Saving patients ... ");
                    db.SaveChanges();

                    var prescriptions = new List<Prescription>
                    {
                        new Prescription {PatientId = 1, Text = "PLACEBO FORTE 500mg pill [50pcs]"},
                        new Prescription {PatientId = 2, Text = "PSEUDOCOL 5% sol. [50ml]"},
                        new Prescription {PatientId = 2, Text = "CURAFIX 20mg pill [1pcs]"},
                    };
                    db.Prescriptions.AddRange(prescriptions);
                    Console.WriteLine("Saving prescriptions ... ");
                    db.SaveChanges();
                }
                // Use ReproduceLinqpad.exe
                else
                {
                    var patients = db.Patients
                        .Include("Prescriptions")
                        .ToList();

                    foreach (var patient in patients)
                    {
                        Console.WriteLine($"Patient ID={patient.Id} '{patient.Name}', {patient.Gender.DisplayName}");
                        foreach (var prescription in patient.Prescriptions)
                        {
                            Console.WriteLine($"|- {prescription.Text}");
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

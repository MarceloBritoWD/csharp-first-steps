using System;
using System.Collections.Generic;

namespace OdontologyClinic.Model
{
    public class MedicalCare
    {

        public Patient Patient { get; set; }
        public Procedure Procedure { get; set; }
        public DateTime Date { get; set; }

    }
}

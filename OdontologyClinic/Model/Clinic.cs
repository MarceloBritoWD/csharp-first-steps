using System;
using System.Collections.Generic;

namespace OdontologyClinic.Model
{
    public class Clinic
    {

        public string Name { get; set; }
        List<Patient> Patients = new List<Patient>();

        public void ResgisterPatient(Patient patient)
        {
            Patients.Add(patient);
        }


        public List<Patient> GetPatients() {
            return Patients;
        }

    }
}

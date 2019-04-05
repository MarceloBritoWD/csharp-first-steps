using System;
using System.Collections.Generic;

namespace OdontologyClinic.Model
{
    public class Clinic
    {

        public string Name { get; set; }
        List<Patient> Patients = new List<Patient>();
        List<Procedure> Procedures = new List<Procedure>();
        public List<MedicalCare> MedicalCares = new List<MedicalCare>();

        public Clinic() {
            LoadDefaultProcedures();
        }

        public void ResgisterPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public void ResgisterProcedure(Procedure procedure)
        {
            Procedures.Add(procedure);
        }

        public List<Patient> GetPatients() {
            return Patients;
        }

        public List<Procedure> GetProcedures()
        {
            return Procedures;
        }

        public List<MedicalCare> GetMedicalCares()
        {
            return MedicalCares;
        }

        private void LoadDefaultProcedures()
        {
            List<string> defaultProcedures = new List<string> { "ClareamentoDental", "TratamentoOrtodontico", "Implante", "Extracao", "EnxertoGengival", "Restauracao", "Canal" };

            int count = 1;
            defaultProcedures.ForEach((item) =>
            {
                this.ResgisterProcedure(new Procedure(item, count * 1.22));
                count = count + 1;
            });

        }




    }
}

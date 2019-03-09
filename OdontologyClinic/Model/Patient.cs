using System;
namespace OdontologyClinic
{
    public class Patient
    {

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Patient(string name,  DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }
    }
}

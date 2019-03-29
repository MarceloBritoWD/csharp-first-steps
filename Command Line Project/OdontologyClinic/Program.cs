using System;
using System.Collections.Generic;
using OdontologyClinic.Model;

namespace OdontologyClinic
{
    class MainClass
    {
        private static Clinic clinic = new Clinic();

        public static void Main(string[] args)
        {

            do
            {

                Console.Clear();

                Console.WriteLine("Welcome to the greatest odontology clinic system!");
                Console.WriteLine("Please, select what you wanna do:");
                Console.WriteLine("1 - Register a new patient");
                Console.WriteLine("2 - List all patients");
                Console.WriteLine("3 - Register a procedure");
                Console.WriteLine("4 - List all procedures");
                Console.WriteLine("5 - Perform a medical care");
                Console.WriteLine("6 - List all medical cares");
                Console.WriteLine("7 - Exit");

                string valuereaded = Console.ReadLine();





                switch (int.Parse(valuereaded))
                {
                    case 1:
                        Console.WriteLine("You selected the option 1, lets proced with that:");
                        ResgisterPatient();
                        break;

                    case 2:
                        Console.WriteLine("You selected the option 2, lets proced with that:");
                        ListAllPatients();
                        break;

                    case 3:
                        Console.WriteLine("You selected the option 3, lets proced with that:");
                        ResgisterProcedure();
                        break;

                    case 4:
                        Console.WriteLine("You selected the option 3, lets proced with that:");
                        ListAllProcedures();
                        break;

                    case 5:
                        Console.WriteLine("You selected the option 4, lets proced with that:");
                        performMedicalCare();
                        break;

                    case 6:
                        Console.WriteLine("You selected the option 3, lets proced with that:");
                        ListAllMedicalCare();
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;
                }



                Console.ReadKey();
            } while (true);
        }


        private static void ResgisterPatient() {
            Console.WriteLine("### Insert the name of the patient ###");
            string name = Console.ReadLine();

            clinic.ResgisterPatient(new Patient(name, new DateTime(1995, 5, 3)));
            Console.WriteLine("Patient registered!");
        }


        private static void ListAllPatients() {
            Console.WriteLine("#### Listing all the patients ####");
            List<Patient> patients = clinic.GetPatients();
            int index = 1;
            patients.ForEach((Patient obj) => {
                Console.WriteLine(index + " - " + obj.Name);
                index++;
            });
        }

        private static void ListAllProcedures()
        {
            Console.WriteLine("#### Listing all the procedures ####");
            List<Procedure> procedures = clinic.GetProcedures();
            int index = 1;
            procedures.ForEach((Procedure obj) => {
                Console.WriteLine(index + " - " + obj.Name);
                index++;
            });
        }

        private static void ListAllMedicalCare()
        {
            Console.WriteLine("#### Listing all the medical cares ####");
            List<MedicalCare> mcs = clinic.GetMedicalCares();

            mcs.ForEach((MedicalCare obj) => {
                Console.WriteLine("Patient Name - " + obj.Patient.Name);
                Console.WriteLine("Procedure Name - " + obj.Procedure.Name);
                Console.WriteLine("Date - " + obj.Date);

            });
        }


        private static void ResgisterProcedure()
        {
            Console.WriteLine("### Insert the name of the procedure ###");
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            clinic.ResgisterProcedure(new Procedure(name, price));
            Console.WriteLine("Procedure registered!");
        }




        private static void performMedicalCare()
        {

            ListAllPatients();
            ListAllProcedures();

            MedicalCare medicalCare = new MedicalCare();


            Console.WriteLine("### Insert the id of the Patient ###");
            int patientId = int.Parse(Console.ReadLine());

            int count = 1;
            clinic.GetPatients().ForEach((item) =>
            {
                if(count == patientId) {
                    medicalCare.Patient = item;
                }

                count++;
            });
            Console.WriteLine("### Patient added to the medical care: " + medicalCare.Patient.Name + " ###");




            Console.WriteLine("### Insert the id of the Procedure ###");
            int procedureId = int.Parse(Console.ReadLine());

            int count2 = 1;
            clinic.GetProcedures().ForEach((item) =>
            {
                if (count2 == patientId)
                {
                    medicalCare.Procedure = item;
                }

                count2++;
            });
            Console.WriteLine("### Procedure added to the medical care " + medicalCare.Procedure.Name + " ###");


            medicalCare.Date = new DateTime();


            clinic.MedicalCares.Add(medicalCare);
        }

    }
}

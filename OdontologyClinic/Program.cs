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

                Console.WriteLine("Welcome to the greates odontology clinic system!");
                Console.WriteLine("Please, select what you wanna do:");
                Console.WriteLine("1 - Register a new patient");
                Console.WriteLine("2 - Search for a patient");
                Console.WriteLine("3 - Register a procedure");
                Console.WriteLine("4 - Perform a medical care");
                Console.WriteLine("5 - Exit");

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
                        break;

                    case 4:
                        Console.WriteLine("You selected the option 4, lets proced with that:");
                        break;

                    case 5:
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


    }
}

using System;
namespace Library
{
    public class Paciente{
        private string name {get; set;}
        private int edad {get; set;}
        private string phoneNumber {get; set;}
        public Boolean isValid = true;

        public Paciente (string name, int edad, string phoneNumber) {
            if (string.IsNullOrEmpty(name))
            {
                isValid = false;
            }
            if (string.IsNullOrEmpty(phoneNumber))
            {
                isValid = false;
            }
            if (isValid)
            {   
                this.name = name;
                this.edad = edad;
                this.phoneNumber = phoneNumber;
                Console.WriteLine("Paciente creado.");
            }else{
                Console.WriteLine("No se pudo crear el paciente, faltan datos.");
            }

        }

    }
}
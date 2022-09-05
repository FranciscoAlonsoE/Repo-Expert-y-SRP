using System;
namespace Library
{
    public class Doctor{
        private string name {get; set;}
        private string especialidad {get; set;}
        public Boolean isValid = true;

        public Doctor (string name, string especialidad) {
            if (string.IsNullOrEmpty(name))
            {
                isValid = false;
            }
            if (string.IsNullOrEmpty(especialidad))
            {
                isValid = false;
            }
            if (isValid)
            {   
                this.name = name;
                this.especialidad = especialidad;
                Console.WriteLine("Doctor creado.\n");
            }else{
                Console.WriteLine("No se pudo crear el doctor, faltan datos.\n");
                
            }

        }

    }
}
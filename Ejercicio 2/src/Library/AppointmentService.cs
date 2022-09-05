using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /* Se deberian crear clases separadas para guardar los datos del paciente y el medico como objetos, y asi 
        pasarle al metodo CreateAppointment directamente esos objetos. De esta forma separamos las responsabilidades
        para cumplir con los principios. 
        Ademas agregar una propiedad de la clase para registar el id y que de esta forma sea unico.*/

        private static int id = 0; 
        public static string CreateAppointment(Paciente paciente, DateTime date, string appoinmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
            if(!paciente.isValid){
                stringBuilder.Append("Unable to schedule appointment, 'patient' is required\n");
                isValid = false;
            }
            if(!doctor.isValid){
                stringBuilder.Append("Unable to schedule appointment, 'doctor' is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }
            if (isValid)
            {
                id += 1;
                stringBuilder.Append($"Appoinment scheduled, the id numer is {id}");
            }

            return stringBuilder.ToString();
        }

    }
}

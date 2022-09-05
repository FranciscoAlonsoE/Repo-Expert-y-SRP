using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Armand", "Pediatra");
            Paciente paciente1 = new Paciente("Steven Jhonson", 25, "5555-555-555");
            string appointmentResult = AppointmentService.CreateAppointment(paciente1, DateTime.Now, "Wall Street", doctor1);
            Console.WriteLine(appointmentResult);
            Doctor doctor2 = new Doctor("", "Doctor general");
            Paciente paciente2 = new Paciente("Ralf Manson", 35, "5555-555-555");
            string appointmentResult2 = AppointmentService.CreateAppointment(paciente2, DateTime.Now, "Queen Street", doctor2);
            Console.WriteLine(appointmentResult2);
        }
    }
}

using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        #region Show Main Menu

        static void ShowMenu()
        {
            string employeeId = string.Empty;
            string employeeName = string.Empty;
            byte employeeRole = 0;

            Console.WriteLine("Identificación del empleado: ");
            employeeId = Console.ReadLine()!;

            Console.WriteLine("\nNombre del empleado: ");
            employeeName = Console.ReadLine()!;

            Console.WriteLine("\nRol del empleado: ");
            Console.WriteLine("1 = Operario \n2 = Técnico \n3 = Profesional");
            employeeRole = byte.Parse(Console.ReadLine()!);

            Console.Clear();
            RoleValidation(employeeRole);
        }

        #endregion

        #region Employee Role Validation

        static void RoleValidation(byte employeeRole)
        {
            switch (employeeRole)
            {
                case 1:
                    Console.WriteLine("Se ha seleccionado el rol: Operario");
                    OperatorPayment();
                    Console.Clear();
                    PaymentReport();
                    break;

                case 2:
                    Console.WriteLine("Se ha seleccionado el rol: Técnico");
                    TechnicianPayment();
                    Console.Clear();
                    PaymentReport();
                    break;

                case 3:
                    Console.WriteLine("Se ha seleccionado el rol: Profesional");
                    ProfessionalPayment();
                    Console.Clear();
                    PaymentReport();
                    break;
            }
        }

        #endregion

        #region Role Payment and Raise

        // this function calculates the payment for an operator
        static void OperatorPayment()
        {
            byte workedHours = 0;
            float raise = 1.15f;
            float hourSalary = 0;
            float grossSalary = 0;
            float ssDeduction = 0.0917f;
            float netSalary = 0;

            Console.WriteLine("\nSalario a pagar por hora: ");
            hourSalary = float.Parse(Console.ReadLine()!);

            Console.WriteLine("\nIngrese las horas laboradas: ");
            workedHours = byte.Parse(Console.ReadLine()!);

            grossSalary = (hourSalary * workedHours) * raise;

            netSalary = (float) (grossSalary * (1 - ssDeduction));

        }

        // this function calculates the payment for a technician
        static void TechnicianPayment()
        {
            byte workedHours = 0;
            float raise = 1.10f;
            float hourSalary = 0;
            float grossSalary = 0;
            float ssDeduction = 0.0917f;
            float netSalary = 0;

            Console.WriteLine("\nSalario a pagar por hora: ");
            hourSalary = float.Parse(Console.ReadLine()!);

            Console.WriteLine("\nIngrese las horas laboradas: ");
            workedHours = byte.Parse(Console.ReadLine()!);

            grossSalary = (hourSalary * workedHours) * raise;

            netSalary = (float)(grossSalary * (1 - ssDeduction));
        }

        //this function calculates the payment for a professional
        static void ProfessionalPayment()
        {
            byte workedHours = 0;
            float raise = 1.05f;
            float hourSalary = 0;
            float grossSalary = 0;
            float ssDeduction = 0.0917f;
            float netSalary = 0;

            Console.WriteLine("\nSalario a pagar por hora: ");
            hourSalary = float.Parse(Console.ReadLine()!);

            Console.WriteLine("\nIngrese las horas laboradas: ");
            workedHours = byte.Parse(Console.ReadLine()!);

            grossSalary = (hourSalary * workedHours) * raise;

            netSalary = (float)(grossSalary * (1 - ssDeduction));
        }

        #endregion

        #region Show Payment Report

        // this method shows the detailed payment report
        static void PaymentReport()
        {
            // TODO: IMPLEMENTAR FUNCIONALIDAD DEL REPORTE DETALLADO DE PAGO
            Console.WriteLine("Resumen de pago\n");

            Console.WriteLine("Cédula del empleado: ");
            Console.WriteLine("Nombre del empleado: ");
            Console.WriteLine("Tipo de empleado: ");
            Console.WriteLine("Salario por hora: ");
            Console.WriteLine("Cantidad de horas: ");
            Console.WriteLine("Salario ordinario: ");
            Console.WriteLine("Aumento: ");
            Console.WriteLine("Salario bruto: ");
            Console.WriteLine("Deducción CCSS: ");
            Console.WriteLine("Salario neto: ");
        }
        
        #endregion
    }
}

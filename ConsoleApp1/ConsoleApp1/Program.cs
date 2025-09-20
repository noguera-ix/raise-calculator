using System;

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
                    break;

                case 2:
                    Console.WriteLine("Se ha seleccionado el rol: Técnico");
                    TechnicianPayment();
                    break;

                case 3:
                    Console.WriteLine("Se ha seleccionado el rol: Profesional");
                    ProfessionalPayment();
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

            Console.WriteLine("\nIngrese el salario del empleado: ");
            hourSalary = float.Parse(Console.ReadLine()!);

            Console.WriteLine("\nIngrese las horas laboradas: ");
            workedHours = byte.Parse(Console.ReadLine()!);

            grossSalary = (hourSalary * workedHours) * raise;
            Console.WriteLine("\nSalario reportado: " + grossSalary.ToString());
        }

        // this function calculates the payment for a technician
        static void TechnicianPayment()
        {
            byte workedHours = 0;
            float raise = 1.10f;
            float hourSalary = 0;
            float grossSalary = 0;

            Console.WriteLine("\nIngrese el salario del empleado: ");
            hourSalary = float.Parse(Console.ReadLine()!);

            Console.WriteLine("\nIngrese las horas laboradas: ");
            workedHours = byte.Parse(Console.ReadLine()!);

            grossSalary = (hourSalary * workedHours) * raise;
            Console.WriteLine("\nSalario reportado: " + grossSalary.ToString());
        }

        //this function calculates the payment for a professional
        static void ProfessionalPayment()
        {
            byte workedHours = 0;
            float raise = 1.05f;
            float hourSalary = 0;
            float grossSalary = 0;

            Console.WriteLine("\nIngrese el salario del empleado: ");
            hourSalary = float.Parse(Console.ReadLine()!);

            Console.WriteLine("\nIngrese las horas laboradas: ");
            workedHours = byte.Parse(Console.ReadLine()!);

            grossSalary = (hourSalary * workedHours) * raise;
            Console.WriteLine("\nSalario reportado: " + grossSalary.ToString());
        }

        #endregion
    }
}

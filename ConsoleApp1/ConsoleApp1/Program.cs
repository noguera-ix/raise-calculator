using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public float HourSalary { get; set; }
        public byte WorkedHours { get; set; }
        public float Raise { get; set; }
        public float GrossSalary { get; set; }
        public float NetSalary { get; set; }
    }
     
    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            string answer;

            do
            {
                Employee emp = new Employee();
                ShowMenu(emp);
                employees.Add(emp);

                Console.WriteLine("\n¿Desea agregar otro empleado? (s/n)");
                answer = Console.ReadLine()!.ToLower();

                Console.Clear();

            } while (answer == "s");

            ShowGeneralReport();
        }

        static void ShowMenu(Employee emp)
        {
            Console.WriteLine("Identificación del empleado: ");
            emp.Id = Console.ReadLine()!;

            Console.WriteLine("\nNombre del empleado: ");
            emp.Name = Console.ReadLine()!;

            Console.WriteLine("\nRol del empleado: ");
            Console.WriteLine("1 = Operario \n2 = Técnico \n3 = Profesional");
            byte rol = byte.Parse(Console.ReadLine()!);

            Console.Clear();
            RoleValidation(rol, emp);
        }

        static void RoleValidation(byte rol, Employee emp)
        {
            switch (rol)
            {
                case 1:
                    emp.Role = "Operario";
                    emp.Raise = 1.15f;
                    Console.WriteLine("Se ha seleccionado el rol: Operario");
                    CalculatePayment(emp);
                    break;

                case 2:
                    emp.Role = "Técnico";
                    emp.Raise = 1.10f;
                    Console.WriteLine("Se ha seleccionado el rol: Técnico");
                    CalculatePayment(emp);
                    break;

                case 3:
                    emp.Role = "Profesional";
                    emp.Raise = 1.05f;
                    Console.WriteLine("Se ha seleccionado el rol: Profesional");
                    CalculatePayment(emp);
                    break;
            }

            Console.Clear();
            PaymentReport(emp);
        }

        static void CalculatePayment(Employee emp)
        {
            float ssDeduction = 0.0917f;

            Console.WriteLine("\nSalario a pagar por hora: ");
            emp.HourSalary = float.Parse(Console.ReadLine()!);

            Console.WriteLine("\nIngrese las horas laboradas: ");
            emp.WorkedHours = byte.Parse(Console.ReadLine()!);

            emp.GrossSalary = (emp.HourSalary * emp.WorkedHours) * emp.Raise;
            emp.NetSalary = emp.GrossSalary * (1 - ssDeduction);
        }

        static void PaymentReport(Employee emp)
        {
            Console.WriteLine("Resumen de pago\n");

            Console.WriteLine($"Cédula del empleado: {emp.Id}");
            Console.WriteLine($"Nombre del empleado: {emp.Name}");
            Console.WriteLine($"Tipo de empleado: {emp.Role}");
            Console.WriteLine($"Salario por hora: {emp.HourSalary}");
            Console.WriteLine($"Cantidad de horas: {emp.WorkedHours}");
            Console.WriteLine($"Aumento aplicado: {emp.Raise}");
            Console.WriteLine($"Salario bruto: {emp.GrossSalary}");
            Console.WriteLine($"Deducción CCSS: 9.17%");
            Console.WriteLine($"Salario neto: {emp.NetSalary}");
        }

        static void ShowGeneralReport()
        {
            Console.WriteLine("Reporte general\n");

            int countOperario = 0, countTecnico = 0, countProfesional = 0;
            float totalOperario = 0, totalTecnico = 0, totalProfesional = 0;

            foreach (var emp in employees)
            {
                switch (emp.Role)
                {
                    case "Operario":
                        countOperario++;
                        totalOperario += emp.NetSalary;
                        break;
                    case "Técnico":
                        countTecnico++;
                        totalTecnico += emp.NetSalary;
                        break;
                    case "Profesional":
                        countProfesional++;
                        totalProfesional += emp.NetSalary;
                        break;
                }
            }

            Console.WriteLine($"Cantidad empleados tipo operario: {countOperario}");
            Console.WriteLine($"Acumulado salario neto para operarios: {totalOperario}");
            Console.WriteLine($"Promedio salario neto para operarios: {(countOperario > 0 ? totalOperario / countOperario : 0)}\n");

            Console.WriteLine($"Cantidad empleados tipo técnico: {countTecnico}");
            Console.WriteLine($"Acumulado salario neto para técnicos: {totalTecnico}");
            Console.WriteLine($"Promedio salario neto para técnicos: {(countTecnico > 0 ? totalTecnico / countTecnico : 0)}\n");

            Console.WriteLine($"Cantidad empleados tipo profesional: {countProfesional}");
            Console.WriteLine($"Acumulado salario neto para profesionales: {totalProfesional}");
            Console.WriteLine($"Promedio salario neto para profesionales: {(countProfesional > 0 ? totalProfesional / countProfesional : 0)}");
        }
    }
}

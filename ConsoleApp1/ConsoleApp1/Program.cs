using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Empleado
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public float SalarioPorHora { get; set; }
        public byte HorasTrabajadas { get; set; }
        public float Aumento { get; set; }
        public float SalarioBruto { get; set; }
        public float SalarioNeto { get; set; }
    }

    class Program
    {
        static List<Empleado> empleados = new List<Empleado>();

        static void Main(string[] args)
        {
            string respuesta;

            do
            {
                Empleado emp = new Empleado();
                ShowMenu(emp);
                empleados.Add(emp);

                Console.WriteLine("\n¿Desea agregar otro empleado? (s/n)");
                respuesta = Console.ReadLine()!.ToLower();

                Console.Clear();

            } while (respuesta == "s");

            MostrarReporteGeneral();
        }

        static void ShowMenu(Empleado emp)
        {
            Console.WriteLine("Identificación del empleado: ");
            emp.Id = Console.ReadLine()!;

            Console.WriteLine("\nNombre del empleado: ");
            emp.Nombre = Console.ReadLine()!;

            Console.WriteLine("\nRol del empleado: ");
            Console.WriteLine("1 = Operario \n2 = Técnico \n3 = Profesional");
            byte rol = byte.Parse(Console.ReadLine()!);

            Console.Clear();
            RoleValidation(rol, emp);
        }

        static void RoleValidation(byte rol, Empleado emp)
        {
            switch (rol)
            {
                case 1:
                    emp.Rol = "Operario";
                    emp.Aumento = 1.15f;
                    Console.WriteLine("Se ha seleccionado el rol: Operario");
                    CalcularPago(emp);
                    break;

                case 2:
                    emp.Rol = "Técnico";
                    emp.Aumento = 1.10f;
                    Console.WriteLine("Se ha seleccionado el rol: Técnico");
                    CalcularPago(emp);
                    break;

                case 3:
                    emp.Rol = "Profesional";
                    emp.Aumento = 1.05f;
                    Console.WriteLine("Se ha seleccionado el rol: Profesional");
                    CalcularPago(emp);
                    break;
            }

            Console.Clear();
            PaymentReport(emp);
        }

        static void CalcularPago(Empleado emp)
        {
            float ssDeduction = 0.0917f;

            Console.WriteLine("\nSalario a pagar por hora: ");
            emp.SalarioPorHora = float.Parse(Console.ReadLine()!);

            Console.WriteLine("\nIngrese las horas laboradas: ");
            emp.HorasTrabajadas = byte.Parse(Console.ReadLine()!);

            emp.SalarioBruto = (emp.SalarioPorHora * emp.HorasTrabajadas) * emp.Aumento;
            emp.SalarioNeto = emp.SalarioBruto * (1 - ssDeduction);
        }

        static void PaymentReport(Empleado emp)
        {
            Console.WriteLine("Resumen de pago\n");

            Console.WriteLine($"Cédula del empleado: {emp.Id}");
            Console.WriteLine($"Nombre del empleado: {emp.Nombre}");
            Console.WriteLine($"Tipo de empleado: {emp.Rol}");
            Console.WriteLine($"Salario por hora: {emp.SalarioPorHora}");
            Console.WriteLine($"Cantidad de horas: {emp.HorasTrabajadas}");
            Console.WriteLine($"Aumento aplicado: {emp.Aumento}");
            Console.WriteLine($"Salario bruto: {emp.SalarioBruto}");
            Console.WriteLine($"Deducción CCSS: 9.17%");
            Console.WriteLine($"Salario neto: {emp.SalarioNeto}");
        }

        static void MostrarReporteGeneral()
        {
            Console.WriteLine("Reporte general\n");

            int countOperario = 0, countTecnico = 0, countProfesional = 0;
            float totalOperario = 0, totalTecnico = 0, totalProfesional = 0;

            foreach (var emp in empleados)
            {
                switch (emp.Rol)
                {
                    case "Operario":
                        countOperario++;
                        totalOperario += emp.SalarioNeto;
                        break;
                    case "Técnico":
                        countTecnico++;
                        totalTecnico += emp.SalarioNeto;
                        break;
                    case "Profesional":
                        countProfesional++;
                        totalProfesional += emp.SalarioNeto;
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

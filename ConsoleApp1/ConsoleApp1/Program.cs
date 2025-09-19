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
                    break;

                case 2:
                    Console.WriteLine("Se ha seleccionado el rol: Técnico");
                    break;

                case 3:
                    Console.WriteLine("Se ha seleccionado el rol: Profesional");
                    break;
            }
        }
        #endregion

        #region Role Payment and Raise
        // the function to create the payment and salary raise has to be developed
        #endregion
    }
}

using System;

class Program()
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
        employeeId = Console.ReadLine();

        Console.WriteLine("\nNombre del empleado: ");
        employeeName = Console.ReadLine();

        Console.WriteLine("\nRol del empleado: ");
        Console.WriteLine("1 = Operario \n2 = Técnico \n3 = Profesional");
        employeeRole = byte.Parse(Console.ReadLine());
    }
    #endregion

    #region Employee Role Validation
    //the function to verify the employee's role has to be created

    #endregion
}
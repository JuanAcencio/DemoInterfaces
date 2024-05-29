using DemoInterfaces;
Console.WriteLine("Demostracion de la implementacion de interfaces\n");

Console.WriteLine("Demostracion de la relacion de herencia en una nomina.\n");
List<Empleado> empleados = new List<Empleado>();

empleados.Add(new Empleado("Maria", "Moreno", "MOMA19570824ABC", new DateTime(2016, 6, 16), 350.0M));
empleados.Add(new Empleado("Alberto", "Arjona", "ARAL19970314DEF", new DateTime(2022, 1, 1), 350.0M));
empleados.Add(new Empleado("Raul", "Ramires", "RARA19850801GHI", new DateTime(2020, 1, 1), 425.0M));
empleados.Add(new Empleado("Josefina", "Juarez", "JUJO19950915JKL", new DateTime(2021, 3, 16), 375.0M));

foreach (var empleado in empleados)
{
    ImprimirInformacionDeEmpleado(empleado);
}

void ImprimirInformacionDeEmpleado(Empleado empleado)
{
    Console.WriteLine($"Nombre completo:{empleado.NombreCompleto}");
    Console.WriteLine($"Rfc:{empleado.Rfc}");
    Console.WriteLine($"Fecha de ingreso:{empleado.FechaDeIngreso}");
    Console.WriteLine($"Salario del periodo:{empleado.CalcularSalario()}");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Empleado");
Console.WriteLine();


Console.WriteLine("Ingrese su nombre:");
string nombre = (Console.ReadLine());

Console.WriteLine("Ingrese su cargo:");
string cargo = (Console.ReadLine());

Console.WriteLine("Ingrese su sueldo");
decimal sueldo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine();
Console.WriteLine();

DatosEmpleados(nombre, cargo, sueldo);


static void DatosEmpleados(string nombre, string cargo, decimal sueldo)
{
    Console.WriteLine($"Su nombre es {nombre} y es encargada de {cargo}. su sueldo es de {sueldo} pesos mensuales");
}

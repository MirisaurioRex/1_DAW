using System;
class Persona
{
	string nombre;

	public void SetNombre(string nuevoNombre)
    {
		nombre = nuevoNombre;
    }
	public void Saludar()
	{
        Console.WriteLine("Hola, soy {0}", nombre);
	}
}//fin Persona

class Ejercicio_6_2_1
{
	public static void Main()
	{
		Persona persona1 = new Persona();
		persona1.SetNombre("María");

		Persona persona2 = new Persona();
		persona2.SetNombre("Paco");

		persona1.Saludar();
		persona2.Saludar();

	}//fin del main
}

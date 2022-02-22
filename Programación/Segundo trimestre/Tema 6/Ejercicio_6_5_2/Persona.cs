using System;

class Persona
{
	protected string texto;
	protected string nombre;

	public void SetNombre(string nuevoNombre)
	{
		nombre = nuevoNombre;
	}
	public void Saludar()
	{
		Console.WriteLine("Hola, soy {0}", nombre);
	}
	public void Saludar(string saludo)
    {
        Console.WriteLine(saludo);
    }
}//fin Persona
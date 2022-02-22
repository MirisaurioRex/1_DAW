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


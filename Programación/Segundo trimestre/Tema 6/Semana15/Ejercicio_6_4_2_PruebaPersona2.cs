using System;
class Ejercicio_6_4_2
{
	public static void Main()
	{
		Persona persona1 = new Persona();
		persona1.SetNombre("María");

		Persona persona2 = new Persona();
		persona2.SetNombre("Paco");

		PersonaInglesa persona3	= new PersonaInglesa();
		persona3.SetNombre("Charles");

		persona1.Saludar();
		persona2.Saludar();
		persona3.Saludar();
		persona3.TomarTe();

	}//fin del main
}

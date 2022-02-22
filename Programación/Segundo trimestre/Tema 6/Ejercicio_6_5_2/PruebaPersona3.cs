using System;
class Ejercicio_6_5_2
{
	public static void Main()
	{
		Persona persona1 = new Persona();
		persona1.SetNombre("Carlota");
		persona1.Saludar("Buenas tardes");

		PersonaItaliana persona2 = new PersonaItaliana();
		persona2.SetNombre("Andrea");
		persona2.Saludar();

		PersonaInglesa persona3 = new PersonaInglesa();
		persona3.Saludar();
		persona3.TomarTe();

	}//fin del main
}
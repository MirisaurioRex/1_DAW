
/*(2.2.2.1) Crea un programa que pida números positivos al usuario, y vaya 
calculando y mostrando la suma de todos ellos (terminará cuando se teclea un 
número negativo o cero).*/

using System;

public class Ejercicio_2_2_2_1
{
	public static void Main()
	{
		int n1;
		int n2;
		int suma;
		
		do
		{
			Console.WriteLine("Escribe dos números positivos");
			n1 = Convert.ToInt32(Console.ReadLine());
			n2 = Convert.ToInt32(Console.ReadLine());
			
			suma = n1+n2;
			
			Console.WriteLine(suma);
			
			}
		while (n1 != 0 && n2 != 0);
		
			Console.WriteLine("Has introducido un número incorrecto");
	}
}

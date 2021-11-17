
/*(3.2.3.1) Calcula el volumen de una esfera, dado su radio, que será un número de
doble precisión (volumen = pi * radio al cubo * 4/3)*/

using System;

public class Ejercicio_3_2_3_1
{
	public static void Main()
	{
		double volumen;
		double PI = 3.14159;
		int radio;
		
		Console.Write("Elige el radio de la esfera: ");
		radio = Convert.ToInt32(Console.ReadLine());
		
		volumen = (PI*((radio)^3)*(4*3));
		
		Console.Write("El volumen de una esfera de radio = {0} es {1}", radio, volumen);
	}
}

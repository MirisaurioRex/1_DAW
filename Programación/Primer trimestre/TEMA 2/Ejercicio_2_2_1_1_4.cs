
/*(2.2.1.1.4) Crea una versión mejorada del programa anterior, que, tras introducir 
cada par de números, responderá si el primero es múltiplo del segundo, o el 
segundo es múltiplo del primero, o ninguno de ellos es múltiplo del otro.*/

using System;

public class Ejercicio_2_2_1_1_4
{
	public static void Main()
	{
		//introducimos las variables
		int n1;
		int n2;
		
		//Pedimos los dos números
		Console.WriteLine("Introduce el primer número (0 para salir):");
		n1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Introduce el segundo número (0 para salir):");
		n2 = Convert.ToInt32(Console.ReadLine());
		
		if (n1 == 0 || n2 == 0)
			Console.WriteLine("El 0 no es válido.");
		
		//bucle. Si los números son 0 no entra en el bucle.
		while ((n1 != 0 ) && (n2 != 0))
		{
			if (n1%n2 == 0) 
				Console.WriteLine("{0} es múltiplo de {1}", n1,n2);
			
			if (n2%n1 == 0) 
				Console.WriteLine("{0} es múltiplo de {1}", n2,n1);
			
			// si no es uno u otro, pasa al else	
			else {
				Console.WriteLine("ninguno es múltiplo del otro");
			}
			//fuera del else, vuelve a preguntar números
				Console.WriteLine("Introduce otro par de números");
				n1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce otro par de números");
				n2 = Convert.ToInt32(Console.ReadLine());
	
			}
			//termina si algún número es 0
			if (n1 == 0 || n2 == 0)
			Console.WriteLine("El 0 no es válido.");
	}
}

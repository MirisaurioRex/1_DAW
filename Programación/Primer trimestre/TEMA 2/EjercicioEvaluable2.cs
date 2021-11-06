
/*
  Azorín Vidal, Mirada
  Práctica Evaluable Tema 2
  Ejercicio 2
 */

using System;

public class EjercicioEvaluable_2
{
	public static void Main()
	{
		{
			//Introducimos las variables
			int primerNumero;
			int segundoNumero;
			
			//pedimos los números
			Console.Write("Introduce el primer número:");
			primerNumero = Convert.ToInt32(Console.ReadLine());
			Console.Write("Introduce el segundo número:");
			segundoNumero = Convert.ToInt32(Console.ReadLine());	
			
			//validamos que el primero número sea menor que el primero
			if (primerNumero < segundoNumero) {
				Console.WriteLine("Los números son correctos; pasemos a ver si hay perfectos en este intervalo");
				}
				else 
					Console.WriteLine("Los números no son correctos");
			
			//procedemos al bucle		
			for (int i = primerNumero; i <= segundoNumero; i++) {
					int numeroPerfecto = 0;
				for (int j = 1; j<i ; j++) {
					if (i % j == 0)
						numeroPerfecto = numeroPerfecto+j;
						}
				if (numeroPerfecto == i)
					Console.Write( numeroPerfecto +" ");
					}
			}
	}
}

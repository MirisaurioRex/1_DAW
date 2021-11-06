
/*
  Azorín Vidal, Mirada
  Práctica Evaluable Tema 2
  Ejercicio 3
 */

using System;

public class PractT2_E3
{
	public static void Main()
	{
		//introducimos las variables
		int lado;
		
		//pedimos el tamaño del lado del exágono al usuario
		Console.Write("Escribe un número entero que será el lado del hexágono: ");
		lado = Convert.ToInt32(Console.ReadLine());
		
		//Con el primer for dibujamos la parte de arriba del hexágono
		for (int i = 0; i < lado; i++) {
			//vamos a hacer un triángulo vacío a la izquierda
			for (int j= i+1; j <= lado; j++) {
				Console.Write(" ");
			}
			//triángulo invertido
			for(int k = 0; k <= i; k++) {
				Console.Write("*");
			}
			//cuadrado
			for (int l= 0; l < lado-2; l++) {
				Console.Write("*");
			}
			//triángulo de la derecha
			for (int l= 0; l <= i; l++) {
				Console.Write("*");
			}
			Console.WriteLine();
		}
		//con el segundo for la parte de abajo
		for (int i= 1; i <= lado-1; i++) {
			//triángulo vacío a la izquierda
			for (int j= 0; j<= i; j++) {
				Console.Write(" ");
			}
			//triángulo invertido
			for (int k= i+1; k <= lado; k++) {
				Console.Write("*");
			}
			//cuadrado
			for (int j= 1; j <= lado-2; j++) {
				Console.Write("*");
			}
			//triángulo de la derecha
			for (int l= i+1; l <= lado; l++) {
				Console.Write("*");
			}
			Console.WriteLine();
		}	
	}
}

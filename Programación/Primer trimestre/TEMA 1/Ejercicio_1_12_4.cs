using System;
using System.Collections.Generic;

class Ejercicio_1_12_4 {
  public static void Main () {
	   /*(1.12.4) Crea un programa que convierta de grados Celsius (centígrados) a
Kelvin y a Fahrenheit: pedirá al usuario la cantidad de grados centígrados y
usará las siguiente tablas de conversión: kelvin = celsius + 273 ; fahrenheit
= celsius x 18 / 10 + 32. Emplea "Write" en vez de "{0}" cuando debas
mostrar varios datos en la misma línea.*/

//Miranda Azorín Vidal 02/10/2021

		int celsius;
		int kelvin;
		int fahrenheit;
		
		Console.WriteLine("Dime un número");
		celsius = Convert.ToInt32(Console.ReadLine ());
		
		kelvin = celsius+273;
		fahrenheit = celsius*18/10+32;
		
		Console.Write(celsius + " grados Celsius equivalen a ");
		Console.Write(kelvin);
		Console.Write(" grados Kelvin y a ");
		Console.Write(fahrenheit);
		Console.Write(" grados Fahrenheit");
		
	
  }
}

using System;
using System.Collections.Generic;

class Ejercicio_1_11_2 {
  public static void Main () {
	   /*(1.11.2) Crea una nueva versión del programa que calcula la división de dos
números introducidos por el usuario, así como el resto de esa división (1.10.2),
empleando "using System". Deberás incluir un comentario con tu nombre y la
fecha en que has realizado el programa. */

//Miranda Azorín Vidal 02/10/2021

		int n1;
		int n2;
		int division;
		int resto;
		
		
		Console.WriteLine("Dime un número");
		n1 = Convert.ToInt32(Console.ReadLine ());
		
		Console.WriteLine("Dime otro número");
		n2 = Convert.ToInt32(Console.ReadLine ());
		
		division = n1/n2;
		resto = n1%n2;
		
		Console.WriteLine("La división de {0} y {1} es {2} y su resto es {3}", n1, n2, division, resto);
	
  }
}

using System;
using System.Collections.Generic;

class Ejercicio_1_12_2 {
  public static void Main () {
	   /*Pide al usuario un número y muestra su tabla de multiplicar,
usando {0},{1} y {2}. Por ejemplo, si el número es el 3, debería escribirse
algo como
3 x 0 = 0
3 x 1 = 3
3 x 2 = 6
…
3 x 10 = 30*/

//Miranda Azorín Vidal 02/10/2021

		int n1;
		
		Console.WriteLine("Dime un número");
		n1 = Convert.ToInt32(Console.ReadLine ());
		
		Console.WriteLine("{0} x {1} = {2}", n1, 1, n1*1);
		Console.WriteLine("{0} x {1} = {2}", n1, 2, n1*2);
		Console.WriteLine("{0} x {1} = {2}", n1, 3, n1*3);
		Console.WriteLine("{0} x {1} = {2}", n1, 4, n1*4);
		Console.WriteLine("{0} x {1} = {2}", n1, 5, n1*5);
		Console.WriteLine("{0} x {1} = {2}", n1, 6, n1*6);
		Console.WriteLine("{0} x {1} = {2}", n1, 7, n1*7);
		Console.WriteLine("{0} x {1} = {2}", n1, 8, n1*8);
		Console.WriteLine("{0} x {1} = {2}", n1, 9, n1*9);
		Console.WriteLine("{0} x {1} = {2}", n1, 10, n1*10);
	
  }
}

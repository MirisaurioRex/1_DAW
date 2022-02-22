/* (5.7.2.1) Crea una función "Intercambiar", que intercambie el valor de los dos 
números enteros que se le indiquen como parámetro. Crea también un programa 
que la pruebe. */

using System;

public class Ejercicio_5_7_2_1
{
	static void Intercambiar (ref int n1, ref int n2)
	{
		int auxiliar;
		auxiliar = n1;
		 n1 = n2;
		 n2 = auxiliar;
	}
	
	
	public static void Main()
	{
		int num1= 3, num2 = 5;
		Intercambiar(ref num1, ref num2);
		Console.WriteLine("num1 " + num1+ " Num 2: "+ num2);
	} // fin del Main
}

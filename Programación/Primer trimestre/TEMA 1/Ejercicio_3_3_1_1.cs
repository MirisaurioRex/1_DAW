/*  (3.3.1.2) Crea un programa que muestre letras alternas (una sí y una no) entre la 
que teclee el usuario y la "z". Por ejemplo, si el usuario introduce una "a", se 
escribirá "aceg...".  */

using System;

public class Ejercicio_3_3_1_2
{
	public static void Main()
	{
		char letra;
		
		Console.WriteLine("Escribe una letra");
		letra = Convert.ToChar(Console.ReadLine());
		
		for (char i=letra; i <='z'; i++) {
			Console.WriteLine(i);
			i++;
		}
	}
}

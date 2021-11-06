
// Ejercicio 2.1.9.3 - Uso de switch para pedirle al usuario una letra y ver si ha escrito una vocal, un dígito o una consonante

using System;

public class Ejercicio_2_1_9_3
{
	public static void Main()
	{
		char letra;
		
		Console.WriteLine("Dime una letra o símbolo:");
		letra = Convert.ToChar(Console.ReadLine());
		
		switch (letra)
		{
			case 'a': goto case 'u';
			case 'e': goto case 'u';
			case 'i': goto case 'u';
			case 'o': goto case 'u';
			case 'u': Console.WriteLine("Vocal");
					break;
			case '0': goto case '9';
			case '1': goto case '9';
			case '2': goto case '9';
			case '3': goto case '9';
			case '4': goto case '9';
			case '5': goto case '9';
			case '6': goto case '9';
			case '7': goto case '9';
			case '8': goto case '9';
			case '9': Console.WriteLine("Dígito");
					break;
			case 'b': goto case 'z';
			case 'c': goto case 'z';
			case 'd': goto case 'z';
			case 'f': goto case 'z';
			case 'g': goto case 'z';
			case 'h': goto case 'z';
			case 'j': goto case 'z';
			case 'k': goto case 'z';
			case 'l': goto case 'z';
			case 'm': goto case 'z';
			case 'n': goto case 'z';
			case 'p': goto case 'z';
			case 'q': goto case 'z';
			case 'r': goto case 'z';
			case 's': goto case 'z';
			case 't': goto case 'z';
			case 'v': goto case 'z';
			case 'w': goto case 'z';
			case 'x': goto case 'z';
			case 'y': goto case 'z';
			case 'z': Console.WriteLine("Consonante");
					break;
			default: Console.WriteLine("No es uno de los símbolos esperados");
					break;
		}
		
		/* Observaciones: En este programa podría considerarse que la consonante es el caso "default", y asumir que el usuario sólo va a escribir vocales, consonantes o números. 
		   También se podría ampliar con las vocales y consonantes en mayúsculas */
	}
}

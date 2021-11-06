
/*(2.1.9.3) Crea un programa que lea una letra tecleada por el usuario y diga si se
trata de una vocal, una cifra numérica o una consonante, usando "switch".*/

using System;

public class Ejercicio_2_1_9_3
{
	public static void Main()
	{
	 char letra;
		
		Console.WriteLine("Introduce un caracter");
		letra = Convert.ToChar(Console.ReadLine());
		Console.WriteLine(Convert.ToInt32(letra));
		
		if (letra >=48 && letra <= 57)
			{
				Console.WriteLine("es un dígito");
			}
		else if (letra >= 97 && letra<=122) {
				if ((letra == 97) || (letra == 101)|| (letra == 105) || (letra == 111) || (letra ==117))
						Console.WriteLine("es una vocal");
				else
						Console.WriteLine("es una consonante");
				}
				else 
						Console.WriteLine("eso no es lo que te he pedido hijoputa");
	}
}

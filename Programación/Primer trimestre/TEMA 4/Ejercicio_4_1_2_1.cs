/* (4.1.2.1) Un programa que almacene en una tabla el número de días que tiene 
cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique 
un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que 
tiene ese mes.
  */

using System;

public class Ejercicio_4_1_2_1
{
	public static void Main()
	{
			int [] meses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
			int mes;
			
			Console.Write("Dime el número de un mes y te diré cuantos días tiene: ");
			mes = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("El mes {0} tiene {1} días", mes, meses[mes]);
	}
}

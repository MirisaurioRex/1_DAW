
/*(2.1.2.1) Crea un programa que pida al usuario un número entero. Si es múltiplo
de 10, informará al usuario y pedirá un segundo número, para decir a
continuación si este segundo número también es múltiplo de 10.*/

using System;

public class Ejercicio_2_1_2_1
{
	public static void Main()
	{
		int numero1;
		int numero2;
		Console.WriteLine("Dime un número entero");
		numero1 = Convert.ToInt32(Console.ReadLine());
			
			if (numero1%10 == 0)
			{		
					Console.WriteLine("{0} es múltiplo de 10", numero1);
					Console.WriteLine("Dime otro número");
					numero2 = Convert.ToInt32(Console.ReadLine());
					
				if (numero2%10 == 0)	
					Console.WriteLine("{0} también es múltiplo de 10", numero2);
				else 
					Console.WriteLine("{0} no es múltiplo de 10", numero2);
				}
	}
}

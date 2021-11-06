
/*(2.1.5.1) Crea un programa que pida al usuario un número entero y responda si es
múltiplo de 2 o de 3.*/

using System;

public class Ejercicio_2_1_5_1
{
	public static void Main()
	{
	 int numero1;
	 bool esMultiploDe3 = false;
	 bool esMultiploDe2 = false;
	 
		Console.WriteLine("Dime un número entero");
		numero1 = Convert.ToInt32(Console.ReadLine());
		
		if (numero1%2 == 0)
				esMultiploDe2 = true;		
		if (numero1%3 ==0)
				esMultiploDe3 = true;
			
				
		if (esMultiploDe3)
					{
						Console.WriteLine("{0} es múltiplo de 3", numero1);
						}
		if (esMultiploDe2)
					{
						Console.WriteLine("{0} es múltiplo de 2", numero1);
						}
		
	}
}

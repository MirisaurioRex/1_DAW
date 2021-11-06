
/*(2.1.3.1) Crea un programa que multiplique dos números enteros de la siguiente
forma: pedirá al usuario un primer número entero. Si el número que se que teclee
es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". Si se ha
tecleado un número distinto de cero, se pedirá al usuario un segundo número y se
mostrará el producto de ambos.*/

using System;

public class Ejercicio_2_1_3_1
{
	public static void Main()
	{
	 int numero1;
	 int numero2;
	 int producto;
	 
		Console.WriteLine("Dime un número entero");
		numero1 = Convert.ToInt32(Console.ReadLine());
		
		if (numero1 == 0)
		
			Console.WriteLine("El producto de 0 por cualquier número es 0");
			
			else
				Console.WriteLine("Dime otro número entero");
				numero2 = Convert.ToInt32(Console.ReadLine());
				
				producto = numero1*numero2;
				Console.WriteLine("El producto de {0} y {1} es {2}", numero1, numero2, producto);
			
	}
}

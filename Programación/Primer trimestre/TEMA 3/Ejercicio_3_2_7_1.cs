
/*(3.2.7.1) Crea un programa que halle (y muestre) la raíz cuadrada del número que 
introduzca el usuario. Se repetirá hasta que introduzca 0.

 */

using System;

public class Ejercicio_3_2_7_1
{
	public static void Main()
	{
		double numero;
		double raiz;
		
		do {
			
			Console.Write("Di números y hallaremos su raíz cuadrada (0 para salir): ");
			numero = Convert.ToInt32(Console.ReadLine());
			
			raiz = Math.Sqrt(numero);
			
			if (numero!= 0) {
				Console.WriteLine("La raíz cuadrada de {0} es {1}", numero, raiz.ToString("N2"));
			}
			else 
				Console.WriteLine("El número es 0.");
		}
		while (numero != 0);
			Console.WriteLine("Finalizando programa");
	}
}


/*(3.2.4.1) Crea un programa que calcule la raíz cuadrada del número que 
introduzca el usuario. La raíz se deberá calcular como "double", pero el resultado 
se mostrará como "float". (Recuerda: como viste al hacer el ejercicio 3.2.3.3, la raíz 
cuadrada de un número x se calcula con Math.Sqrt(x)). */

using System;

public class Ejercicio_3_2_4_1
{
	public static void Main()
	{
		double numero;
		double raiz;
		float resultadoFloat;
		
		Console.Write("Dime un número y veremos su raíz cuadrada: ");
		numero = Convert.ToDouble(Console.ReadLine());
		raiz = Math.Sqrt(numero);
		
		Console.WriteLine("La raiz cuadrada de {0} es: {1}", numero, raiz);
		
		resultadoFloat = (float) raiz;
		Console.WriteLine("Y con simple precisión: ");
		Console.WriteLine(resultadoFloat);
	}
}


// Ejercicio 4.4.1.4 - Programa que le pide al usuario dos números y una operación a realizar, en formato string, admitiendo múltiples variantes

using System;

public class Ejercicio_4_4_1_4
{
	public static void Main()
	{
		int num1, num2;
		string operacion;
		
		Console.WriteLine("Dime el primer número:");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Dime el segundo número:");
		num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Indica la operación: (+ o suma para sumar; - o resta para restar; *, x, X o multiplicación para multiplicar; / o división para dividir)");
		operacion = Console.ReadLine();
		
		switch (operacion)
		{
			// Opciones para suma
			case "suma": goto case "+";
			case "+":
				Console.WriteLine("La suma es {0}", num1 + num2);
				break;
			// Opciones para resta
			case "resta": goto case "-";
			case "-":
				Console.WriteLine("La resta es {0}", num1 - num2);
				break;
			// Opciones para multiplicación
			case "multiplicación": goto case "X";
			case "*": goto case "X";
			case "x": goto case "X";
			case "X":
				Console.WriteLine("La multiplicación es {0}", num1 * num2);
				break;
			// Opciones para división
			case "división": goto case "/";
			case "/":
				Console.WriteLine("La división es {0}", num1 / num2);
				break;
			// Otras opciones
			default: 
				Console.WriteLine("Operación no reconocida");
				break;
		}
	}
}

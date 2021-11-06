
// Ejercicio 1.12.4 - Conversor de grados celsius a kelvin y fahrenheit, sacando el resultado con varios Console.Write

using System;

public class Ejercicio_1_12_4
{
	public static void Main()
	{
		int gradosCelsius, gradosKelvin, gradosFahrenheit;

		// Pedimos la cantidad de grados Celsius
		Console.WriteLine("Introduce la cantidad de grados centígrados:");
		gradosCelsius = Convert.ToInt32(Console.ReadLine());

		// Pasamos los grados Celsius a Kelvin y Fahrenheit
		gradosKelvin = gradosCelsius + 273;
		gradosFahrenheit = gradosCelsius * 18 / 10 + 32;

		// Mostramos los resultados en una sola línea usando Write
		Console.Write (gradosCelsius);
		Console.Write (" grados Celsius son ");
		Console.Write (gradosKelvin);
		Console.Write (" grados Kelvin y ");
		Console.Write (gradosFahrenheit);
		Console.WriteLine (" grados Fahrenheit."); 
	}
}

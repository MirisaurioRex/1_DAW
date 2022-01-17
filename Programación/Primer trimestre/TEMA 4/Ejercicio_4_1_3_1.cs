using System;

public class Ejercicio_4_1_2_1
{
	static public void Main()
	{
		int [] numeros = new int [6];
		
		for (int i = 0; i < 6 ; i++) {
			Console.WriteLine("Introduce 6 números enteros cortos. El número {0} será: ", i+1);
			numeros [i] = Convert.ToInt32(Console.ReadLine());
		}
		for (int i = 5; i >= 0; i--) {
			Console.WriteLine(numeros[i]);
		}
	}
}

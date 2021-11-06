
// Ejercicio 1.10.2 - Pedirle dos números al usuario y calcular su división y su resto

public class Ejercicio_1_10_2
{
	public static void Main()
	{
		int num1, num2;
		System.Console.WriteLine("Introduce el primer número");
		num1 = System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Introduce el segundo número");
		num2 = System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("La división es {0}", num1/num2);
		System.Console.WriteLine("El resto es {0}", num1%num2);
	}
}

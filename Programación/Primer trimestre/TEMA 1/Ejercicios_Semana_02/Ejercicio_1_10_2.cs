
// Ejercicio 1.10.2 - Pedirle dos n�meros al usuario y calcular su divisi�n y su resto

public class Ejercicio_1_10_2
{
	public static void Main()
	{
		int num1, num2;
		System.Console.WriteLine("Introduce el primer n�mero");
		num1 = System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Introduce el segundo n�mero");
		num2 = System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("La divisi�n es {0}", num1/num2);
		System.Console.WriteLine("El resto es {0}", num1%num2);
	}
}

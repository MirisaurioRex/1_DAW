using System;

public class Ejercicio_4_1_3_4
{
	public static void Main()
	{
		int [] meses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
			int mes;
			int dia;
			int suma = 0;
			int total;
			
			Console.WriteLine("Dime un mes");
			mes = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Dime un día");
			dia = Convert.ToInt32(Console.ReadLine());
			
			for (int i= 0; i < mes; i++) {
				suma += meses[i];
			}
			total = suma+dia;
			Console.WriteLine("El día {0} del mes {1} es el número {2} del año", dia, mes, total);
	}
}

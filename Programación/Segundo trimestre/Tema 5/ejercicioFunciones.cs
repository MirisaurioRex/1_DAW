using System;

public class calculadora
{
		public static int suma(int n1, int n2, string operador) {
			return n1+n2;
		}
		public static int resta(int n1, int n2) {
			return n1-n2;
		}
		public static int numeroMayor(int n1, int n2) {
			if (n1 > n2)
				return n1;
			else 
				return n2;
		}
		public static int sumaArray(int[] n) {
			int total = 0;
			for (int i = 0; i < n.Length; i++)
			{
				//suma += n[i];
				total = suma(total, n[i]);
			}
			return total;
		}
		
		public static void Main()
		{
			int a = 5, b = 10;
			
			const int MAXIMO = 5;
			int [] numeros = {2, 4, 5, 3, 9};
			
			int [] muchosNumeros = {2, 4, 5, 3, 9, 4, 23, 235, 4, 34, 93, 34, -74};
			
			Console.WriteLine(sumaArray(numeros));
			Console.WriteLine(sumaArray(muchosNumeros));
			
		}
}

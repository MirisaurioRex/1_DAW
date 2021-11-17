
/*(3.2.5.3) Calcula el perímetro, área y diagonal de un rectángulo, a partir de su 
ancho y alto (perímetro = suma de los cuatro lados; área = base x altura; diagonal
= hipotenusa, usando el teorema de Pitágoras). Muestra todos ellos con una cifra 
decimal. */

using System;

public class Ejercicio_3_2_5_3
{
	public static void Main()
	{
		double alto=2;
		double ancho=4;
		double perimetro = 2*alto +2* ancho;
		double area =alto*ancho;
		double hipotenusa;
		
		
		hipotenusa = Math.Pow(alto, 2) + Math.Pow(ancho, 2);
		double diagonal = Math.Sqrt(hipotenusa);
		
		Console.WriteLine("El perímetro es: "+ perimetro.ToString("N1") );
		Console.WriteLine("El área es: "+ area.ToString("N1") );
		Console.WriteLine("La diagonal es: " +  diagonal.ToString("N1") );
		
	}
}

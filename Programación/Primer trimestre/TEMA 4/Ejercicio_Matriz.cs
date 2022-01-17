using System;

public class Ejercicio_Matriz 
{
	public static void Main()
	{
		const int FILAS= 2, COLUMNAS= 10;
		//double [,] datos = new double [FILAS, COLUMNAS];
		double [,] datos = {
			{75,9,8,7,6,5,4,3,2,1},
			{1,2,3,4,5,6,7,8,9,10}
		};
		double datoIntroducido;
		
		//Console.WriteLine("Length 0: "+ datos.GetLength(1));
		/*
		for (int fila = 0; fila < FILAS; fila++) {
			for (int columna = 0; columna < COLUMNAS; columna++) {
				Console.WriteLine("Introduce los valores {0},{1}", fila+1, columna+1);
				datoIntroducido = Convert.ToDouble(Console.ReadLine());
				datos[fila,columna] = datoIntroducido;
			}
		}
		*/
		double max = 0;
		for (int fila = 0; fila < datos.GetLength(0); fila++) {
			for (int columna= 0; columna < datos.GetLength(1); columna++) {
				Console.WriteLine(datos[fila,columna]);
				
				if(columna == 0) max=datos[fila, columna];
				
				if (datos[fila,columna]>max) {
					max = datos[fila,columna];
				}
			}
			
			Console.WriteLine("El máximo de la fila {1} es {0}", max, fila+1);
		}
		
	}
}

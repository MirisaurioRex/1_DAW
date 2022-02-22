//
// Practica Evaluable Tema 4
// Ejericio 2

// Aplicación que lea una matriz de enteros (N x M) y determine si tiene
// algún elemento Matriz[i,j] que sea mínimo en su fila y máximo en su columna

using System;

public class Matriz
{
	public static void Main()
	{
		const int N=3;
		const int M=3;
		int[,] matriz = new int[N,M];

		bool[,] min = new bool[N,M];
		bool[,] max = new bool[N,M];
		int f, c, elementos, posicion, minimo, maximo;
		bool estricto;


        string dato;

		//================================= Leer e introducir datos de la matriz ====================================
		Console.WriteLine("Matriz [{0},{1}]", N, M);
        for(f=0; f<N; f++)
        {
			for (c=0; c<M; c++)
			{
				Console.Write("Escribe el dato [{0},{1}]: ", f, c);
				dato = Console.ReadLine();
				matriz[f,c] = int.Parse(dato);
			}
			Console.WriteLine();
		}

		//================================= Mostrar datos de la matriz ====================================
		Console.WriteLine("Matriz [{0},{1}]", N, M);
		for(f=0; f<N; f++)
		{
			for(c=0; c<M; c++)
			{
				Console.Write(matriz[f,c]+" ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();

		//================================= Inicialización de minimos y maximos ====================================
		for(f=0; f<N; f++)
		{
			for(c=0; c<M; c++)
			{
				min[f,c] = false;
				max[f,c] = false;
			}
		}		

		//================================= Determinación de mimimos estrictos en cada fila ====================================
		for(f=0; f<N; f++)
		{
			minimo = matriz[f,0];
			estricto=true;
			posicion=0;
			for(c=1; c<M; c++)
			{
				if(minimo > matriz[f,c])
				{
					minimo = matriz[f,c];
					estricto=true;
					posicion=c;
				}
				else
				{
					if(minimo == matriz[f,c])
						estricto=false;
				}
			}
			if (estricto)
				min[f,posicion]=true;
		}	

		//================================= Determinación de maximos estrictos en cada columna ====================================
		for(c=0; c<M; c++)
		{
			maximo = matriz[0,c];
			estricto=true;
			posicion=0;
			for(f=1; f<N; f++)
			{
				if(maximo < matriz[f,c])
				{
					maximo = matriz[f,c];
					estricto=true;
					posicion=f;
				}
				else
				{
					if(maximo == matriz[f,c])
						estricto=false;
				}
			}
			if (estricto)
				max[posicion,c]=true;
		}	
		
		//================================= Comprobacion ====================================
		elementos=0;
		for(f=0; f<N; f++)
		{
			for(c=0; c<M; c++)
			{
				if (min[f,c] && max[f,c])
				{
					elementos++;
					Console.Write("Elemento {0} en posicion [{1},{2}]", matriz[f,c], f+1, c+1);
				}
			}
		}
		if (elementos==0)
			Console.WriteLine("No se han encontrado elementos que cumplan la condición");

	}
}

using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
   int numero;
   int librosEnLista;
   
   //crear Listas de libros y el random
    List<String> libros = new List<String>();
    List<String> librosOrdenados = new List<String>();
    Random random = new Random ();
    
    //rellenamos lista
	libros.Add("Nuncanoche");
	libros.Add("Tumba de Dioses");
	libros.Add("Albaoscura");	
	libros.Add("La Ciudad Justa");
	libros.Add("Anne sin Filtros");
	libros.Add("El Imperio Final");
	libros.Add("Elantris");
	libros.Add("Rithmatista");	
	
	librosEnLista = libros.Count;
	
	//Console.WriteLine(string.Join( ", ", librosOrdenados));
// for para ordenar mis libros	
	for(int i=0 ; i < librosEnLista; i++) {
	
		//elegir un libro random
		numero = random.Next(0, libros.Count);
		Console.WriteLine("{0} {1}", i, libros[numero]);
		
		//libro elegido a segunda lista y después se borra
		librosOrdenados.Add(libros[numero]);
		
		//quitar el libro random elegido de la lista	
		libros.Remove(libros[numero]);
	}
	Console.WriteLine("");
	// listado de vs	
	for (int i= 0; i < librosOrdenados.Count; i+=2) {
		Console.WriteLine("{0} vs {1}", librosOrdenados[i], librosOrdenados[i+1]);
		}
	
	//comprobar que el libro se ha quitado
		//Console.WriteLine(libros.Count);
		//Console.WriteLine(string.Join( ", ", libros));
  }
}

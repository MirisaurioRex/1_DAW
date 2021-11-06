using System;
using System.Collections.Generic;

class Ejercicio_1_9_1 {
  public static void Main () {
	   /*(1.9.1) Crea un programa que convierta una cantidad prefijada de metros 
	   (por ejemplo, 3000) a millas. La equivalencia es 1 milla = 1609 metros. 
	   Usa comentarios donde te parezca adecuado. */
	   
	   int metros = 3000;
	   int equivalenciaMillas;
	   
	   equivalenciaMillas = metros*1609;
	   
	   Console.WriteLine("{0} metros equivalen a {1} millas", metros, equivalenciaMillas);
	   
	    
  }
}

/*1. Create a program that prints the first n squared numbers, asking to the user the 
number n
 */

import java.util.Scanner;

public class Exercise1 {
	
	public static void main (String[] args) {
		
		int n, square; //variables
		
		Scanner sc = new Scanner (System.in); // para leer los datos del usuario
		
		System.out.print("Write a number: "); //pedimos el número al usuario y lo leemos
		n = sc.nextInt();
		
		for (int i = 1; i <= n; i++) // hacemos un bucle para la operación "al cuadrado"
		{
			square = (int)(Math.pow(i, 2));
			System.out.print(square + " ");
		}
		
	}//fin del main
}


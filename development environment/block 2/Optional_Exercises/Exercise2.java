/*2. Create a program that asks numbers to the user and continue asking numbers 
until the user input a 0. Then, it will print the number of numbers that the user 
has input except the last one (the 0) that have to be excluded. It has to count 
how many numbers have been input by the user.
 */

import java.util.Scanner;

public class Exercise2 {
	
	public static void main (String[] args) {
		
		final int MAX = 100;  //variables
		int n, contador = 0;
		
		int [] numbers = new int [MAX]; //array para almacenar los valores introducidos
		
		do {
			Scanner sc =  new Scanner (System.in); // para leer los datos del usuario
			
			System.out.print("Write a number: "); //pedimos el número al usuario, lo leemos y lo almacenamos en el array
			n = sc.nextInt();
			if (contador < MAX)
			{
				numbers[contador] = n;
				contador++;
			}
		} 
		while (n != 0); {
			System.out.println("The number of numbers input is: " + (contador-1)); //número de veces que se han introducido números
			
			contador--; // quitamos el 0
			for (int i= 0; i < contador; i++) // hacemos un bucle para imprimir los datos tecleados
			{
				System.out.println("The numbers that have been typed are: " + numbers[i]);
			}
		}
	}//fin del main
}


/*3. Create a program that print the prime numbers until a number input by the 
user.
 */

import java.util.Scanner;
import java.util.Arrays;

public class Exercise3 {
	
	public static void main (String[] args) {
		
		int n, contador = 1; //variables
		boolean esPrimo = true;
		
		Scanner sc =  new Scanner (System.in); // para leer los datos del usuario
			
		System.out.print("Write a number: "); //pedimos el número al usuario y lo leemos 
		n = sc.nextInt();
		int [] numbers = new int [n]; //array para almacenar los primos
		numbers [0] = 1;
		
		for (int j = 2; j <= n; j++) { //doble bucle para reccorer los valores hasta el número dado por el usuario
				esPrimo = true;
				for (int i = 2; i < 	j; i++)
				{
						if (j%i == 0 && j!=i)
						{
							esPrimo = false;
						}
				}
				if(esPrimo){
					numbers[contador]=j;
					contador++;
				}
			}
		
		System.out.print("Prime numbers until " + n + " are: " + Arrays.toString(numbers));
		
		
	}//fin del main
}


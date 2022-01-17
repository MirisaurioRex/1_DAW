/* 4. Create a program that asks the user double numbers until the word end is 
input and then it has to print the minimum, the maximum, the addition and the 
average in each step. */

import java.util.Scanner;
import java.util.Arrays;

public class Exercise4 {
	
	public static void main (String[] args) {
		
		double n, min = 0, max = 0, add = 0, avg = 0; //variables
		int contador = 0;
		String datoIntroducido = "";
		
		Scanner sc =  new Scanner (System.in); // para leer los datos del usuario
		
		do
			{
				System.out.print("Write a number: ");
				datoIntroducido = sc.nextLine();
				
			if (datoIntroducido.equalsIgnoreCase("end")) {
				System.out.println("End of the programm");
			}
			else
			{
				n = Double.parseDouble(datoIntroducido);
				if (contador == 0)
				{
					min = n;
					max = n;
					add = n;
					avg = n;
					
					contador++;
				}
				else {
					if (n < min)
					{
						min = n;
					}
					if (n > max)
					{
						max = n;
					}
					add += n;
					contador++;
					avg = (add/contador);
				}
				System.out.printf("min %f max %f add %f avg %f\n",  min, max, add, avg);
			}
		 }
			while (!datoIntroducido.equalsIgnoreCase("end"));
		
	}//fin del main
}

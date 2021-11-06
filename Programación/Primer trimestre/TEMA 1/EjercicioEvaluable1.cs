
/*
  Azorín Vidal, Mirada
  Práctica Evaluable Tema 2
  Ejercicio 1 si
 */

using System;

public class EjercicioEvaluable_1
{
	public static void Main()
	{
			//introducimos las variables
			int dia = -1;
			int mes = -1;
			string estacion;
			string frase; 
			bool fechaValida;
			
			do 
			{
				//iciciamos la estación
				estacion = "";
				frase = "";
				fechaValida= true;
				
				try
				{
					//pedimos el día y el mes
					Console.Write("Dime el día: ");
					dia = Convert.ToInt32(Console.ReadLine());
					Console.Write("Dime el mes: ");
					mes = Convert.ToInt32(Console.ReadLine());
					
					//Para entrar en el bucle
					if  (dia == 0 || mes == 0)
						Console.WriteLine("Saliendo del programa");
					else 
						{	
						//validamos los meses con 31 días
							if ((dia > 0 && dia <= 31) && (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes ==10 || mes ==12))
								frase = "La estación del año es:";
						//validamos los meses con 30 días
							else if ((dia > 0 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11 ))
								frase = "La estación del año es:";
						//validamos febrero
							else if (mes == 2 && (dia >0 && dia <= 28))
								frase = "La estación del año es:";
							
							else {
								frase ="Fecha no válida"; 
								fechaValida =false;
								}
								
							if (fechaValida) {
							//Las condiciones para ser Primavera
								if ((mes == 3 && dia >=21) || (mes == 4) || (mes == 5) || (mes == 6 && dia <=20))
								{
									estacion = "PRIMAVERA";
								}
								//las condiciones para ser Verano
								else if ((mes == 6 && dia >=21) || (mes == 7) || (mes == 8) || (mes == 9 && dia <=21))
								{
									estacion = "VERANO";
								}
								//las condiciones para ser Otoño
								else if ((mes == 9 && dia >=22) || (mes == 10) || (mes == 11) || (mes == 12 && dia <=21))
								{
									estacion = "OTOÑO";
								}
								//las condiciones para ser Invierno
								else if ((mes == 12 && dia >=22) || (mes == 1) || (mes == 2) || (mes == 3 && dia <=20))
								{
									estacion = "INVIERNO";
								}	
							}
						Console.WriteLine("{0} {1}", frase, estacion);
						}
					}
					catch (FormatException)
					{
						Console.WriteLine("Este número no es válido");
					}
					
			}
			while (dia != 0 && mes != 0);
		}
	}

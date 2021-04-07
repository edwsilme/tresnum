using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fase1
{
    //Nombre del Autor: Edward Eliecer Silva Mejia
    //Fecha: 09/11/2015
    //Doy fe que este ejercicio es de mi autoria, en caso de encontrar plagio la nota de todo mi 
    //trabajo debe ser de CERO ademas de las respectivas sansiones a que haya lugar

    class Tresnum
    {
        static void Main(string[] args)
        {

            int N1, N2, N3;

            Console.WriteLine("Leer tres numeros y decir cual es mayor, menor o si son iguales.");
            Console.WriteLine("Por favor digite tres numeros");

            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            N3 = int.Parse(Console.ReadLine());

           /*
            Console.WriteLine("El primer valor es {N1},  el segundo es {N2}  y el tercero es {N3}");
            //Se leen tres numeros cualquiera. 
           */

            if (N1 > N2 && N2 > N3) //N1 mayor que N2 y N2 mayor que N3... N1>N2>N3
            {
                Console.WriteLine("El mayor de los tres es: " +N1);
                Console.WriteLine("El menor es: " +N3);
            }

            else
            {
                if (N1 > N2 && N2 < N3)
                {
                    if (N1 > N3)//N1 mayor que N3 y N3 mayor que N2... N1>N3>N2
                    {
                        Console.WriteLine("El mayor de los tres es: " +N1);
                        Console.WriteLine("El menor es: " +N2);
                    }
                    else
                    {
                        if (N1 < N3)//N3 mayor que N1 y N1 mayor que N2... N3>N1>N2
                        {
                            Console.WriteLine("El mayor de los tres es " +N3);
                            Console.WriteLine("El menor es: " +N2);
                        }
                        else//N1 igual a N3 y N3 mayor que N2... (N1=N3)>N2
                        {
                            Console.WriteLine("El primer y tercer numero son iguales");
                            Console.WriteLine("El menor es: " +N2);
                        }
                    }
                }
                else
                {
                    if (N1 < N2 && N2 < N3)//N3 mayor que N2 y N2 mayor que N1... N3>N2>N1
                    {
                        Console.WriteLine("El mayor de los tres es: " +N3);
                        Console.WriteLine("El menor es: " +N1);
                    }
                    else
                    {
                        if (N2 > N3)
                        {
                            if (N3 < N1)
                            {
                                if (N1 == N2)//N1 igual a N2 y N2 mayor que N3... (N1=N2)>N3
                                {
                                    Console.WriteLine("El primer y segundo numero son iguales");
                                    Console.WriteLine("El menor es: " +N3);
                                }
                                else//N2 mayor que N1 y N1 mayor que N3... N2>N1>N3
                                {
                                    Console.WriteLine("El mayor de los tres es " +N2);
                                    Console.WriteLine("El menor es: " +N3);
                                }
                            }
                            else
                            {
                                if (N3 > N1)//N2 mayor que N3 y N3 mayor que N1... N2>N3>N1
                                {
                                    Console.WriteLine("El mayor de los tres es: " +N2);
                                    Console.WriteLine("El menor es: " +N1);
                                }
                                else//N2 mayor que N1 y N1 igual a N3...(N1=N3)<N2
                                {
                                    Console.WriteLine("El mayor de los tres es: " +N2);
                                    Console.WriteLine("El primer y tercer numero son iguales");
                                }
                            }
                        }
                        else
                        {
                            if (N2 == N3)
                            {
                                if (N1 > N2)//N1 mayor que N2 y N2 igual a N3... N1>(N2=N3)
                                {
                                    Console.WriteLine("El mayor de los tres es " +N1);
                                    Console.WriteLine("El segundo y tercer numero son iguales");
                                }
                                else
                                {
                                    if (N1 < N2)//N1 menor que N2 y N2 igual a N3... N1<(N2=N3)
                                    {
                                        Console.WriteLine("El segundo y tercer numero son iguales");
                                        Console.WriteLine("El menor es: " +N1);
                                    }
                                    else//Los tres numeros son iguales... N1=N2=N3
                                    {
                                        Console.WriteLine("Los tres numeros son iguales");
                                    }
                                }
                            }
                            else//N1 igual a N2 y N2 menor que N3... (N1=N2)<N3
                            {
                                Console.WriteLine("El mayor de los tres es: " +N3);
                                Console.WriteLine("El primer y segundo numero son iguales");
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

using System;
//2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para 
//calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float acu,Promedio,Numeros;
            float[] VecNum = new float [10];
            const int VUELTAS = 10;

            for (int i = 0; i < VUELTAS; i++)
            {
                 Console.WriteLine("Ingrese numeros por favor: ");
                 Numeros = float.Parse(Console.ReadLine());

                 VecNum[i] = Numeros;
            }

            acu = 0;

            for (int i = 0; i < VUELTAS; i++)
            {
               acu+=VecNum[i];
            }
            Promedio = acu/10;

            for (int i = 0; i < VUELTAS; i++)
            {
                if(VecNum[i]>Promedio){

                    Console.WriteLine("Los numeros mayores al promedio son: " +VecNum[i]);

                }
            }
           
        }
    }
}

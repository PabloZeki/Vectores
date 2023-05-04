using System;
//1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos
 //y determinar e informar cuál es el valor máximo y su posición dentro del vector.
namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numeros,NumMayor,Pos;
            int[] VecNum = new int [10];
            const int VUELTAS = 10;

            for (int i = 0; i < VUELTAS; i++)
            {
                 Console.WriteLine("Ingrese numeros por favor: ");
                 Numeros = int.Parse(Console.ReadLine());            // Carga de vector

                 VecNum[i] = Numeros;
            }
                NumMayor = VecNum[0];
                Pos = 1;                       // la iniciamos en 1 porque no sabemos si el mayor es el primer ingreso
                
            for (int i = 0; i < VUELTAS; i++)
            {
                if(VecNum[i]>NumMayor){

                    NumMayor = VecNum[i];
                    Pos = i+1;
                    
                }
                
            }
            Console.WriteLine("El numero mayor es..." +NumMayor +"ingresado en la posicion" +Pos);



           
        }
    }
}

using System;
//3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
 //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido 
 //reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
//CADENA FUENTE: “La mar estaba serena"
//CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
//CADENA RESULTADO: “Li mir estibi sereni"

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] VecFrase = new char [30];
            int indice;
            char Letra;
           char Letravieja;
            char Letranueva;
            
            // carga de vector char
            
            Console.WriteLine("Ingrese la frase por favor: ");
            Letra = char.Parse(Console.ReadLine());

            indice = 0;

            while (Letra != '0' && indice < 30)
            {
                VecFrase[indice] = Letra;
                indice ++;

            Console.WriteLine("Ingrese la frase por favor: ");
            Letra = char.Parse(Console.ReadLine());
 
            }
            VecFrase[indice] = '\0';
            // Mostramos frase original

            Console.WriteLine("La frase original es...");

            indice = 0;

            while (VecFrase[indice] != '\0')
            {
                Console.WriteLine(VecFrase[indice]);

                indice++;
            }
            // Remplazo de letras

            Console.WriteLine("Ingrese la letra a reemplazar: ");
            Letravieja = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva: ");
            Letranueva = char.Parse(Console.ReadLine());

            indice=0;

            while (VecFrase[indice] != '\0')
            {
                if(VecFrase[indice]==Letravieja){

                    VecFrase[indice] = Letranueva;
                }

                indice ++; 
            }

            // Mostramos la frase nueva
            Console.WriteLine("La frase modificada quedo asi...");
            indice = 0;

            while (VecFrase[indice] != '\0')
            {
                Console.Write (VecFrase[indice]);

                indice ++;
            }
            
            // la forma actual como se haria esto

            string frase;
            char letraactual;
            char letranueva;
            Console.WriteLine("Ingrese la frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a reemplazar: ");
            letraactual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva: ");
            letranueva = char.Parse(Console.ReadLine());




            frase = frase.Replace(letraactual,letranueva);
        }
    }
}

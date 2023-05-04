using System;
//4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los 
//siguientes datos:
//- Número de Artículo (1 a 15)
//- Cantidad Vendida 

//Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
//Se pide determinar e informar:
//a) El número de artículo que más se vendió en total.
//b) Los números de artículos que no registraron ventas.
//c) Cuantas unidades se vendieron del número de artículo 10.



namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumArt,CanVendida,Art,NumArtMax;
            int[] VecAcu = new int [15];
            const int VUELTAS = 15;

            for (int i = 0; i < VUELTAS; i++)
            {
                VecAcu[i] = 0;                // inicializar acumuladores en 0..15 para los distintos numeros de art
            }

            Console.WriteLine("Ingrese Numero de articulo...");
            NumArt = int.Parse(Console.ReadLine());
            

            while (NumArt != 0 && NumArt <= 15)
            { 

                Console.WriteLine("Ingrese Cantidad de ventas:");
             CanVendida = int.Parse(Console.ReadLine());

                VecAcu[NumArt-1] =+ CanVendida;      // cargamos el vector con las ventas para los 15 articulos
                                                    // tmb quedaria ordenado para usar un for luego de 1 a 15
             
            Console.WriteLine("Ingrese Numero de articulo...");
            NumArt = int.Parse(Console.ReadLine());  
            }
             // punto A
            NumArtMax = VecAcu[0];
            Art = 1;

            for (int i = 0; i < VUELTAS; i++)
            {
                if(VecAcu[i]>NumArtMax){

                    NumArtMax = VecAcu[i];
                    Art = i+1;
                }
            }
            Console.WriteLine("El Numero de articulo que mas ventas tuvo fue el: " + Art + " Con un total de " +NumArtMax);

            //punto b

            for (int i = 0; i < VUELTAS; i++)
            {
                if(VecAcu[i]==0){

                    Console.WriteLine("Los Numeros de articulos que no registraron ventas fueron: " +(i+1));
                }
           }

            // punto c

            Console.WriteLine("La cantidad de ventas que tuvo el articulo 10 fue de: " +VecAcu[9]);

            
        }
    }
}

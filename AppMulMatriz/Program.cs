using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMulMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //matrices multidimensionales rectangulares
            int[,] x = new int[3, 3];
            int[,] y = new int[3, 2];
            int[,] c = new int[3, 3];
            leer(x);
            imprimir(x);
            Console.WriteLine();
            leer(y);
            imprimir(y);
            Console.WriteLine();
            Console.WriteLine();
            multiplicar(x, y, c);
            imprimir(c);
            Console.WriteLine();
            int[][,] matriz = new int[3][,];
            inicializar(matriz);
            Console.ReadKey();
        }
        public static void inicializar(int[][,] matriz)
        {
            matriz[0] = new int[3, 3];//primera matriz
            matriz[1] = new int[3, 2];//segunda matriz
            matriz[2] = new int[3, 2];//matriz resultante
            Console.WriteLine("\nMultiplicación de matrices utilizando dimensiones escalonadas y rectangular");
            leer(matriz[0]);//lectura primera matriz
            leer(matriz[1]);//lectura segunda matriz
            multiplicar(matriz[0], matriz[1], matriz[2]);
            imprimir(matriz[2]);
        }
        public static void multiplicar(int[,] x, int[,] y, int[,] c)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    c[i, j] = 0;
                    for (int k = 1; k < c.GetLength(0); k++) 
                    {
                        c[i, j] = c[i, j] + x[i, k] * y[k,j];
                    }
                }
            }
        }
        public static void leer(int[,] matriz)
        {
            Console.WriteLine("Ingrese los valores de la matriz");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)

                {
                    string aux;
                    Console.Write(" [ {0},{1} ] ", i, j);
                    aux = Console.ReadLine();
                    matriz[i, j] = Int32.Parse(aux);

                }
            }
            Console.WriteLine();
        }
        public static void imprimir(int[,] matriz)
        {
            Console.WriteLine(" La matriz es:  ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(" {0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

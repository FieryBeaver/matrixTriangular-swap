using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void swap( ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    static void printMatrix(int[,] M,int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(M[i, j]);
                    Console.Write("   ");

                }

                Console.Write("\n");
            }
            Console.Write("\n\n\n");
        }


        static void Main(string[] args)
        {
            Random random = new Random();
            int n = 50;
            int[,] matrix = new int[n, n];


            n =Int32.Parse( Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(100);
                }
                   
            }

            printMatrix(matrix, n);

            int k = n;
            int m = 0;
            while (k!= 0)
            {
                
                for (int i = (n-k); i < k-m; i++)
                {
                    swap(ref matrix[i, m], ref matrix[i, n - m-1]);
                }
                k--;
                m++;
            }


            printMatrix(matrix, n);



            Console.ReadKey();
        }
    }
}

using System;

namespace vectori1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            PrintArray(array);
            Console.WriteLine("\n");
            suma(array);
            Console.WriteLine("\n");
            med(array);
            Console.WriteLine("\n");
            elementePare(array);
            Console.WriteLine("\n");
            MinMax(array);


            int[] Nums = { 1, 2, 3, 1, 1, 3};
            PerechiBuna(Nums);
            Console.WriteLine("\n");

            Fibonacci(5);
            Console.WriteLine("\n");
            int [] vector = { 1, 2, 3, 1, 2, 2, 5 }
            frequencies(vector);


        }

        static void PrintArray(int[] array)
        {
            if (array is null)
            {
                Console.WriteLine("array is null");
                return;
            }
            Console.Write("array= ");
            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                Console.Write(element);
                if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }

        static void suma(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.Write("suma cifrelor din vector este "+ sum);
        }

        static void med (int [] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            int media = sum / array.Length;
            Console.Write("media cifrelor din vector este " + media);
        }

        static void elementePare(int [] array)
        {
            int nr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    nr++;
            }

            Console.WriteLine("numarul elementelor pare din vector= " + nr);
        }

        static void MinMax(int[] array)
        {
            int min = array[0];
            int max = array[0];

            for(int i=1;i<array.Length;i++)
            {
                if (min > array[i])
                    min = array[i];
                else
                    if (max < array[i])
                    max = array[i];
            }

            Console.WriteLine("minimul este " + min +" iar maximul este " + max);

        }

        static void PerechiBuna(int [] array)
        {
            int nr = 0;
            for(int i=0;i<array.Length;i++)
            {
                for(int j=1;j<array.Length;j++)
                    if(array[i]==array[j] && i<j)
                    {
                        nr++;
                        Console.WriteLine("( " + i + " ," + j + " )");
                    }
            }
            Console.WriteLine("exista " + nr + " perechi de numere");
        }

        static void Fibonacci(int n)
        {
            
            //Console.WriteLine("dati numarul n = ");
           // l = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;
            int c;
            Console.WriteLine(a + "\n" + b);

            for(int i=1;i<n;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c + " ");

            }

           
        }

        /*static void frequencies(int[] array)
        {
            a = array[0];
            int fr[10];
            for(int i=0;i<array.Length;i++)
            {
                fr[i]++;

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(fr[i] + " ");
            }
        }*/
    }
}

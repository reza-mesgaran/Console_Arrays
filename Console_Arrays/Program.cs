using System;
namespace Console_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ////--------------- single-dimensional array
            //int[] myarray1 = new int[3];   //First Sturcture
            //myarray1[0] = 10;
            //myarray1[1] = 20;
            //myarray1[2] = 30;
            ////
            //int[] myarray2 = new int[] { 1, 2, 3 }; //Second Structure


            ////---------- Surfing 1D Array -- FOR
            //Console.WriteLine("Surfing 1D Array by For-Loop");
            //for (int i=0;i<3;i++)
            //{
            //    Console.WriteLine(myarray1[i]);
            //}


            ////---------- Surfing 1D Array -- Foreach
            //Console.WriteLine("Surfing 1D Array by ForEach-Loop");
            //foreach (var i in myarray1)
            //{
            //    Console.WriteLine(i);
            //}


            //--------------- Multidimensional Arrays (2D)

            int[,] Array2D1 = new int[3, 2];   //First Sturcture  --> row:3 Col:2
            Array2D1[0, 0]= 0;   // Assign row1 and col1
            Array2D1[0, 1] = 1;  // Assign row1 and col2
            Array2D1[1, 0] = 10; // Assign row2 and col1
            Array2D1[1, 1] = 11; // Assign row2 and col2
            Array2D1[2, 0] = 20; // Assign row3 and col1
            Array2D1[2, 1] = 21; // Assign row3 and col2

            for (int i=0; i<3;i++)  //Surfe Rows
            {
                for (int j=0; j<2; j++)  //Surfe Columnss
                    Console.Write(Array2D1[i,j]+" ");
                Console.WriteLine();
            }         

            Console.ReadKey();
        }
    }
}

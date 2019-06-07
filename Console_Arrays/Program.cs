using System;
namespace Console_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------- single-dimensional array
            int[] myarray1 = new int[3];   //First Sturcture
            myarray1[0] = 10;
            myarray1[1] = 20;
            myarray1[2] = 30;
            //
            int[] myarray2 = new int[] { 1, 2, 3 }; //Second Structure


            //---------- Surfing 1D Array -- FOR
            Console.WriteLine("Surfing 1D Array by For-Loop");
            for (int i=0;i<3;i++)
            {
                Console.WriteLine(myarray1[i]);
            }


            //---------- Surfing 1D Array -- Foreach
            Console.WriteLine("Surfing 1D Array by ForEach-Loop");
            foreach (var i in myarray1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

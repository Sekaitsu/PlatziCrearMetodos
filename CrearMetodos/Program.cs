using System;

namespace CrearMetodos
{
    public class Program //mymethods  
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");


            Program MyProgram = new Program();

            MyProgram.IntegerAddition(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
            //int result1 = MyProgram.IntegerAddition(3, 6);
            //Console.WriteLine("El resultado es " + result1);


            int result = MyProgram.IntegerMultiplication(12, 2);
            Console.WriteLine("El resultado de la multiplicación es " + result);
        }

        //objetivo de sumar dos números enteros
        public void IntegerAddition(int a, int b)
        {
            int Addition = a + b;   
            //return Addition;
            Console.WriteLine("El resultado es " + Addition);


        }

        //objetivo de multiplicar dos números enteros
        public int IntegerMultiplication(int a, int b)
        {
            int Multiplication = a * b;
            return Multiplication;

        }


       
    }
}
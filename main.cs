using System;

 

namespace Calculator

{


    class Operations

    {

        static void Main(string[] args)

        {
            Suma(){
                int num1, num2, resultado;

                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());

                resultado = num1 + num2;

                Console.WriteLine("El resultado es " + resultado);

                Console.Read();
            }



        }

             private int NewDivision(int number1, int number2)
        {
            newDivision = number1 / number2;
            return newDivision;
        }   

    }

}
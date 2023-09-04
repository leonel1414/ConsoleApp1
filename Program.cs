using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 10;
            int var2 = 100;
            bool var3 = true;
            bool var4 = false;
            int resultado = 0;

            Console.WriteLine("Operadores aritmeticos");
            Console.WriteLine();

            Console.WriteLine($"Var1 = {var1}");
            Console.WriteLine($"Var2 = {var2}");
            Console.WriteLine();

            Console.WriteLine($"var1 + var2 = {var1 + var2}");
            Console.WriteLine($"var1 - var2 = {var1 - var2}");
            Console.WriteLine($"var1 * var2 = {var1 * var2}");
            Console.WriteLine($"var1 / var2 = {var1 / var2}");
            Console.WriteLine($"var1 % var2 = {var1 % var2}");
            Console.WriteLine();

            //incrementos
            var1 = var1 + 1;
            Console.WriteLine($"var1 + 1 = {var1}");

            var1++; //equivale a la expresion anterior
            Console.WriteLine($"var1++ = {var1}");

            var1 += 10;//equivale a var1 = var1 + 10
            Console.WriteLine($"var1 +=10 = {var1}");
            Console.WriteLine();

            var1 = 10;
            var2 = 10;

            resultado = var1++;// se asigana var1 a resultado y luego se incrementa var
            Console.WriteLine($"Resultado = var++; resultado = {resultado}");

            Console.WriteLine($"var 1 == var2  = {var1 == var2}");
            Console.WriteLine($"var 1 == var2  = {var1 != var2}");
            Console.WriteLine($"var 1 < var2  = {var1 < var2}");
            Console.WriteLine($"var 1 <= var2  = {var1 <= var2}");
            Console.WriteLine($"var 1 > var2  = {var1 > var2}");
            Console.WriteLine($"var 1 >= var2  = {var1 >= var2}");
            Console.WriteLine($"var 1 & var2  = {var1 & var2}");
            Console.WriteLine($"var 1 | var2  = {var1 | var2}");



            Console.WriteLine("Condicionales");
            int Var1 = 10;
            int Var2 = 20;
            int Var3 = 3;

            Console.WriteLine($"Var1 = {var1}");
            Console.WriteLine($"Var2 = {var2}");
            Console.WriteLine($"Var3 = {var3}");

            //if simple
            if (Var1 == Var2)
            {
                Console.WriteLine($"Valor de ambas es el mismo");
            }
            //if con else
            if (Var1 == Var2)
            {
                Console.WriteLine($"Valor de ambas es el mismo");
            }
            else
            {
                Console.WriteLine($"El valor de ambas variables es distinto.");
            }

            if (Var1 == Var2)
            {
                Console.WriteLine("el valor de ambas variables es el mismo");
            }
            else
            {
                if (Var1 > Var2)
                {
                    Console.WriteLine("Var1 > Var2");
                }
                else
                {
                    Console.WriteLine("Var1 < Var2");
                }
                Console.WriteLine();
            }

            //switch
            switch (Var3) {
                case 1:
                    Console.WriteLine("var3 = primavera.");
                    break;
                case 2:
                    Console.WriteLine("var3 = verano");
                    break;
                case 3:
                    Console.WriteLine("var3 = otoño.");
                    break;
                case 4:
                    Console.WriteLine("var3 = invierno.");
                    break;
                default: //si no es ninguno de los indicado arriba
                    Console.WriteLine("var3 fuera de rango");
                    break;
            }
            Console.WriteLine();



            //while
            Console.WriteLine("Bucles");
            Console.WriteLine();

            int contador = 0;
            Console.WriteLine("while");
            Console.WriteLine();
            while (contador < 10) {
                Console.WriteLine($"contador = {contador}");
                contador++;
            }
            Console.WriteLine($"Valor final: {contador}");

            //do while
            Console.WriteLine("do while");
            Console.WriteLine();

            contador = 0;
            do {
                Console.WriteLine($"contador = {contador}");
                contador = contador + 1;
            } while (contador <10);
            Console.WriteLine();
            Console.WriteLine($"valor final: {contador}");

            //for


        }
    }
}
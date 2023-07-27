using System;

namespace IfElseSwitchEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.Write("Insira o valor de x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o valor de y: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x >= 5 && y >= 5) // if(x > 5 || x == 5) é a mesma coisa
            { 
                Console.WriteLine("x e y são maiores ou iguais a 5");
            } 
            else if(x < 5 && y < 5)
            {     
                Console.WriteLine("x e y são menores que 5");
            } 
            else 
            { 
                Console.WriteLine("x ou y são menores que 5");
            }

            //if (x >= 5 && y >= 5) // if(x > 5 || x == 5) é a mesma coisa
            //{
            //    Console.WriteLine("x e y são maiores ou iguais a 5");
            //}
            //else
            //{
            //    if (x < 5 && y < 5)
            //    {
            //        Console.WriteLine("x e y são menores que 5");
            //    }
            //    else
            //    {
            //        Console.WriteLine("x ou y são menores que 5");
            //    }
            //}

            if (x < 5 && y < 5)
                Console.WriteLine("x e y são menores que 5");

            Console.WriteLine("Executa sempre");


            Random random = new Random();
            int z = random.Next(10);
            Console.WriteLine(z);

            switch (z)
            {
                case 1:
                    Console.WriteLine("x igual a 1");
                    break;
                case 2:
                    Console.WriteLine("x igual a 2");
                    Console.WriteLine("x igual a 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("x igual 3 ou 4");
                    break;
                case 5:
                    Console.WriteLine("x igual 5");
                    goto default;
              
                default:
                    Console.WriteLine("x é diferente de 1, 2, 3 e 4");
                    break ;
            }
            
        }
    }
}


using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Digite o numero correspondente ao exercicio para resolver: ");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior");
Console.WriteLine("2- Escreva um programa para calcular a raiz da equação quadrática");
Console.WriteLine("3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop while, do-while e for.");
Console.WriteLine("----------------------------------------------");

int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        {
            //1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
            int num1, num2, num3;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("O primeiro numero: " + num1 + " é o maior.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("O segundo número: " + num2 + " é o maior.");
            }
            else
            {
                Console.WriteLine("O terceiro número: " + num3 + " é o maior.");
            }

            break;

        }
    
        

    case 2:
        {

            //2- Escreva um programa para calcular a raiz da equação quadrática

            Console.WriteLine("Digite o valor de a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("o valor de a nao pode ser 0");
            }
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("As raizes são imagiárias");
                    Console.WriteLine("Sem solução para os numeros reais");
                }
                else if (delta == 0)
                {
                    double x = -b / (2.0 * a);
                    Console.WriteLine("Ambas as raizes sao reais e iguais");
                    Console.WriteLine("Raiz única: x = " + x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Ambas raizes sao reais e diferentes");
                    Console.WriteLine("primeira raiz x1: " + x1);
                    Console.WriteLine("segunda raiz x2: " + x2);

                }
            }

            break;
        }

        
    case 3:
        {
            //3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop while, do-while e for.

            int numero = 1;
            int soma = 0;

            Console.WriteLine("Usando while: ");
            Console.WriteLine("Os 10 primeiros numeros naturais sao: ");
            while (numero <= 10)
            {
                Console.WriteLine(numero);
                soma += numero;
                numero++;
            }
            Console.WriteLine("\nA soma dos numeros é: " + soma);


            int numero2 = 1;
            int soma2 = 0;

            Console.WriteLine("\nUsando do while: ");
            Console.WriteLine("Os 10 primeiros numeros naturais sao: ");
            do
            {
                Console.WriteLine(numero2);
                soma2 += numero2;
                numero2++;
            } while (numero2 <= 10);
            Console.WriteLine("\nA soma dos numeros é: " + soma2);



            int soma3 = 0;

            Console.WriteLine("\nUsando for: ");
            Console.WriteLine("Os 10 primeiros numeros naturais sao: ");
            for (int numero3 = 1; numero3 <= 10; numero3++)
            {
                Console.WriteLine(numero3);
                soma3 += numero3;
            }
            Console.WriteLine("A soma dos numeros é: " + soma3);

            break;
        }


    default:
        {
            Console.WriteLine("Você deve selecionar o numero correto da atividade.");

            break;
        }

   
}







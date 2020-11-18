using System;

namespace Funcao_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo WHILE");

            // Console.WriteLine("Digite um numero");
            // //int numero = int.Parse(Console.ReadLine()); -- exemplo 2

            // decimal numero = decimal.Parse(Console.ReadLine());

            // decimal i = 0;
            

            //int valor = 1; -- exemplo 1

            // Console.WriteLine("-----------------");

            //While enquanto condicao for verdadeira
            // //while (valor == 1) -- exemplo 1
            // while (i <= numero)
            // {

                // Console.WriteLine(i);
                // i = i + 0.01m; // inclemento
                //contador ++; //inclemento
                //contador = contador + 2; //inclemento dois em dois 
                //Console.WriteLine("Resposta Verdadeira"); -- exemplo 1

            // };// fim do while

            // string resposta = "";
            // do{
            //     Console.WriteLine("Digite seu email");
            //     resposta = Console.ReadLine();

            // }while(resposta == != "joycessilva17@hotmail.com");
            // Console.WriteLine("Email confirmado");

            //Console.WriteLine("Saiu do while") -- exemplo 1


            // Console.WriteLine("Digite a idade do ator");
            // int idade = int.Parse(Console.ReadLine());
            // while(idade != 47)
            // {
            //     Console.WriteLine("Errou");
            //     Console.WriteLine("Digite a idade do ator novamente")
            //     idade = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine("Acertou miseravi");

            //     int idade;
            //     do{
            //         Console.WriteLine("Digite a idade do ator");
            //         idade = int.Parse(Console.ReadLine());

            //     }while(idade != 47);
            //     Console.WriteLine("Acertou Miseravi");

            //com for
            // for (var contador = 0; contador < 10; contador++)
            // {
            //     //Console.WriteLine(contador);
            //     Console.WriteLine("Digite um valor");
            //     int valor = int.Parse(Console.ReadLine());
            //     Console.WriteLine($"Voce digitou: {valor}");
            // 

            
            //inicio do while atividade
            Console.WriteLine("Qual tabuada voce gostaria de saber?");
            int numero = int.Parse(Console.ReadLine());

            int contador = 0;

            while(contador <=10){
                Console.WriteLine( numero * contador);
                contador = contador +1;

            } //fim do while

            //com for

            Console.WriteLine("Qual tabuada voce gostaria de saber: ");
            int tabuada = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine(tabuada+" x "+i+" = "+tabuada*i);
                //interpolação Console.WriteLine($"{tabuada} x {i} = {resultado}");
            }
            

        }


    }
}

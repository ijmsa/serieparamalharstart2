﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soma = 0;
            var subtracao = 0;
            var multiplicacao = 0;
            var divisao = 0.0m;
               
                Console.WriteLine("Digite algum nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"O nome é: {nome}");
            var materias = new[] { "C#", "Banco de dados" };

            int[] numeros = new int[10];
            numeros[0] = 15;
            numeros[1] = 37;
            numeros[2] = 19;
            numeros[3] = 73;
            numeros[4] = 81;
            numeros[5] = 24;
            numeros[6] = 66;
            numeros[7] = 92;
            numeros[8] = 17;
            numeros[9] = 22;

            //Console.WriteLine(numeros[1]);
            //Console.WriteLine(numeros[2]);
            //Console.WriteLine(numeros[3]);
            //Console.WriteLine(numeros[4]);
            //Console.WriteLine(numeros[5]);
            //Console.WriteLine(numeros[6]);
            //Console.WriteLine(numeros[7]);
            //Console.WriteLine(numeros[8]);
            //Console.WriteLine(numeros[9]);

            //Looping
            /*
             * Repetição ciclica de algo
             * O looping tambem tem o coneceito de infinito
             * Infinito geralmente e um erro.
             * O looping é executado quando tem uma função.
             * O looping quando está em ação tem que ter um gatilho de parada.
             * Resultado: O looping tem uma função repetitiva até que tenha uma parada.
             * 
             * Considerações do professor:
             * =======================================================================
             * Vamos trabalhar com esses dois.
             * -looping finito com controle de sentinela.
             * -looping finito sem controle de sentinela.
             * ================================================================
             * Podemos enfrentar estes dois.
             * -loopinginfinito como um erro.
             * -looping infinito com algum proposito cintífico ou usado em MainFrames.
             * 
             */
            int op;
            do
            {
                Console.WriteLine("1-Listar 2-Processar 3-somar 4-Multiplicar 5-Dividir 6-Subtrair 7-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Mostrando valores: ");
                        //i = i + 1
                        for (var i = 0; i < numeros.Length; i++) 
                        {
                            Console.WriteLine(numeros[i]);
                        }break;
                        case 2:
                        Console.WriteLine("Processando valores: ");
                        foreach (var item in numeros)
                        {
                            soma = soma + item;
                            subtracao = subtracao - item;
                            multiplicacao = multiplicacao * item;
                            divisao = Convert.ToDecimal(divisao) / (item);
                        }break;
                    case 3:
                        Console.WriteLine($"O valor da soma é: {soma}");
                        {}
                        break;
                    case 4:
                        Console.WriteLine($"O valor da subtração é: {subtracao}");
                        {}
                        break;
                    case 5:
                        Console.WriteLine($"O valor da multiplicação é: {multiplicacao}");
                        {}
                        break;
                    case 6:
                        Console.WriteLine($"O valor da divisão é: {divisao}");
                        {}
                        break;
                    case 7:
                        {
                            Console.WriteLine("Programa Finalizado");
                            Console.ReadKey();
                        }
                        break;

                }

                
                

                

            } while (op!=7);
            
        }
    }
}

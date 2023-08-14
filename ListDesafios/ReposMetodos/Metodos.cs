using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListDesafios;

namespace ListDesafios.Metodos
{
    public static class Metodos
    {

        //Crie um array de inteiros com 5 elementos e imprima todos os elementos.
        public static void ImprimirElementos()
        {

            List<int> ExercicioUmlista = new List<int>() { 2, 4, 6, 8, 10 };

            foreach (var numeroLista in ExercicioUmlista)
            {
                Console.WriteLine($" Numero - : {numeroLista}");
            }
           
        }

        //Crie uma lista de strings e adicione 3 nomes a ela, depois imprima todos os nomes.
        public static void ImprimirNomes(string nomeUm, string nomeDois, string nomeTres)
        {

            List<string> ExercicioDoisLista = new List<string>();

            ExercicioDoisLista.Add(nomeUm);
            ExercicioDoisLista.Add(nomeDois);
            ExercicioDoisLista.Add(nomeTres);

            foreach (var nomelistas in ExercicioDoisLista)
            {
                Console.WriteLine($" Nomes Ordenados : {nomelistas}");
            }

        }

        //Inverta os elementos de um array.
        public static void InverterElementos(int numeroum, int numerodois, int numerotres, int numeroquatro, int numerocinco)
        {

            List<int> ListaDeNumeros = new List<int>();
            ListaDeNumeros.Add(numeroum);
            ListaDeNumeros.Add(numerodois);
            ListaDeNumeros.Add(numerotres);
            ListaDeNumeros.Add(numeroquatro);
            ListaDeNumeros.Add(numerocinco);

            ListaDeNumeros.Reverse();

            foreach (var numerosinvertidos in ListaDeNumeros)
            {
                Console.WriteLine($" numeros inevrtidos : {numerosinvertidos}");
            }
        }

        //Calcule a média dos elementos em uma lista de inteiros.
        public static void CalcularMediaElementos(int numeroUM, int numeroDOIS, int numeroTRES, int numeroQUATRO)
        {

            List<int> Ex4List = new List<int>();
            Ex4List.Add(numeroUM);
            Ex4List.Add(numeroDOIS);
            Ex4List.Add(numeroTRES);
            Ex4List.Add(numeroQUATRO);
            double media = Ex4List.Average();

            Console.WriteLine($" A média de todos os numeros da lista é : {media}");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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


        //Converta um array de caracteres em uma string.
        public static void ConverterCharEmString(char charUm, char charDois, char charTres, char charQuatro, char charCinco)
        {
            string letras = string.Concat(charUm, charDois, charTres, charQuatro, charCinco);
            Console.WriteLine(letras);
        }

        //Crie um programa que encontre o maior número em um array de inteiros.
        public static void MaiorNumeroDaLista(int numUm, int numDois, int numTres, int numQuatro, int numCinco)
        {
            List<int> maiorNumeroList = new List<int>();
            maiorNumeroList.Add(numUm);
            maiorNumeroList.Add(numDois);
            maiorNumeroList.Add(numTres);
            maiorNumeroList.Add(numQuatro);
            maiorNumeroList.Add(numCinco);
            int maiornumero = maiorNumeroList.Max();
            Console.WriteLine($" O maior numero da lista é : {maiornumero}");
        }

        //Crie um programa que some todos os elementos de uma lista de inteiros.
        public static void SomarElementosListas(int n1, int n2)
        {
            List<int> ints = new List<int>();
            ints.Add(n1);
            ints.Add(n2);
            int SumInts = ints.Sum();
            Console.WriteLine($" A soma dos itens da lista é de : {SumInts}");

        }

        //Crie um array 2D 3x3 e preencha com números. Imprima a diagonal principal.
        public static void Array3X3()
        {
            int[,] matriz = new int[3, 3];

            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;
            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;
            matriz[2, 0] = 7;
            matriz[2, 1] = 8;
            matriz[2, 2] = 9;

            Console.WriteLine("Diagonal principal : ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(matriz[i, i]);
            }
            Console.WriteLine();
        }

        //Crie um programa que remova um elemento específico de um array de strings.
        public static void RemoverElementosDaLista(string inputstring)
        {

            List<string> listadestrings = new List<string>() { "Abacate", "maça", "banana", "jacare", "manga" };
            foreach (var itens in listadestrings)
            {
                Console.WriteLine($" Lista de itens abaixo : {itens}");
            }

            Console.WriteLine(" Digite um dos itens para remover da lista :");
            listadestrings.Remove(inputstring);

            foreach (var itensnovos in listadestrings)
            {
                Console.WriteLine($"Lista de itens atualizada : {itensnovos}");
            }
        }

        //Crie um programa que adicione elementos em uma lista até que o usuário diga 'parar'.
        // finalizar
        public static void AdicionarElementosAteParar()
        {
            List<string> elementos = new List<string>();
            Console.WriteLine(" Digite PARAR para encerrar a adiç]ao de elementos na lista ");

            while (true)
            {
                Console.WriteLine("Digite alguma nome / palavra :");
                string elemento = Console.ReadLine();
                if (elemento.ToLower() != "parar")
                {
                    elementos.Add(elemento);

                }
                else if (elemento.ToLower() == "parar")
                {
                    Console.WriteLine("Lista de elementos : ");
                    foreach (var element in elementos)
                    {
                        Console.WriteLine(element);
                    }
                }

            }
        }
        //Crie um método que clone uma lista de inteiros. 
        public static void ClonarListaInt()
        {
            List<string> listafonte = new List<string>() { "Abacate", "Sapato", "Freira" };
            List<string> ListaClonada = new List<string>(listafonte);
            Console.WriteLine(string.Join(",", ListaClonada));
        }

        //Ordene uma lista de strings alfabeticamente.
        public static void OrdenarAlfabeticamente()
        {
            List<string> listadesordenada = new List<string>() { "A", "C", "D", "F", "G", "B", "H", "I", "E" };
            listadesordenada.Sort();
            foreach (var strings in listadesordenada)
            {
                Console.WriteLine($" Strings em ordem alfabetica {strings}");
            }
        }
        //Concatene duas listas de inteiros.
        public static void ConcatenarListaInteiros()
        {
            List<int> inteirosA = new List<int> { 1, 2, 3, 4, 5 };
            List<int> inteirosB = new List<int> { 6, 7, 8, 9, 10 };
            var listacontatenada = inteirosA.Concat(inteirosB);
            foreach (var concatenados in listacontatenada)
            {
                Console.WriteLine($"Lista A e B concatenados - {concatenados}");
            }
        }

        //Remova duplicatas de uma lista de inteiros.
        public static void RemoverDuplicatasInt()
        {
            List<int> intsDuplicados = new List<int>() { 1, 1, 3, 3, 7, 8, 10, 12, 12, 6, 9, 6 };
            List<int> distinct = intsDuplicados.Distinct().ToList();
            Console.WriteLine(String.Join(",", distinct));
        }

        //Rotacione os elementos de uma lista(e.g., `[1,2,3]` torna-se `[3,1,2]`)


        //Verifique se uma lista de inteiros está ordenada.
        public static void IsOrdered()
        {
            List<int> intsDesordenados = new List<int>() { 1, 3, 6, 7, 10 };
            bool isOrdered = intsDesordenados.SequenceEqual(intsDesordenados.OrderBy(x => x));
            if (isOrdered == false)
            {
                Console.WriteLine(" A lista que você iseriu não é ordenada !");
            }
            else if (isOrdered == true)
            {
                Console.WriteLine(" A lista que você inseriu é ordenada ! ");
            }

        }

        //Some dois arrays de inteiros.
        public static void SomarArrays()
        {
            int[] intum = new int[] { 1, 2, 3, 4 };
            int[] intdois = new int[] { 5, 6, 7, 8 };

            if (intum.Length != intdois.Length)
            {
                Console.WriteLine(" Os arrays tem tamanhos diferentes, não podem ser somados");
            }
            int[] resultado = new int[intum.Length];
            for (int i = 0; i < intum.Length; i++)
            {
                resultado[i] = intum[i] + intdois[i];
            }
            foreach (var itens in resultado)
            {
                Console.WriteLine($" Resultado da soma dos arrays {itens}");
            }
        }

        //Encontre elementos comuns entre dois arrays de inteiros.
        public static void IntersecçãoDearray()
        {
            int[] int1 = new int[] { 1, 2, 3, 5, 7, 8 };
            int[] int2 = new int[] { 1, 3, 5, 8, 10, 7 };

            var interseccao = int1.Intersect(int2);
            Console.WriteLine(" Elementos em comum entre os dois arrays :");
            foreach (var item in interseccao)
            {
                Console.WriteLine($" - {item}");
            }
        }

        //Utilizando LINQ, filtre os números pares de uma lista.
        public static void LinqFiltroPars()
        {
            List<int> intpares = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 14 };
            var pares = intpares.Where(p => p % 2 == 0).ToList();
            foreach (var item in pares)
            {
                Console.WriteLine($"Numeros pares da lista :  {item}");
            }
        }
        //Encontre o elemento mais frequente em uma lista.
        public static void ElementoMaisFrequente() 
        {
            List<int> ints = new List<int>() { 1, 1, 2, 4, 6, 7, 8, 1, 1, 10, 15 };
            var resultado = ints.GroupBy(i => i);
            foreach (var item in resultado)
            {
                Console.WriteLine($"item : {item.Key} / ocorrência {item.Count()}");
            }
        }

    }
}

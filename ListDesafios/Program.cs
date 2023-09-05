using ListDesafios.Metodos;
using ListDesafios.Modelos;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace ListDesafios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basicos
            //Crie um array de inteiros com 5 elementos e imprima todos os elementos.
            /*
            Metodos.Metodos.ImprimirElementos();
            Console.ReadLine();
            Console.Clear();
            


            //Crie uma lista de strings e adicione 3 nomes a ela, depois imprima todos os nomes.
            Metodos.Metodos.ImprimirNomes("Erick","Augusto","Krug");
            Console.ReadLine();
            Console.Clear();
            
            //Inverta os elementos de um array.
            Metodos.Metodos.InverterElementos(1,2,3,4,5);
            Console.ReadLine();
            Console.Clear();


            //Calcule a média dos elementos em uma lista de inteiros.
            Metodos.Metodos.CalcularMediaElementos(2,4,6,8);
            Console.ReadLine();
            Console.Clear();

            
            //Converta um array de caracteres em uma string.
            Metodos.Metodos.ConverterCharEmString('A','B','C','D','E');
            Console.ReadLine();
            Console.Clear();
            */
            #endregion Basicos

            #region Intermediario


            //Crie um programa que encontre o maior número em um array de inteiros.
            //Metodos.Metodos.MaiorNumeroDaLista(1, 2, 3, 4, 5);

            //Crie um programa que some todos os elementos de uma lista de inteiros.
            //Metodos.Metodos.SomarElementosListas(100, 400);

            //Crie um array 2D 3x3 e preencha com números. Imprima a diagonal principal.
            //Metodos.Metodos.Array3X3();

            //Crie um programa que remova um elemento específico de um array de strings.
            //Metodos.Metodos.RemoverElementosDaLista("Abacate");

            //Crie um programa que adicione elementos em uma lista até que o usuário diga 'parar'.
            //Metodos.Metodos.AdicionarElementosAteParar();

            //Crie um método que clone uma lista de inteiros. 
            //Metodos.Metodos.ClonarListaInt();

            //Ordene uma lista de strings alfabeticamente.
            //Metodos.Metodos.OrdenarAlfabeticamente();

            //Concatene duas listas de inteiros.
            //Metodos.Metodos.ConcatenarListaInteiros();

            //Remova duplicatas de uma lista de inteiros.
            //Metodos.Metodos.RemoverDuplicatasInt();

            // Rotacione os elementos de uma lista (e.g., `[1,2,3]` torna-se `[3,1,2]`).

            //Verifique se uma lista de inteiros está ordenada.
            //Metodos.Metodos.IsOrdered();

            //Some dois arrays de inteiros.
            //Metodos.Metodos.SomarArrays();

            #endregion Intermediario 

            #region Avancado
            //Crie uma classe `Pessoa` e faça uma lista de pessoas. Adicione 3 pessoas e imprima seus nomes.
            //Modelos.Pessoas.listadepessoas();

            //Encontre elementos comuns entre dois arrays de inteiros.
            //Metodos.Metodos.IntersecçãoDearray();

            //Implemente uma lista ligada simples.

            //Utilizando LINQ, filtre os números pares de uma lista.
            //Metodos.Metodos.LinqFiltroPars();

            //Encontre o elemento mais frequente em uma lista.
            //Metodos.Metodos.ElementoMaisFrequente();

            //Utilize delegates para processar uma lista de inteiros.
            //Metodos.Metodos.ProcessarListasDelegate();

            //Encontre a interseção de duas listas usando LINQ.
            //Metodos.Metodos.InterseccaoDeListas();

            // Encontre o subarray contínuo dentro de um array que tem a soma máxima.
            //Metodos.Metodos.subsarrays();

            //Implemente uma fila (queue) usando lista.
            //Metodos.Metodos.listqueue();


            //Crie uma classe genérica que possa trabalhar com listas de diferentes tipos.



            #endregion Avancado
        }
    }
}
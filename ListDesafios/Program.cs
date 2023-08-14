using ListDesafios.Metodos;

namespace ListDesafios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um array de inteiros com 5 elementos e imprima todos os elementos.
            /*
            Metodos.Metodos.ImprimirElementos();
            Console.ReadLine();
            Console.Clear();
            */


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

        }
    }
}
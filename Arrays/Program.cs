using System;

namespace Arrays
{
    public class Program {

        public static void ExLINQ(){
            int[] arrayNumeros = new int[10] {100, 1, 4, 8, 0, 15, 19, 19, 4, 100};

            var minimo = arrayNumeros.Min(); // pega valor minimo
            var maximo = arrayNumeros.Max(); // retorna valor maximo
            var medio = arrayNumeros.Average(); // retorna a média dos valores (soma/qtd de elementos)

            var soma = arrayNumeros.Sum(); // retorna soma total
            var arrayUnico = arrayNumeros.Distinct().ToArray(); // retorna todos os elementos distintos 
            //(se houver algum igual, apenas um deles será retornado)

            Console.WriteLine($"Minimo: {minimo}   Maximo: {maximo}    Medio: {medio}");
            Console.WriteLine($"Soma total: {soma}");
            Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            Console.WriteLine($"Array unico: {string.Join(", ", arrayUnico)}");
            var numerosPares = 
                from num in arrayNumeros //a cada elemento NUM no array
                where num % 2 == 0 // onde o resto da divisão por 2 for = 0
                orderby num // ordena crescente
                select num; // seleciona 


            var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            // faz o mesmo que a forma de cima, entretanto em uma linha só

            Console.WriteLine($"Numeros Pares Query: {string.Join(", ", numerosPares)}");
            Console.WriteLine($"Numeros Pares Metodo: {string.Join(", ", numerosParesMetodo)}");

        }
        public static void Main(){

            OperacoesArray op = new OperacoesArray();
            int[] array = new int [5]{5,3,6,2,8};
            int[] arrayCopia = new int [10];

            bool existe = op.Existe(array, 1);


            if (existe) Console.WriteLine("Encontrado");
            else Console.WriteLine("Não econtrado");

            Console.WriteLine("Array atual: ");
            op.ImprimirArray(array);

            Console.WriteLine("");
            //op.Ordenar(ref array);

            //Console.WriteLine("Ordenado:");
            //op.ImprimirArray(array);

            Console.WriteLine("");
            Console.WriteLine("Array antes da copia: ");
            op.ImprimirArray(arrayCopia);

            op.Copiar(ref array, ref arrayCopia);
            Console.WriteLine("Array após a copia: ");
            op.ImprimirArray(arrayCopia);

            ExLINQ();
        }
    }
}
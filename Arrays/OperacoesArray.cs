using System;

namespace Arrays
{
    public class OperacoesArray
    {
        public void ImprimirArray(int[] array){
            var linha = string.Join(", ",array);
            Console.WriteLine(linha);
        }

        public void Ordenar(ref int[] array){
            Array.Sort(array);
        }

        public void Copiar(ref int [] array, ref int [] arrayDestino){
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor){
            
            return Array.Exists(array, elemento => elemento == valor); 
            //varre todo o array e verifica se o elemento (nome qualquer para variavel) existe dentro do array
            //quase como um for ou foreach
        }
    }
}
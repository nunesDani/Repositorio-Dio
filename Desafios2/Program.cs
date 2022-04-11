using System; 
using System.Collections.Generic;

class Program{

    static void SequenciaLogica(){
        int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int NxN = i*i;
                int NxNxN = i*i*i ;
                Console.WriteLine($"{i} {NxN} {NxNxN}");
                Console.WriteLine($"{i} {NxN+1} {NxNxN+1}");
            }
    }

    static void ContagemDeCedulas(){
        int n, nota, quociente, resto;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;

            nota = 100;
            quociente = resto / 100;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % 100;

           //Continue com a sua lógica aqui
           
            nota = 50;
            quociente = resto / 50;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % 50;
            
            nota = 20;
            quociente = resto / 20;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % 20;
            
            nota = 10;
            quociente = resto / 10;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % 10;
            
            nota = 5;
            quociente = resto /5;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % 5;
            
            nota = 2;
            quociente = resto / 2;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % 2;
            
            nota = 1;
            quociente = resto / 1;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % 1;
            
            Console.ReadLine();
            

    }

    static void ComprasSupermercado(){
            var limite = int.Parse(Console.ReadLine());
    // Implemente a solução aqui
    List<string> lista = new List<string>();
    
        for (int i = 0; i < limite; i++){
            string[] linha = Console.ReadLine().Split(" ");
            Ordenar(ref linha);    

            for(int j = 0; j < linha.Length; j++){
                if(!lista.Contains(linha[j])){
                    lista.Add(linha[j]);
                }
            }

            Console.WriteLine(string.Join(" ", lista));
            lista.Clear();
        }
    }

    static void Main() { 
        //Exercícios do Desafio 2, os quais eu preferi testar algumas vezes antes de entregar
    }

    public static void Ordenar(ref string[] array){
        Array.Sort(array);
    }

}



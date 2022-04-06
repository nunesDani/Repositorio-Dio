using static System.Console;

public class Program{

    static void Demo1(){
        int a = 2;
        a= Adicionar20(a);
        WriteLine($"Valor: {a}");
    }

    static void Demo2(){
        Pessoa p1 = new Pessoa();
        p1.Nome = "Gustavinho";
        p1.Idade = 22;
        p1.Documento = "Amor da vida da Daninha";

        Pessoa p2 = p1.Clone();

        WriteLine($"Nome anterior: {p1.Nome}");
        TrocarNome(p1, "Gustavinho Lindo da Daninha");
        WriteLine($"Nome p1: {p1.Nome} e p2: {p2.Nome}");
    }

    static void Demo3(){
            StructPessoa p1 = new StructPessoa{
            Documento = "lindo",
            Nome = "Gustavinho",
            Idade = 22
        };

        var p2 = p1;

        p1 = TrocarNome(p1,"Gustavinho Lindo");
        
        WriteLine($"Nome p1: {p1.Nome} e p2: {p2.Nome}");
    }

    static void Demo4(){
            string nome = "Gustavinho";
            nome= TrocarNome(nome, "Lindo Lindo");

            WriteLine(nome);
    }

    static void Demo5(){
        int[] pares = new int []{0,2,4,6,8};
        MudarParaImpar(pares);
        WriteLine($"Os ímpares são: {string.Join(", ", pares)}");
    }

    static void Demo6(){
          int[] numeros = new int[] {0,2,4,6,8};
        WriteLine($"Digite o número que gostaria de encontrar");
        var num = int.Parse(ReadLine());

        var idxEncontrado = EncontrarNumero(numeros, num);

        if(idxEncontrado >=0)
            WriteLine($"O número digitado está na localização {idxEncontrado}");
        else 
            WriteLine($"O número digitado não foi encontrado.");
    }

    static int Adicionar20(int x){
        return x+20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo){
        p1.Nome = nomeNovo;
    }

    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo){
        p1.Nome = nomeNovo;
        return p1;
    }

    static string TrocarNome(string nome, string nomeNovo){
        // caso método seja void (sem retorno), ele troca o nome dentro da função, 
        //mas fora dela não acontece nada
        nome=nomeNovo;
        return nome;
    }

    static void MudarParaImpar(int[] pares){
        for (int i=0; i < pares.Length;i++){
            pares[i] +=1;
        }
    }

    static int EncontrarNumero(int[] numeros, int numero){
        for(int i=0; i < numeros.Length; i++){
            if(numeros[i] == numero)
            return i;
        }
        return -1;
    }

    static bool EncontrarPessoa(List<Pessoa> pessoas, string nome){
        //troquei o segundo parametro de entrada por string, desta forma, não é necessário 
        //criar outra instância de Pessoa apenas para fazer o comparativo

        foreach(Pessoa p in pessoas){
            if (p.Nome == nome){
                return true;
            }
        }            
        return false;
    }

    static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa){
        foreach(StructPessoa item in pessoas){
            if (item.Equals(pessoa)){ 
                // Equals compara os valores, portanto funciona com as Structs, pois compara
                // valores e não a referência (no caso se fosse uma Classe)
                return true;
            }
        }            
        return false;
    }

    public static void Main(){
        List<StructPessoa> pessoas = new List<StructPessoa>()
        {
            new StructPessoa(){Nome = "Ricardo"},
            new StructPessoa(){Nome = "José"},
            new StructPessoa(){Nome = "Maria"},
            new StructPessoa(){Nome = "Fabiana"},
            new StructPessoa(){Nome = "Eduardo"},
        };

        WriteLine("Digite a pessoa que gostaria de localizar.");
        var nome = ReadLine();
        var pessoa = new StructPessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas,pessoa);

        if(encontrado) WriteLine("Pessoa localizada.");
        else WriteLine("Pessoa não localizada.");

    }

}
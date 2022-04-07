using System;
using ExemploConstrutores.Models;

class Program{

    static void ExConstrutorPrivado(){
        Log log = Log.GetInstance();

        log.PropriedadeLog = "Instancia teste 1.";

        Log log2 = Log.GetInstance();
        Console.WriteLine(log2.PropriedadeLog);

        // neste exemplo, o objeto é instanciado apenas uma vez mesmo chamando o método duas vezes,
        // isso acontece porque o objeto é instanciado e guardado na própria classe, e o método 
        // GetInstance apenas retorna o mesmo objeto
    }

    static void ExGetSet(){
        Data data = new Data();

        //data.SetMes(2); atribuição de valor através do método criado separadamente
        //data.ApresentarMes(); método criado dentro da classe para escrever o valor

        data.Mes = 5; // atribuição de valor através do método SET da PROPRIEDADE
        Console.WriteLine(data.Mes); //acessa o valor através do GET da PROPRIEDADE

        //Dessa forma não é necessário métodos avulsos para acessar o valor e nem para atribuir
    }


    public delegate void Operacao(int x, int y);

    static void ExDelegate(){
        Operacao op = new Operacao(Calculadora.Somar); // Operacao op = Calculadora.Somar; também funciona sem o NEW
        
        op += Calculadora.Subtrair; // adiciona outro método ao delegate SEM perder a referência ao método anterior

        op.Invoke(10,10); //op(10,10); também funciona sem o INVOKE
        
        // executa todos os métodos dentro do delegate em forma de fila
        // (o primeiro a entrar é o primeiro a ser executado)
    }

    static void ExEventos(){
        Matematica m = new Matematica(10,20);
        
        m.Somar();

        //Neste exemplo, ao criar um objeto do tipo Matematica, a função EventHandler é inscrita no EventoCalculadora
        //Ao chamar a função Somar de matemática (que chama a função Somar de Calculadora), é verificado que há
        //um iscrito em EventoCalculadora, disparando todos os métodos dentro de EventoCalculadora
        //Que neste caso, havia apenas o método EventHandler
    }

    static void Main(){


    }
}
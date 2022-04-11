using System;
using Exceptions;

public class Program{
    public static void Main (){
        int a = 100, b=0;
        double resultado;

        try{
        resultado = Dividir(a,b);

        Console.WriteLine($"{a} / {b} = {resultado}");
        } 

        catch(DivideByZeroException ex) when (a < 0){ // mesmo que seja essa a exceção, esse bloco não será executado pois não atende a condição WHEN
            Console.WriteLine(ex.Message);
        }
        
        catch(Exception ex){ // captura a exceção ocorrida e informa
            Console.WriteLine(ex.Message);
        }
        finally{ // bloco executado independente se a exceção foi tratada ou não
            Console.WriteLine("Finalmente a divisão foi finalizada.");
        }
        

    }

    public static double Dividir(int a, int b){
        if(b == 0){
            throw new MyClassException("Minha mensagem de erro!"); // lançar exceção diretamente
        }
        else return a/b;
    }


}
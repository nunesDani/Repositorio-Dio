namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        
        //Delegate
        public delegate void DelegateCalculadora();

        //Evento do tipo DelegateCalculadora de nome EventoCalculadora
        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y){

            if(EventoCalculadora != null){
                Console.WriteLine($"Adição: {x+y}");
                EventoCalculadora();
            }
            else{
                Console.WriteLine("Nenhum inscrito.");
            }
        }

        public static void Subtrair (int x, int y){
            Console.WriteLine($"Subtração: {x-y}");
        }
    }
}
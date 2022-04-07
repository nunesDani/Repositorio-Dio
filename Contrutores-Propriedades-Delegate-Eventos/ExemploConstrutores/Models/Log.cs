namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log _log;

        public string PropriedadeLog { get; set; }

        private Log(){
            //construtor privado, a instanciação é feita através do método publico GetInstance

        }

    public static Log GetInstance(){ 

        //verifica se há um log criado, e se houver, retorna a mesma instância, garantindo apenas
        //um objeto durante todo o ciclo de vida da aplicação.

        if(_log == null){
            _log = new Log();
        }
        return _log;

    }



    }
}
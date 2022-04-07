namespace ExemploConstrutores.Models
{
    public class Data
    {
        //Ex em que a propriedade é privada, mas podemos acessar e alterar o seu valor através dos métodos
        //Get e Set, onde o Get apenas retorna o seu valor (mas poderia fazer outras coisas além de retornar),
        //e o método Set altera o valor do mês desde que o valor novo atenda às condições.
        //Dessa forma podemos acessar e alterar o valor de uma variável mesmo ela sendo privada, e sem 
        //nos preocuparmos em atribuições de valor inadequado.

        private int mes;
        private bool mesValido;

        public int GetMes(){
            return this.mes;
        }

        public void SetMes(int mes){
            if (mes > 0 && mes <= 12){
                this.mes = mes;
                this.mesValido = true;
            }
            else this.mesValido = false;
                
        }


        public int Mes { 
            get{
                return this.mes;
            }
        
            set{
                if(value > 0 && value <= 12){
                    this.mes = value;
                    this.mesValido = true;
                }
                else{
                    this.mesValido = false;
                }
            }
         
         }


        public void ApresentarMes(){
            if (this.mesValido){
                Console.WriteLine(this.mes);
            }
            else
                Console.WriteLine("Mês inválido!");
        }

    }
}
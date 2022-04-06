namespace dotnetPOO.src.Entities
{
    public class Hero
    {

        public Hero(string Name, int Level, string HeroType) // Constructor
        {
            this.Name = Name; // this -> indica que a propriedade Name declarada lá embaixo, irá receber o Name informado no parâmetro
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero(){

        }

        protected string Name;
        protected string HeroType;
        protected int Level;

        protected int HP;
        protected int MaxHP;
        protected int HPPerLevel; 

        protected float Damage;
        protected float DmgPerLevel;


        public override string ToString(){
            return $@"Name: {this.Name}      Level: {this.Level}     Class: {this.HeroType}
HP: {this.HP}         AD: {this.Damage}
";
        }

        public virtual string Attack(Enemy enemy){
            return $"{this.Name} atacou com sua espada!";
        }

        protected virtual void LevelUp(){
            this.Level++;
            this.MaxHP+=HPPerLevel;
            this.HP = MaxHP;
            this.Damage += DmgPerLevel;

            Console.WriteLine("\nLEVEL UP!");

            ToString();
        }
        


    }
}
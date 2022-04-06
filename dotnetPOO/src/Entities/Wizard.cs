namespace dotnetPOO.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name)
        {
            this.Name = Name; 
            this.Level = 1;
            this.HeroType = "Wizard";

            this.MaxHP = 16;
            this.HP = MaxHP;
            this.HPPerLevel = 3;

            this.Damage = 10f;
            this.DmgPerLevel = 4.5f;
        }


    }
}
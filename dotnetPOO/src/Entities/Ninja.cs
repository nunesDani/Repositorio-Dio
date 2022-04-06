namespace dotnetPOO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name)
        {
            this.Name = Name; 
            this.Level = 1;
            this.HeroType = "Ninja";

            this.MaxHP = 12;
            this.HP = MaxHP;
            this.HPPerLevel = 3;

            this.Damage = 15f;
            this.DmgPerLevel = 4.5f;
        }
    }
}
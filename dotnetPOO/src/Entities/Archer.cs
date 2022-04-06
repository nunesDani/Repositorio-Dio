namespace dotnetPOO.src.Entities
{
    public class Archer : Hero
    {
        public Archer(string Name)
        {
            this.Name = Name; 
            this.Level = 1;
            this.HeroType = "Archer";

            this.MaxHP = 16;
            this.HP = MaxHP;
            this.HPPerLevel = 3;

            this.Damage = 12f;
            this.DmgPerLevel = 3.8f;
        }
    }
}
namespace dotnetPOO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name) // Constructor
        {
            this.Name = Name; 
            this.Level = 1;
            this.HeroType = "Knight";

            this.MaxHP = 20;
            this.HP = MaxHP;
            this.HPPerLevel = 5;

            this.Damage = 8f;
            this.DmgPerLevel = 3.5f;
            
        }

        


    }
}
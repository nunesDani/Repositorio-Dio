namespace dotnetPOO.src.Entities
{
    public class Enemy
    {
        public Enemy(int turn){
            this.Name = "Monster";
            HP = 10*turn;
            Dmg = 5*turn;
        }

        private float HP;
        private float Dmg;
        private string Name;

        public void TakeDamage(float dmg){
            this.HP-= dmg;
            if (this.HP <= 0){
                GC.Collect();
            }
        }

    }
}
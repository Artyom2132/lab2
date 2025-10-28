using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Pistol
    {
        private int bullets;
        public int Bullets
        {
            get { return bullets; }
            private set { bullets = value; }
        }

        public Pistol()
        {
            Bullets = 5;
        }

        public Pistol(int bullets)
        {
            Bullets = bullets >= 0 ? bullets : 0;
        }

        public void Shoot()
        {
            if (Bullets > 0)
            {
                Console.WriteLine("Бах!");
                Bullets--;
            }
            else
            {
                Console.WriteLine("Клац!");
            }
        }
    }
}
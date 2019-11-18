using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavLidi
{
    class Dice
    {
        public int sides = 6;
        public int[] hits;
        public int rolls = 0;
        static Random random = new Random();
        public Dice(int sides) {
            this.sides = sides;
            this.hits = new int[sides];
        }
        public Dice() {
            this.sides = 6;
        }

        public int Roll() {
            this.rolls += 1;
            return random.Next(1, sides + 1);
        }
    }
}

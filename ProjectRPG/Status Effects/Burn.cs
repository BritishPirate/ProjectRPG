using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Burn : StatusEffect {
        public Burn(int initAmount, int initDuration) : base(initAmount,initDuration) { }
        public void tick(bool enemy, int x, int y, Combat combat) {
            combat.loseHealth(enemy, x, y, amount, new lose[] { lose.fire, lose.burn });
            if(amount == 1) { amount = 0; }
            else { amount = amount / 2; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG.Status_Effects {
    class Poison : StatusEffect {
        public Poison(int initAmount, int initDuration) : base(initAmount, initDuration) { }
        public void tick(bool enemy, int x, int y, Combat combat) {
            if(enemy) {
                combat.loseHealth(enemy, x, y, amount, new lose[] { lose.physical, lose.poison });
                duration -= 1;
            }
        }
    }
}

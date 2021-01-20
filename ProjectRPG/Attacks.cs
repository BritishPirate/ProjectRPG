using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Attacks : Actions {
        public static void attack(bool enemy, int x, int y, int damage, Combat combat) {
            combat.loseHealth(enemy, x, y, damage, new lose[] {lose.physical });
        }
        public static void heavyAttack(bool enemy, int x, int y, int damage, Combat combat) {
            combat.loseHealth(enemy, x, y, damage * 2, new lose[] { lose.physical });
            combat.loseStam(enemy, x, y, 1, new lose[] { lose.cost });
        }
    }
}

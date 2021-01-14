using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Attacks : Actions {
        public static void attack(bool target, int x, int y, int damage, Combat combat) {
            combat.dealDamage(target, x, y, damage);
        }
    }
}

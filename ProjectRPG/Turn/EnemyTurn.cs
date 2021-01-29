using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class EnemyTurn : Turn {
        public EnemyTurn(int x, int y, Combat combat) : base(x, y, combat) {
            combat.enemyGrid.grid[x][y].applyRegen();
            MainSequence(x, y, combat);
        }

        private void MainSequence(int x, int y, Combat combat) {
            Printer.enemyAttack();
            Attacks.attack(false, 1, 1, 1, combat);
        }
    }
}

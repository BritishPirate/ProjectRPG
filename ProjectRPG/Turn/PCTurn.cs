using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG { 
    class PCTurn : Turn {
        public PCTurn(int x, int y, Combat combat) : base(x, y, combat) {
            combat.applyRegen(false, x, y);
            MainSequence(x, y, combat);
        }

        private void MainSequence(int x, int y, Combat combat) {
            Printer.playerTurn();
            switch(Console.ReadLine()) {
                case "ba":
                    Attacks.attack(true, 0, 1, 1, combat);
                    Printer.PCAttack();
                    break;
                default:
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG { 
    class PCTurn : Turn {
        public PCTurn(int x, int y, Combat combat) : base(x, y, combat) {
            Printer.playerTurn();
            if(Console.ReadLine() == "a") { //INPUT
                Attacks.attack(true, 0, 1, 1, combat);
            }
        }
    }
}

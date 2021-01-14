using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Turn {
        public Turn(int x, int y, Combat combat) {
            Printer.playerTurn();
            if(Console.ReadLine() == "a") { //INPUT
                Attacks.attack(true, 0, 1, 1, combat);
            }
        }

        private void playerTurn() { //Give coords of char taking turn?
            
        }
    }
}

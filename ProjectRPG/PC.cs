using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class PC : Creature {
        public PC(pcs character) {
            switch(character) {
                case pcs.Fighter:
                    this.name = "Fighter";
                    this.hp = 20;
                    this.speed = 1;
                    break;
                default:
                    break;
            }
        }
    }
    enum pcs {
        Fighter
    }
}

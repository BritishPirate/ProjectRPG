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
                    this.speed = 2;
                    this.maxMana = 2;
                    this.maxStam = 5;
                    break;
                default:
                    break;
            }
            this.curMana = this.maxMana;
            this.maxStam = this.maxStam;
        }
    }
    enum pcs {
        Fighter
    }
}

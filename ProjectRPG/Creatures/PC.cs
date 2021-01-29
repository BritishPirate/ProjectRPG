using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class PC : Creature {
        public PC(pcs character) {
            switch(character) {
                case pcs.Fighter:
                    name = "Fighter";
                    maxHP = 20;
                    speed = 2;
                    maxMana = 2;
                    maxStam = 5;
                    regenStam = 1;
                    break;
                default:
                    break;
            }
            curHP = maxHP;
            curMana = maxMana;
            curStam = maxStam;
        }
    }
    enum pcs {
        Fighter
    }
}

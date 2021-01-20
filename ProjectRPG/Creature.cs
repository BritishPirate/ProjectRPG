using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Creature {
        public string name;
        public int maxHP;
        public int curHP;
        public int regenHP;
        public int maxMana;
        public int curMana;
        public int regenMana = 0;
        public int maxStam;
        public int curStam;
        public int regenStam = 0;
        public int speed;
        public int attack;
        public bool isDead() {
            if(this == null) { return false; }
            if(this.curHP <= 0) { return true; }
            return false;
        }
    }
}

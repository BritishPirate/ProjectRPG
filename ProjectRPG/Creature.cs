using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Creature {
        public string name { get; set; }
        public int hp { get; set; }
        public int maxMana { get; set; }
        public int curMana { get; set; }
        public int maxStam { get; set; }
        public int curStam { get; set; }
        public int speed { get; set; }
        public int attack { get; set; }
        public bool isDead() {
            if(this == null) { return false; }
            if(this.hp <= 0) { return true; }
            return false;
        }
    }
}

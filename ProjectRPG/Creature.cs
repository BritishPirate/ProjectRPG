using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Creature {
        public string name { get; set; }
        public int hp { get; set; }

        public bool isDead() {
            if(this == null) { return false; }
            if(this.hp <= 0) { return true; }
            return false;
        }
    }
}

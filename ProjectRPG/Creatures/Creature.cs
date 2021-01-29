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
        public Dictionary<lose, int> loseMult = new Dictionary<lose, int>();
        public Dictionary<gain, int> gainMult = new Dictionary<gain, int>();
        public List<StatusEffect> statusEffects = new List<StatusEffect>();
        public bool isDead() {
            if(this == null) { return false; }
            if(this.curHP <= 0) { return true; }
            return false;
        }

        public void tickStatusEffects() { //TODO: Add a way to comfortably choose a specific effect to tick

        }
        public void updateStatusEffects() {
            int i = 0;
            foreach(StatusEffect effect in statusEffects) {
                if(effect.amount == 0 || effect.duration == 0) {
                    statusEffects.RemoveAt(i);
                }
                i++;
            }
        }
    }
}

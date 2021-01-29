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

        public void applyRegen() {
            gain[] types = new gain[] { gain.natural, gain.regeneration };
                gainHealth(regenHP, types);
                gainMana(regenMana, types);
                gainStam(regenStam, types);
        }

        public void loseHealth(int amount, lose[] type) {
            curHP -= (int)Math.Round(amount * loseMultCalc(type), 0);
            curHP -= (int)Math.Round(amount * loseMultCalc(type), 0); 
        }

        public void gainHealth(int amount, gain[] type) {
            curHP += (int)Math.Round(amount * gainMultCalc(type), 0);
            curHP += (int)Math.Round(amount * gainMultCalc(type), 0);
        }

        public void loseMana(int amount, lose[] type) {
            curMana -= (int)Math.Round(amount * loseMultCalc(type), 0);
            if(curMana < 0) { curMana = 0; }
        }

        public void gainMana(int amount, gain[] type) {
            curMana += (int)Math.Round(amount * gainMultCalc(type), 0);
            if(curMana > maxMana) { curMana = maxMana; }
        }

        public void loseStam(int amount, lose[] type) {
            curStam -= (int)Math.Round(amount * loseMultCalc(type), 0);
            if(curStam < 0) { curStam = 0; }
        }

        public void gainStam(int amount, gain[] type) {
            curStam += (int)Math.Round(amount * gainMultCalc(type), 0);
            if(curStam > maxStam) { curStam = maxStam; }
        }

        private float loseMultCalc(lose[] type) {
            float mult = 1;
            foreach(lose l in type) {
                if(loseMult.ContainsKey(l)) {
                    mult = mult * loseMult[l];
                }
            }
            return mult;
        }

        private float gainMultCalc(gain[] type) {
            float mult = 1;
            foreach(gain l in type) {
                if(gainMult.ContainsKey(l)) {
                    mult = mult * gainMult[l];
                }
            }
            return mult;
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

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class StatusEffect {
        public int amount;
        public int duration;

        public StatusEffect(int initAmount, int initDuration = -1) {
            initAmount = amount;
            initDuration = duration;
        }

        public void update(bool set, int updatedAmount = -1, int updatedDuration = -1) {
            if(set) {
                if(updatedAmount != -1) { amount = updatedAmount; }
                if(updatedDuration != -1 && duration != -1) { duration = updatedDuration; }
            }
            else {
                if(updatedAmount != -1) { amount += updatedAmount; }
                if(updatedDuration != -1 && duration != -1) { duration += updatedDuration; }
            }
        }

        public void tick() { }
        /* Status Effects I need to Implement 
                Burn - x damage per turn, halves every turn (80% atk?)
                Poison - x damage per turn for y turns (Set values)
                Stunned - Skips turn
                antiHeal - prevents the next x health gained (150% attack?)
         */
    }
}

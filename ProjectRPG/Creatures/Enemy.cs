using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Enemy : Creature {
        public Enemy(EnemyType t) {
            switch (t){
                case EnemyType.Goblin:
                    name = "Goblin";
                    maxHP = 2;
                    speed = 1;
                    maxMana = 0;
                    maxStam = 1;
                    break;
                case EnemyType.Skeleton:
                    name = "Skeleton";
                    maxHP = 3;
                    speed = 3;
                    maxMana = 0;
                    maxStam = 2;
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
    enum EnemyType {
        Goblin,
        Skeleton
    }
}

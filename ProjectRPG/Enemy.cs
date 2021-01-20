using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Enemy : Creature {
        public Enemy(EnemyType t) {
            switch (t){
                case EnemyType.Goblin:
                    this.name = "Goblin";
                    this.hp = 2;
                    this.speed = 1;
                    this.maxMana = 0;
                    this.maxStam = 1;
                    break;
                case EnemyType.Skeleton:
                    this.name = "Skeleton";
                    this.hp = 3;
                    this.speed = 3;
                    this.maxMana = 0;
                    this.maxStam = 2;
                    break;
                default:
                    break;
            }
            this.curMana = this.maxMana;
            this.curStam = this.maxStam;
        }
    }
    enum EnemyType {
        Goblin,
        Skeleton
    }
}

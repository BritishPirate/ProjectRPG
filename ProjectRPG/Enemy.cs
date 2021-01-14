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
                    this.speed = 2;
                    break;
                case EnemyType.Skeleton:
                    this.name = "Skeleton";
                    this.hp = 3;
                    this.speed = 3;
                    break;
                default:
                    break;
            }
        }
    }
    enum EnemyType {
        Goblin,
        Skeleton
    }
}

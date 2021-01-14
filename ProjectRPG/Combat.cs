using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Combat {
        private Grid enemyGrid = new Grid(3, 3);
        private Grid allyGrid = new Grid(3, 3);
        public Combat() {
            enemyGrid.grid[0][1] = new Enemy(EnemyType.Goblin);
            allyGrid.grid[1][1] = new PC(pcs.Fighter);
        }

        public void mainCycle() {
            int turncounter = 1;
            while(isEnemyAlive()) {
                Printer.info(allyGrid, enemyGrid);
                new PCTurn(1, 1, this);
                updateGrids();
                if(!isEnemyAlive()) { break; }
                new EnemyTurn(0, 1, this);
                turncounter++;
            }
            Printer.victory();
        }

        private void updateGrids() {
            for(int i = 0; i < enemyGrid.grid.Length; i++) {
                for(int i1 = 0; i1 < enemyGrid.grid[i].Length;i1++) {
                    if(enemyGrid.grid[i][i1] != null && enemyGrid.grid[i][i1].isDead()) { enemyGrid.grid[i][i1] = null; }
                }
            }

            for(int i = 0;i < allyGrid.grid.Length;i++) {
                for(int i1 = 0;i1 < allyGrid.grid[i].Length;i1++) {
                    if(allyGrid.grid[i][i1] != null && allyGrid.grid[i][i1].isDead()) { allyGrid.grid[i][i1] = null; }
                }
            }
        }

        private bool isEnemyAlive() {
            foreach(Creature[] cl in enemyGrid.grid) {
                foreach(Creature c in cl) {
                    if(c != null) { return true; }
                }
            }
            return false;
        }
        public void dealDamage(bool target, int x, int y, int damage) {
            if(target) { enemyGrid.grid[x][y].hp -= damage; }
            else { allyGrid.grid[x][y].hp -= damage; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Combat {
        private Grid enemyGrid = new Grid(3, 3);
        private Grid allyGrid = new Grid(3, 3);
        private List<(int x, int y, int speed, bool enemy)> turnOrder = new List<(int x, int y, int speed, bool enemy)>();
        public Combat() {
            enemyGrid.grid[0][0] = new Enemy(EnemyType.Skeleton);
            enemyGrid.grid[0][1] = new Enemy(EnemyType.Goblin);
            enemyGrid.grid[0][2] = new Enemy(EnemyType.Skeleton);
            allyGrid.grid[1][1] = new PC(pcs.Fighter);
        }

        public void mainCycle() {
            int roundcounter = 1;
            setUpTurnOrder();
            while(isEnemyAlive()) {
                Printer.info(allyGrid, enemyGrid);
                foreach((int x, int y, int speed, bool enemy) c in turnOrder) {
                    if(c.enemy) { new EnemyTurn(c.x, c.y, this); }
                    else { new PCTurn(c.x, c.y, this); }
                    updateGrids();
                    if(!isEnemyAlive()) { break; }
                }
                roundcounter++;
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

        #region Turn Order Setup
        private void setUpTurnOrder() {
            for(int x = 0; x < enemyGrid.grid.Length;x++) {
                for(int y = 0;y < enemyGrid.grid.Length;y++) {
                    if(enemyGrid.grid[x][y] != null) { turnOrder.Add((x, y, enemyGrid.grid[x][y].speed, true)); }
                }
            }
            for(int x = 0;x < allyGrid.grid.Length;x++) {
                for(int y = 0;y < allyGrid.grid.Length;y++) {
                    if(allyGrid.grid[x][y] != null) { turnOrder.Add((x, y, allyGrid.grid[x][y].speed, false)); }
                }
            }
            turnOrder = sortTurnOrder(turnOrder);
        }

        private static List<(int x, int y, int speed, bool enemy)> sortTurnOrder(List<(int x, int y, int speed, bool enemy)> list) {
            int mid = (list.Count / 2);
            List<(int x, int y, int speed, bool enemy)> temp1 = new List<(int x, int y, int speed, bool enemy)>();
            List<(int x, int y, int speed, bool enemy)> temp2 = new List<(int x, int y, int speed, bool enemy)>();
            if(list.Count == 1){ return list; }
            if(list.Count == 2) {
                if(list[0].speed < list[1].speed) {
                    return new List<(int x, int y, int speed, bool enemy)>() { list[1], list[0] };
                }
                return new List<(int x, int y, int speed, bool enemy)>() { list[0], list[1] };
            }
            for(int i = 0; i < list.Count;i++) {
                if(list[i].speed < list[mid].speed) { temp1.Add(list[i]); }
                else { temp2.Add(list[i]); }
            }
            List<(int x, int y, int speed, bool enemy)> temp3 = new List<(int x, int y, int speed, bool enemy)>();
            return sortTurnOrder(temp2).Join(sortTurnOrder(temp1));
        }
        #endregion
    }
}
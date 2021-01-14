using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Grid {
        public Creature[][] grid { get; set; } // grid[x][y]
        public Creature[] getGridLine(Line l, int i) {
            switch(l) {
                case Line.Collumn:
                    return grid[i];
                case Line.Row:
                    #region Row
                    Creature[] temp = new Creature[grid.Length];
                    int i1 = 0;
                    foreach(Creature[] creature in grid) {
                        temp[i] = grid[i1][i];
                        i1++;
                    }
                    return temp;
                    #endregion
                default:
                    return null;
            }
        }
        public Grid(int x, int y) {
            grid = new Creature[x][];
            for(int i=0; i < x;i++) {
                grid[i] = new Creature[y];
                for(int i1 = 0; i1 < y; i1++) {
                    grid[i][i1] = null;
                }
            }
        }
    }

    enum Line {
        Row,
        Collumn,
        Diagonal
    }
}

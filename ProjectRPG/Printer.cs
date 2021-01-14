using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Printer {
        public static void info(Grid allyGrid, Grid enemyGrid) {
            Console.WriteLine();
            Console.WriteLine("Player HP: " + allyGrid.grid[1][1].hp);
            Console.WriteLine("allies");
            printGrid(allyGrid);
            Console.WriteLine("enemies");
            printGrid(enemyGrid);
        }

        public static void printGrid(Grid grid) {
            foreach(Creature[] row in grid.grid) {
                Console.WriteLine();
                foreach(Creature c in row) {
                    if(c == null) { Console.Write("Empty | "); }
                    else { Console.Write(c.name + " | "); }
                }
            }
            Console.WriteLine();
        }

        public static void victory() { Console.WriteLine("Congradulations! You win!"); }

        public static void playerTurn() { Console.WriteLine("Your turn, what do you want to do?"); }

        public static void enemyAttack() { Console.WriteLine("The enemy attacked you!"); }
    }
}

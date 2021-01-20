using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    class Printer {
        public static void info(Grid allyGrid, Grid enemyGrid) {
            Console.WriteLine();
            Console.WriteLine("Player HP: " + allyGrid.grid[1][1].curHP);
            Console.WriteLine("allies");
            printGrid(allyGrid);
            Console.WriteLine("enemies");
            printGrid(enemyGrid);
        }

        public static void printGrid(Grid grid) {
            int x;
            int y = grid.grid.Length;
            for(y = grid.grid.Length - 1;y >= 0;y--) {
                Console.WriteLine();
                for(x = 0; x < grid.grid.Length; x++) {
                    if(grid.grid[x][y] == null) { Console.Write("Empty | "); }
                    else { Console.Write(grid.grid[x][y].name + " | "); }
                }
            }
            Console.WriteLine();
        }

        public static void victory() { Console.WriteLine("Congradulations! You win!"); }

        public static void playerTurn() { Console.WriteLine("Your turn, what do you want to do?"); }

        public static void PCAttack() { Console.WriteLine("You have attacked the enemy!"); }

        public static void enemyAttack() { Console.WriteLine("The enemy attacked you!"); }

        public static void attackMenu() {
            Console.WriteLine("Available Attacks: ");
            Console.WriteLine();
            Console.Write("Basic Attack, ");
            Console.Write("Heavy Attack, ");
        }
    }
}

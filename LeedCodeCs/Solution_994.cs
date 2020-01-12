using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_994
    {
        public int OrangesRotting(int[][] grid)
        {
            int[][] directions = new int[][]{
            new int[] {1, 0},
            new int[] {0, 1},
            new int[] {-1, 0},
            new int[] {0, -1}
        };
            int total = 0;
            Queue<(int, int)> queue = new Queue<(int, int)>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] != 0)
                    {
                        total += 1;
                    }

                    if (grid[i][j] == 2)
                    {
                        queue.Enqueue((i, j));
                    }
                }
            }

            int minutes = 0;
            while (queue.Count > 0)
            {
                int count = queue.Count;
                total -= count;
                for (int i = 0; i < count; i++)
                {
                    (int x, int y) = queue.Dequeue();
                    for (int j = 0; j < 4; j++)
                    {
                        int newX = x + directions[j][0];
                        int newY = y + directions[j][1];

                        if (newX >= 0 && newY >= 0 && newX < grid.Length && newY < grid[0].Length && grid[newX][newY] == 1)
                        {
                            grid[newX][newY] = 2;
                            queue.Enqueue((newX, newY));
                        }
                    }
                }

                minutes++;
            }

            return total == 0 ? minutes == 0 ? 0 : minutes - 1 : -1;
        }
    }
}

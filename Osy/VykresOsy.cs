using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osy
{
    public class VykresOsy
    {
        public void Run()
        {
            const int rows = 29;
            const int columns = 119;

            char[,] screen = new char[columns, rows];

            for (int i = 0; i < columns; i++)
                for (int j = 0; j < rows; j++)
                    screen[i, j] = ' ';

            for(int i = 0; i < columns;i++)
            {
                screen[i,rows/2] = '-';
            }
           for (int i = 0; i < rows;i++)
            {
                screen[columns/2,i] = '|';
            }
            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < columns; i++)
                    Console.Write(screen[i, j]);
                Console.WriteLine();
            }
            //for cyklus ktery je mensi columns a dve int; 0 je na obrazovce: rows/2!
            //screen[x,y] = *
            for(int i = 0; i < columns; i++)
            {
                //nemela moc casu :(
            }
        }
    }
}

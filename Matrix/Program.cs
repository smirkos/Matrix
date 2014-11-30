using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.BufferHeight = 50;
            matrix m = new matrix();
            m.matrix1();
            Console.ReadLine();
        }
    }

    public class matrix
    {
        char h;
        const int lunghezza = 50;
        const int max = 75;
        int col, cont = 0;
        Random m = new Random();
        Random n = new Random();
        Random c = new Random();

        public void matrix1()
        {            
            while(true)
            {
                while (cont >= 0 && cont < max)
                {
                    col = c.Next(80); //Genera una colonna casuale
                    for (int i = 0; i < lunghezza; i++)
                    {
                        Console.SetCursorPosition(col, i);
                        h = (char)n.Next(33, 254);
                        Console.WriteLine(h);
                        while (h > 50)
                        {
                            h = (char)n.Next(33, 254);
                            Console.WriteLine(h);
                        }
                        Thread.Sleep(15);
                    }                    
                    cont++;
                }

                //Cancella riga
                while (cont >= max)
                {
                    for (int i = 0; i < lunghezza; i++)
                    {
                        Console.SetCursorPosition(col, i);
                        Console.WriteLine(" ");
                    }
                    cont--;
                }                
            }
        }
    }
}

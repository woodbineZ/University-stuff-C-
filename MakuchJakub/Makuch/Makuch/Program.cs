using System;

namespace Makuch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Square s = new Square(rand.Next(1, 10));
            Block block1 = new Block(s, rand.Next(1, 10));
            Circle k = new Circle(rand.Next(1, 10));
            Block block2 = new Block(k, rand.Next(1, 10));
            Rectangle p = new Rectangle(rand.Next(1, 10), rand.Next(1, 10));
            Block block3 = new Block(p, rand.Next(1, 10));
            //Console.WriteLine(block1);
            //Console.ReadLine();
            //Console.WriteLine(block2.GetVolume());
            //Console.ReadLine();
            Console.WriteLine(block3.info(block3.GetVolume(), block3.Height));
            Block[] blocks = new Block[3];
            blocks[0] = block1;
            blocks[1] = block2;
            blocks[2] = block3;
            foreach (var x in blocks)
            {
                Console.WriteLine(x.ToString());
            }
            //Console.WriteLine(block1.ToString());
            Console.ReadLine();
            //block2.ToString();
            //block3.ToString();

        }
    }
}


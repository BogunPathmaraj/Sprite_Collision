using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogunP_300829172_A1
{
    class Sprites
    {

        static void Main(string[] args)
        {
            var name = "S3";
            var diameter = 2;
            var xcoordinate = 3;
            var ycoordinate = 2;




            Sprite s1 = new Sprite("S1", 1);
            Sprite s2 = new Sprite("S2", 1, 1, 1);
            Sprite s3 = new Sprite(name, diameter, xcoordinate, ycoordinate);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            s1.Move(Direction.Right);
            s1.Move(Direction.Right);
            s1.Move(Direction.Up);
            s1.Move(Direction.Left);
            s1.Move(Direction.Up);
            s1.Move(Direction.Left);
            s1.Move(Direction.Up);
            s1.Move(Direction.Right);
            s1.Move(Direction.Up);
            s1.Move(Direction.Right);
            s1.Move(Direction.Right);

            s2.Move(Direction.Left);

            s1.Move(Direction.Down);
            s1.Move(Direction.Down);


        }
    }
}

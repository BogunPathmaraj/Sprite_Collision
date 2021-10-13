using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogunP_300829172_A1
{
    class Sprite
    {
        public readonly double Diameter;

        private static List<Sprite> allSprites = new List<Sprite>();

        public string Name;
        public double XCoordinate { get; private set; }
        public double YCoordinate { get; private set; }

        public Sprite(string name, double diameter, int x = 0, int y = 0)
        {
            Name = name;
            Diameter = diameter;
            XCoordinate = x;
            YCoordinate = y;
            allSprites.Add(this);
        }

        private bool isCollision(Sprite encounter)
        {
            var dia = (this.Diameter + encounter.Diameter) / 2;
            var dist = Math.Sqrt(((this.XCoordinate - encounter.XCoordinate) * (this.XCoordinate - encounter.XCoordinate)) + ((this.YCoordinate - encounter.YCoordinate) * (this.YCoordinate - encounter.YCoordinate)));
            return dist < (dia);

        }

        private bool anyColison()
        {

            bool flag = false;
            foreach (Sprite sprite in allSprites)
            {
                //Making sure we are not comparing current sprite to the sprite in the list as this would be a false collision
                if (this.Name != sprite.Name && this.isCollision(sprite))
                {

                    return true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        public void Move(Direction direction)
        {


            Console.WriteLine($"Moving {Name}:({XCoordinate},{YCoordinate},{Diameter}) {direction}");


            switch (direction)
            {
                case Direction.Up:
                    {
                        YCoordinate++;
                        break;
                    }
                case Direction.Down:
                    {
                        YCoordinate--;

                        break;
                    }
                case Direction.Right:
                    {
                        XCoordinate++;

                        break;
                    }
                case Direction.Left:
                    {
                        XCoordinate--;

                        break;
                    }
            }

            //If collision occurs then have the sprite return to its orignal position
            if (anyColison())
            {

                switch (direction)
                {
                    case Direction.Up:
                        {
                            YCoordinate--;
                            Console.WriteLine($"Move {direction} failed! Collision. Position {Name}:({XCoordinate},{YCoordinate},{Diameter})");
                            break;
                        }
                    case Direction.Down:
                        {
                            YCoordinate++;
                            Console.WriteLine($"Move {direction} failed! Collision. Position {Name}:({XCoordinate},{YCoordinate},{Diameter})");
                            break;
                        }
                    case Direction.Right:
                        {
                            XCoordinate--;
                            Console.WriteLine($"Move {direction} failed! Collision. Position {Name}:({XCoordinate},{YCoordinate},{Diameter})");
                            break;
                        }
                    case Direction.Left:
                        {
                            XCoordinate++;
                            Console.WriteLine($"Move {direction} failed! Collision. Position {Name}:({XCoordinate},{YCoordinate},{Diameter})");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine($"Move {direction} successful. Position {Name}:({XCoordinate},{YCoordinate},{Diameter})");
            }



        }

        public override string ToString()
        {
            return $"{Name}:({XCoordinate},{YCoordinate},{Diameter})";
        }
    }
}

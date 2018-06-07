using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            var norther = new Rover(Direction.North, "Norther");
            norther.Move("FFFBLFFRRBFF");
            Console.WriteLine(norther);
            Console.ReadLine();

        }

        public class Rover
        {
            private int _x;
            private int _y;

            public Direction Direction { get; set; }

            public string Name { get; set; }

            public Rover(Direction direction, String name)
            {
                Direction = direction;
                Name = name;
            }

            public void Move(string directions)
            {
                foreach (var direction in directions )
                {
                    switch (direction)
                    {
                        case 'F':
                            MoveForward();
                            break;
                        case 'B':
                            MoveBack();
                            break;
                        case 'L':
                            TurnLeft();
                            break;
                        case 'R':
                            TurnRight();
                            break;
                    }
                }
            }

            private void MoveForward()
            {
                switch (Direction)
                {
                    case Direction.North:
                        _y++;
                        break;
                    case Direction.South:
                        _y--;
                        break;
                    case Direction.East:
                        _x++;
                        break;
                    case Direction.West:
                        _x--;
                        break;
                }
            }
            private void MoveBack()
            {
                switch (Direction)
                {
                    case Direction.North:
                        _y--;
                        break;
                    case Direction.South:
                        _y++;
                        break;
                    case Direction.East:
                        _x--;
                        break;
                    case Direction.West:
                        _x++;
                        break;
                }
            }

            private void TurnLeft()
            {
                switch (Direction)
                {
                    case Direction.North:
                        Direction = Direction.West;
                        break;
                    case Direction.South:
                        Direction = Direction.East;
                        break;
                    case Direction.East:
                        Direction = Direction.North;
                        break;
                    case Direction.West:
                        Direction = Direction.South;
                        break;
                }
            }
            private void TurnRight()
            {
                switch (Direction)
                {
                    case Direction.North:
                        Direction = Direction.East;
                        break;
                    case Direction.South:
                        Direction = Direction.West;
                        break;
                    case Direction.East:
                        Direction = Direction.South;
                        break;
                    case Direction.West:
                        Direction = Direction.North;
                        break;
                }
            }

            public override string ToString()
            {
                return $"X:{_x}, Y:{_y}, {Direction}";


            }
        }

        public enum Direction
        {
            North = 1,
            South = 2, 
            East = 3, 
            West = 4
        }
    }
}

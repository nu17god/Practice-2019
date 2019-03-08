using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class MovableObject: Object
    {
        public Direction Dir;
        public int Speed;

        public MovableObject(int x, int y, int speed, int height, int width, Direction direction) : base (x, y, width, height)
        {
            Dir = direction;
            Speed = speed;
        }
    }
}

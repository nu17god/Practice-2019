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

        public MovableObject( Position position, Direction direction, int size) :  base (position,size) 
        {
            Dir = direction;
        }
    }
}

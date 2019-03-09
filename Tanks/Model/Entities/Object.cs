using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Object
    {
        public int size = 64;
        public Position position = new Position(0,0);


        public Object(Position position, int size)
        {
            this.position = position;
            this.size = size;
        }
    }
}

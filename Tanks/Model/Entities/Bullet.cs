using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model.Entities
{
    public class Bullet : MovableObject
    {
        ObjectView objectView;

        public Bullet(Position position, Direction direction, int size) : base (position, direction, size)
        {
            objectView = new ObjectView(size, new Position(0, 68), 3);
        }

        public void Draw(Graphics graphics)
        {
            objectView.Draw(graphics, position.X, position.Y);
        }
    }
}

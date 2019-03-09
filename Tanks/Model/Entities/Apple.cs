using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model.Entities
{
    public class Apple : Object
    {
        ObjectView objectView;

        public Apple(Position position, int size) : base (position, size)
        {
            objectView = new ObjectView("Apple.png", size);
        }

        public void Draw(Graphics graphics)
        {
            objectView.Draw(graphics, position.X, position.Y);
        }
    }
}

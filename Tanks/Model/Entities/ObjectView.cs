using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Model.Entities
{
    public class ObjectView
    {
        int size;
        int realSize;
        Image image;
        public Position position;

        public ObjectView(int size, Position position)
        {
            this.realSize = 16;
            this.position = position;
            this.size = size;
            this.image = Image.FromFile("..//..//..//Model//Images//Sprite.png");
        }

        public ObjectView(int size, Position position, int realSize)
        {
            this.realSize = realSize;
            this.position = position;
            this.size = size;
            this.image = Image.FromFile("..//..//..//Model//Images//Sprite.png");
        }

        public void Draw(Graphics graphics, int x, int y)
        {
            graphics.DrawImage(image, new Rectangle(x, y, size, size), new Rectangle(position.X, position.Y, realSize, realSize), GraphicsUnit.Pixel);
        }
    }
}

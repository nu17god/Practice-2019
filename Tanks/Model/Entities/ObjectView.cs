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
        int size = 64;
        Image image;
        string src;

        public ObjectView(string src, int size)
        {
            this.size = size;
            this.image = Image.FromFile("..//..//Images//" + src);
            this.src = src;
        }

        public void Draw(Graphics graphics, int x, int y)
        {
            graphics.DrawImage(image, new Rectangle(x, y, size, size));
        }
    }
}

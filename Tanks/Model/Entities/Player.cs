using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model.Entities
{
    public class Player : MovableObject
    {
        ObjectView objectView;

        public Player(Position position, Direction direction, int size) : base(position, direction, size)
        {
            ChangeDirection(direction, position);
        }

        public void ChangeDirection(Direction direction, Position position)
        {
            this.Dir = direction;
            switch (direction)
            {
                case Direction.LEFT:
                    objectView = new ObjectView("Player_left.png", size);
                    break;
                case Direction.RIGHT:
                    objectView = new ObjectView("Player_right.png", size);
                    break;
                case Direction.UP:
                    objectView = new ObjectView("Player_up.png", size);
                    break;
                case Direction.DOWN:
                    objectView = new ObjectView("Player_down.png", size);
                    break;
            }
        }

        public void Draw(Graphics graphics)
        {
            objectView.Draw(graphics, position.X, position.Y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model.Entities
{
    public class Enemy : MovableObject
    {
        ObjectView objectView;

        public int cooldown;

        public Enemy(Position position, Direction direction, int size) : base (position, direction, size)
        {
            ChangeDirection(direction);
            cooldown = 32;
        }

        public void ChangeDirection(Direction direction)
        {
            this.Dir = direction;
            switch (direction)
            {
                case Direction.LEFT:
                    objectView = new ObjectView("Enemy_left.png", size);
                    break;
                case Direction.RIGHT:
                    objectView = new ObjectView("Enemy_right.png", size);
                    break;
                case Direction.UP:
                    objectView = new ObjectView("Enemy_up.png", size);
                    break;
                case Direction.DOWN:
                    objectView = new ObjectView("Enemy_down.png", size);
                    break;
            }
        }

        public void ReverseDirection()
        {

            switch (this.Dir)
            {
                case Direction.LEFT:
                    objectView = new ObjectView("Enemy_right.png", size);
                    this.Dir = Direction.RIGHT;
                    break;
                case Direction.RIGHT:
                    objectView = new ObjectView("Enemy_left.png", size);
                    this.Dir = Direction.LEFT;
                    break;
                case Direction.UP:
                    objectView = new ObjectView("Enemy_down.png", size);
                    this.Dir = Direction.DOWN;
                    break;
                case Direction.DOWN:
                    objectView = new ObjectView("Enemy_up.png", size);
                    this.Dir = Direction.UP;
                    break;
            }
        }

        public void Draw(Graphics graphics)
        {
            objectView.Draw(graphics, position.X, position.Y);
        }

        public bool Shoot()
        {
            if(cooldown >= 32)
            {
                cooldown = 0;
                return true;
            }
            return false;
        }
    }
}

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
        ObjectView objectViewLeft;
        ObjectView objectViewRight;
        ObjectView objectViewUp;
        ObjectView objectViewDown;

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
                    if (objectViewLeft == null)
                    {
                        objectViewLeft = new ObjectView(size, new Position(16, 17));
                    }

                    objectView = objectViewLeft;
                    break;
                case Direction.RIGHT:
                    if (objectViewRight == null)
                    {
                        objectViewRight = new ObjectView(size, new Position(32, 17));
                    }

                    objectView = objectViewRight;
                    break;
                case Direction.UP:
                    if (objectViewUp == null)
                    {
                        objectViewUp = new ObjectView(size, new Position(48, 17));
                    }

                    objectView = objectViewUp;
                    break;
                case Direction.DOWN:
                    if (objectViewDown == null)
                    {
                        objectViewDown = new ObjectView(size, new Position(0, 17));
                    }

                    objectView = objectViewDown;
                    break;
            }
        }

        public void ReverseDirection()
        {

            switch (this.Dir)
            {
                case Direction.LEFT:
                    if (objectViewRight == null)
                    {
                        objectViewRight = new ObjectView(size, new Position(32, 17));
                    }

                    objectView = objectViewRight;
                    this.Dir = Direction.RIGHT;
                    break;
                case Direction.RIGHT:
                    if (objectViewLeft == null)
                    {
                        objectViewLeft = new ObjectView(size, new Position(16, 17));
                    }

                    objectView = objectViewLeft;
                    this.Dir = Direction.LEFT;
                    break;
                case Direction.UP:
                    if (objectViewDown == null)
                    {
                        objectViewDown = new ObjectView(size, new Position(0, 17));
                    }

                    objectView = objectViewDown;
                    this.Dir = Direction.DOWN;
                    break;
                case Direction.DOWN:
                    if (objectViewUp == null)
                    {
                        objectViewUp = new ObjectView(size, new Position(48, 17));
                    }

                    objectView = objectViewUp;
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

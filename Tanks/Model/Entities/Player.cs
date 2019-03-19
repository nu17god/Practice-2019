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
        ObjectView objectViewLeft;
        ObjectView objectViewRight;
        ObjectView objectViewUp;
        ObjectView objectViewDown;

        public int Cooldown = 16;

        public Player(Position position, Direction direction, int size) : base(position, direction, size)
        {
            ChangeDirection(direction);
        }

        public void ChangeDirection(Direction direction)
        {
            this.Dir = direction;
            switch (direction)
            {
                case Direction.LEFT:
                    if (objectViewLeft == null)
                    {
                        objectViewLeft = new ObjectView(size, new Position(16, 0));     
                    }

                    objectView = objectViewLeft;
                    break;
                case Direction.RIGHT:
                    if (objectViewRight == null)
                    {
                        objectViewRight = new ObjectView(size, new Position(32, 0));
                    }

                    objectView = objectViewRight;
                    break;
                case Direction.UP:
                    if (objectViewUp == null)
                    {
                        objectViewUp = new ObjectView(size, new Position(48, 0));
                    }

                    objectView = objectViewUp;
                    break;
                case Direction.DOWN:
                    if (objectViewDown == null)
                    {
                        objectViewDown = new ObjectView(size, new Position(0, 0));
                    }

                    objectView = objectViewDown;
                    break;
            }
        }

        public void Draw(Graphics graphics)
        {
            objectView.Draw(graphics, position.X, position.Y);
        }

        public bool Shoot()
        {
            if(Cooldown > 16)
            {
                Cooldown = 0;
                return true;
            }

            return false;
        }

        public void ReverseDirection()
        {

            switch (this.Dir)
            {
                case Direction.LEFT:
                    if (objectViewRight == null)
                    {
                        objectViewRight = new ObjectView(size, new Position(32, 0));
                    }

                    objectView = objectViewRight;
                    this.Dir = Direction.RIGHT;
                    break;
                case Direction.RIGHT:
                    if (objectViewLeft == null)
                    {
                        objectViewLeft = new ObjectView(size, new Position(16, 0));
                    }

                    objectView = objectViewLeft;
                    this.Dir = Direction.LEFT;
                    break;
                case Direction.UP:
                    if (objectViewDown == null)
                    {
                        objectViewDown = new ObjectView(size, new Position(0, 0));
                    }

                    objectView = objectViewDown;
                    this.Dir = Direction.DOWN;
                    break;
                case Direction.DOWN:
                    if (objectViewUp == null)
                    {
                        objectViewUp = new ObjectView(size, new Position(48, 0));
                    }

                    objectView = objectViewUp;
                    this.Dir = Direction.UP;
                    break;
            }
        }
    }
}

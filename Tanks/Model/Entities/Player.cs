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
                    objectView = new ObjectView(size, new Position(16, 0));
                    break;
                case Direction.RIGHT:
                    objectView = new ObjectView(size, new Position(32, 0));
                    break;
                case Direction.UP:
                    objectView = new ObjectView(size, new Position(48, 0));
                    break;
                case Direction.DOWN:
                    objectView = new ObjectView(size, new Position(0, 0));
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
                    objectView = new ObjectView(size, new Position(32, 0));
                    this.Dir = Direction.RIGHT;
                    break;
                case Direction.RIGHT:
                    objectView = new ObjectView(size, new Position(16, 0));
                    this.Dir = Direction.LEFT;
                    break;
                case Direction.UP:
                    objectView = new ObjectView(size, new Position(0, 0));
                    this.Dir = Direction.DOWN;
                    break;
                case Direction.DOWN:
                    objectView = new ObjectView(size, new Position(48, 0));
                    this.Dir = Direction.UP;
                    break;
            }
        }
    }
}

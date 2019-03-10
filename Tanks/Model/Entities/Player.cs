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
            ChangeDirection(direction);
        }

        public void ChangeDirection(Direction direction)
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

        public EntitiesList Shoot(EntitiesList entities)
        {
            entities.playerBullet.Add(new Bullet(new Position(position.X + ((size / 2) - (size / 8)), position.Y + ((size / 2) - (size / 8))), Dir, size / 4));
            return entities;
        }
    }
}

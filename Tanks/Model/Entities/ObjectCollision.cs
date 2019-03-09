using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class ObjectCollision
    {
        public void CheckCollision(EntitiesList entities, int MapSize, int Speed)
        {
            foreach (var wall in entities.walls)
            {
                if (BoxCollides(wall.position, MapSize, entities.player.position))
                {
                    switch (entities.player.Dir)
                    {
                        case Direction.LEFT:
                            entities.player.position.X += Speed;
                            break;
                        case Direction.RIGHT:
                            entities.player.position.X -= Speed;
                            break;
                        case Direction.UP:
                            entities.player.position.Y += Speed;
                            break;
                        case Direction.DOWN:
                            entities.player.position.Y -= Speed;
                            break;
                    }
                }
            }

            foreach (var apple in entities.apples)
            {
                if (BoxCollides(apple.position, apple.size, entities.player.position))
                {
                    entities.apples.Remove(apple);
                    break;
                }
            }
        }

        public bool BoxCollides(Position pos1, int size, Position pos2)
        {
            return Collides(pos1.X, pos1.Y,
                            pos1.X + size, pos1.Y + size,
                            pos2.X, pos2.Y,
                            pos2.X + size, pos2.Y + size);
        }

        private bool Collides(double x1, double y1, double dx1, double dy1, double x2, double y2, double dx2, double dy2)
        {
            return !(dx1 <= x2 || x1 > dx2 ||
                     dy1 <= y2 || y1 > dy2);
        }
    }
}

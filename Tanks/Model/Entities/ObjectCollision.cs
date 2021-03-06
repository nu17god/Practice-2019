﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class ObjectCollision
    {
        public bool CheckCollision(EntitiesList entities, int ObjectSize, ref int Score)
        {
            if(entities.player.position.X > 640 - entities.player.size)
            {
                entities.player.position.X = 640 - entities.player.size;
                entities.player.ReverseDirection();
            }

            if (entities.player.position.X < 0)
            {
                entities.player.position.X = 0;
                entities.player.ReverseDirection();
            }

            if (entities.player.position.Y > 640 - entities.player.size)
            {
                entities.player.position.Y = 640 - entities.player.size;
                entities.player.ReverseDirection();
            }

            if (entities.player.position.Y < 0)
            {
                entities.player.position.Y = 0;
                entities.player.ReverseDirection();
            }

            for(int i = 0; i < entities.enemies.Count; i++)
            {
                if (entities.enemies[i].position.X > 640 - entities.enemies[i].size)
                {
                    entities.enemies[i].position.X = 640 - entities.enemies[i].size;
                    entities.enemies[i].ReverseDirection();
                }

                if (entities.enemies[i].position.X < 0)
                {
                    entities.enemies[i].position.X = 0;
                    entities.enemies[i].ReverseDirection();
                }

                if (entities.enemies[i].position.Y > 640 - entities.enemies[i].size)
                {
                    entities.enemies[i].position.Y = 640 - entities.enemies[i].size;
                    entities.enemies[i].ReverseDirection();
                }

                if (entities.enemies[i].position.Y < 0)
                {
                    entities.enemies[i].position.Y = 0;
                    entities.enemies[i].ReverseDirection();
                }
            }


            foreach (var wall in entities.walls)
            {
                if (BoxCollides(wall.position, ObjectSize, entities.player.position))
                {
                    switch (entities.player.Dir)
                    {
                        case Direction.LEFT:
                            entities.player.position.X += 2;
                            entities.player.ReverseDirection();
                            break;
                        case Direction.RIGHT:
                            entities.player.position.X -= 2;
                            entities.player.ReverseDirection();
                            break;
                        case Direction.UP:
                            entities.player.position.Y += 2;
                            entities.player.ReverseDirection();
                            break;
                        case Direction.DOWN:
                            entities.player.position.Y -= 2;
                            entities.player.ReverseDirection();
                            break;
                    }

                }

            }

            for (int i = 0; i < entities.enemies.Count; i++)
            {
                foreach (var wall in entities.walls)
                {
                    if (BoxCollides(wall.position, ObjectSize, entities.enemies[i].position))
                    {
                        entities = BackEnemy(entities, i);
                        entities.enemies[i].ReverseDirection();
                    }

                }
            }

            for (int i = 0; i < entities.enemies.Count - 1; i++)
            {
                for (int j = i + 1; j < entities.enemies.Count; j++)
                {
                    if (BoxCollides(entities.enemies[i].position, entities.enemies[i].size, entities.enemies[j].position))
                    {
                        entities = unMove(i, j, entities);
                    }
                }
            }

            Random random = new Random();


            foreach (Wall wall in entities.walls)
            {

                foreach (var bullet in entities.bullets)
                {
                    if (BoxCollides(wall.position, wall.size, bullet.position, bullet.size))
                    {
                        entities.bullets.Remove(bullet);
                        break;
                    }
                }

                foreach (var bullet in entities.playerBullet)
                {
                    if (BoxCollides(wall.position, wall.size, bullet.position, bullet.size))
                    {
                        entities.playerBullet.Remove(bullet);
                        break;
                    }
                }
            }


            foreach (var apple in entities.apples)
            {
                if (BoxCollides(apple.position, apple.size, entities.player.position))
                {
                    Score++;
                    entities.apples.Remove(apple);
                    break;
                }
            }

            for (int i = 0; i < entities.enemies.Count; i++)
            {
                if (random.Next(300) > 295)
                {
                    entities.enemies[i].ChangeDirection(RandomDirection());
                }
            }

            foreach (var enemy in entities.enemies)
            {
                if (BoxCollides(enemy.position, enemy.size, entities.player.position))
                {
                    return true;
                }
            }

            for (int i = 0; i < entities.enemies.Count; i++)
            {
                switch (entities.enemies[i].Dir)
                {
                    case Direction.LEFT:
                        {
                            if ((Collides(0,
                                          entities.enemies[i].position.Y,
                                          entities.enemies[i].position.X,
                                          entities.enemies[i].position.Y + entities.enemies[i].size,
                                          entities.player.position.X,
                                          entities.player.position.Y,
                                          entities.player.position.X + entities.player.size,
                                          entities.player.position.Y + entities.player.size)))
                            {
                                if (entities.enemies[i].Shoot())
                                {
                                    entities.bullets.Add(CreateBullet(entities.enemies[i]));
                                }
                            }
                            break;
                        }
                    case Direction.RIGHT:
                        {
                            if ((Collides(entities.enemies[i].position.X + entities.enemies[i].size,
                                          entities.enemies[i].position.Y,
                                          entities.enemies[i].position.X + 640,
                                          entities.enemies[i].position.Y + entities.enemies[i].size,
                                          entities.player.position.X,
                                          entities.player.position.Y,
                                          entities.player.position.X + entities.player.size,
                                          entities.player.position.Y + entities.player.size)))
                            {
                                if (entities.enemies[i].Shoot())
                                {
                                    entities.bullets.Add(CreateBullet(entities.enemies[i]));
                                }
                            }
                            break;
                        }
                    case Direction.UP:
                        {
                            if ((Collides(entities.enemies[i].position.X,
                                          0,
                                          entities.enemies[i].position.X + entities.enemies[i].size,
                                          entities.enemies[i].position.Y,
                                          entities.player.position.X,
                                          entities.player.position.Y,
                                          entities.player.position.X + entities.player.size,
                                          entities.player.position.Y + entities.player.size)))
                            {
                                if (entities.enemies[i].Shoot())
                                {
                                    entities.bullets.Add(CreateBullet(entities.enemies[i]));
                                }
                            }
                            break;
                        }
                    case Direction.DOWN:
                        {
                            if ((Collides(entities.enemies[i].position.X + entities.enemies[i].size,
                                          entities.enemies[i].position.Y,
                                          entities.enemies[i].position.X + entities.enemies[i].size,
                                          entities.enemies[i].position.Y + 640,
                                          entities.player.position.X,
                                          entities.player.position.Y,
                                          entities.player.position.X + entities.player.size,
                                          entities.player.position.Y + entities.player.size)))
                            {
                                if (entities.enemies[i].Shoot())
                                {
                                    entities.bullets.Add(CreateBullet(entities.enemies[i]));
                                }
                            }
                            break;
                        }
                }
            }

            bool hit = false;

            foreach (var bullet in entities.playerBullet)
            {
                foreach (var enemy in entities.enemies)
                {
                    if (BoxCollides(enemy.position, enemy.size, bullet.position, bullet.size))
                    {
                        entities.enemies.Remove(enemy);
                        entities.playerBullet.Remove(bullet);
                        hit = true;
                        break;
                    }
                }

                if (hit)
                {
                    break;
                }
            }

            for (int i = 0; i < entities.bullets.Count; i++)
            {
                if (BoxCollides(entities.player.position, entities.player.size, entities.bullets[i].position, entities.bullets[i].size))
                {
                    return true;
                }
            }

            return false;
        }

        public bool BoxCollides(Position pos1, int size1, Position pos2, int size2)
        {
            return Collides(pos1.X, pos1.Y,
                            pos1.X + size1, pos1.Y + size1,
                            pos2.X, pos2.Y,
                            pos2.X + size2, pos2.Y + size2);
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

        private Direction RandomDirection()
        {
            Random rnd = new Random();
            int direct = rnd.Next(4);

            switch (direct)
            {
                case 1:
                    {
                        return Direction.UP;
                    }
                case 2:
                    {
                        return Direction.DOWN;
                    }
                case 3:
                    {
                        return Direction.LEFT;
                    }
                default:
                    {
                        return Direction.RIGHT;
                    }
            }
        }

        private EntitiesList unMove(int i, int j, EntitiesList entities)
        {

            entities = BackEnemy(entities, i);
            entities = BackEnemy(entities, j);

            Position tmpPos = new Position(entities.enemies[i].position.X, entities.enemies[i].position.Y);
            entities.enemies[i].position = new Position(entities.enemies[j].position.X, entities.enemies[j].position.Y);
            entities.enemies[j].position = new Position(tmpPos.X, tmpPos.Y);

            return entities;
        }

        private Bullet CreateBullet(Enemy enemy)
        {
            return new Bullet(new Position(enemy.position.X + ((enemy.size / 2) - (enemy.size / 8)), enemy.position.Y + ((enemy.size / 2) - (enemy.size / 8))), enemy.Dir, enemy.size / 4);
        }

        private EntitiesList BackEnemy(EntitiesList entities, int i)
        {
            switch (entities.enemies[i].Dir)
            {
                case Direction.LEFT:
                    entities.enemies[i].position.X += 2;
                    break;
                case Direction.RIGHT:
                    entities.enemies[i].position.X -= 2;
                    break;
                case Direction.UP:
                    entities.enemies[i].position.Y += 2;
                    break;
                case Direction.DOWN:
                    entities.enemies[i].position.Y -= 2;
                    break;
            }
            return entities;
        }
    }
}

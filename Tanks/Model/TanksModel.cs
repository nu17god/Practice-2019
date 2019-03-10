using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Entities;

namespace Model
{
    public class TanksModel
    {
        public EntitiesList entities;
        public ObjectCollision collision = new ObjectCollision();
        public InitializeGame initializeGame;

        public int Speed;
        public int MapSize;
        public int AppleCount;
        public int EnemiesCount;

        public TanksModel(EntitiesList entities, int speed, int mapSize)
        {
            MapSize = mapSize;
            Speed = speed;
            this.entities = entities;
        }

        public void NewGame(int MapSize, int Speed, int AppleCount, int EnemiesCount)
        {
            this.Speed = Speed;
            this.MapSize = MapSize;
            this.AppleCount = AppleCount;
            this.EnemiesCount = EnemiesCount;
            
            entities.apples = new List<Apple>();
            entities.walls = new List<Wall>();
            entities.enemies = new List<Enemy>();
            entities.bullets = new List<Bullet>();
            entities.playerBullet = new List<Bullet>();

            initializeGame = new InitializeGame(entities);

            initializeGame.Initialize(MapSize, AppleCount, EnemiesCount);
        }

        public bool Update(ref int Score)
        {
            if(entities.apples.Count < AppleCount)
            {
                initializeGame.InitializeApples(AppleCount);
            }

            if (entities.enemies.Count < EnemiesCount)
            {
                initializeGame.InitializeEnemies(EnemiesCount);
            }

            Move();

            return collision.CheckCollision(entities, MapSize, Speed, ref Score);
        }
         
        public void Move()
        {
            switch (entities.player.Dir)
            {
                case Direction.LEFT:
                    entities.player.position.X -= Speed;
                    break;

                case Direction.RIGHT:
                    entities.player.position.X += Speed;
                    break;

                case Direction.UP:
                    entities.player.position.Y -= Speed;
                    break;

                case Direction.DOWN:
                    entities.player.position.Y += Speed;
                    break;
            }

            for(int i = 0; i < entities.enemies.Count; i++)
            {
                switch (entities.enemies[i].Dir)
                {
                    case Direction.LEFT:
                        entities.enemies[i].position.X -= Speed;
                        break;

                    case Direction.RIGHT:
                        entities.enemies[i].position.X += Speed;
                        break;

                    case Direction.UP:
                        entities.enemies[i].position.Y -= Speed;
                        break;

                    case Direction.DOWN:
                        entities.enemies[i].position.Y += Speed;
                        break;
                }
            }

            for (int i = 0; i < entities.bullets.Count; i++)
            {
                switch (entities.bullets[i].Dir)
                {
                    case Direction.LEFT:
                        entities.bullets[i].position.X -= Speed * 2;
                        break;

                    case Direction.RIGHT:
                        entities.bullets[i].position.X += Speed * 2;
                        break;

                    case Direction.UP:
                        entities.bullets[i].position.Y -= Speed * 2;
                        break;

                    case Direction.DOWN:
                        entities.bullets[i].position.Y += Speed * 2;
                        break;
                }
            }

            for (int i = 0; i < entities.playerBullet.Count; i++)
            {
                switch (entities.playerBullet[i].Dir)
                {
                    case Direction.LEFT:
                        entities.playerBullet[i].position.X -= Speed * 2;
                        break;

                    case Direction.RIGHT:
                        entities.playerBullet[i].position.X += Speed * 2;
                        break;

                    case Direction.UP:
                        entities.playerBullet[i].position.Y -= Speed * 2;
                        break;

                    case Direction.DOWN:
                        entities.playerBullet[i].position.Y += Speed * 2;
                        break;
                }
            }
        }

        public void ChangePlayerDirection(Direction direction)
        {
            entities.player.ChangeDirection(direction);
        }

        public void Shoot()
        {
            entities = entities.player.Shoot(entities);
        }
    }
}

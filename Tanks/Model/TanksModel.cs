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
        public int ObjectSize;
        public int AppleCount;
        public int EnemiesCount;

        public TanksModel(EntitiesList entities, StartInfo startInfo)
        {
            this.Speed = startInfo.Speed;
            this.ObjectSize = startInfo.ObjectsSize;
            this.AppleCount = startInfo.AppleCount;
            this.EnemiesCount = startInfo.EnemyCount;
            this.entities = entities;
        }

        public void NewGame(StartInfo startInfo)
        {
            this.Speed = startInfo.Speed;
            this.ObjectSize = startInfo.ObjectsSize;
            this.AppleCount = startInfo.AppleCount;
            this.EnemiesCount = startInfo.EnemyCount;

            entities.apples = new List<Apple>();
            entities.walls = new List<Wall>();
            entities.enemies = new List<Enemy>();
            entities.bullets = new List<Bullet>();
            entities.playerBullet = new List<Bullet>();

            initializeGame = new InitializeGame(entities);

            initializeGame.Initialize(ObjectSize, AppleCount, EnemiesCount);
        }

        public bool Update(ref int Score)
        {
            if (entities.apples.Count < AppleCount)
            {
                initializeGame.InitializeApples(AppleCount);
            }

            if (entities.enemies.Count < EnemiesCount)
            {
                initializeGame.InitializeEnemies(EnemiesCount);
            }

            foreach (var enemy in entities.enemies)
            {
                enemy.cooldown++;
            }

            entities.player.Cooldown++;

            Move();

            return collision.CheckCollision(entities, ObjectSize, Speed, ref Score);
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

            for (int i = 0; i < entities.enemies.Count; i++)
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

        public void PlayerShoot()
        {
            if (entities.player.Shoot())
            {
                entities.playerBullet.Add(new Bullet(new Position(entities.player.position.X + ((entities.player.size / 2) - (entities.player.size / 8)), entities.player.position.Y + ((entities.player.size / 2) - (entities.player.size / 8))), entities.player.Dir, entities.player.size / 4));
            }
        }
    }
}

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

        public TanksModel(EntitiesList entities, int speed, int mapSize, int AppleCount)
        {
            MapSize = mapSize;
            Speed = speed;
            this.AppleCount = AppleCount;
            this.entities = entities;
        }

        public void NewGame(int MapSize, int Speed, int AppleCount, int EnemiesCount)
        {
            this.Speed = Speed;
            this.AppleCount = AppleCount;
            this.MapSize = MapSize;
            
            entities.apples = new List<Apple>();
            entities.walls = new List<Wall>();

            initializeGame = new InitializeGame(entities);

            initializeGame.Initialize(MapSize, AppleCount);
        }

        public void Update()
        {
            if(entities.apples.Count < AppleCount)
            {
                initializeGame.InitializeApples(AppleCount);
            }

            Move();

            collision.CheckCollision(entities, MapSize, Speed);
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
        }

        public void ChangePlayerDirection(Direction direction)
        {
            entities.player.ChangeDirection(direction, new Position(0,0));
        }

    }
}

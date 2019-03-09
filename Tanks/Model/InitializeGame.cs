﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class InitializeGame
    {
        Random random = new Random();
        ObjectCollision collision = new ObjectCollision();
        EntitiesList entities;
        public int MapSize;

        public InitializeGame(EntitiesList entities)
        {
            this.entities = entities;
        }

        public void Initialize(int MapSize, int AppleCount)
        {
            this.MapSize = MapSize;
            InitializeWalls();
            InitializeApples(AppleCount);
            InitializePlayer();
            //InitializeEnemies();
        }

        public void InitializeApples(int AppleCount)
        {
            Position position = new Position(random.Next(640 - MapSize * 2), (random.Next(640 - MapSize * 2)));

            int count = entities.apples.Count;
            for (int i = count; i < AppleCount; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    if(collision.BoxCollides(position, MapSize, entities.apples[k].position))
                    {
                        i = count - 1;
                        position = new Position(random.Next(640 - MapSize * 2), (random.Next(640 - MapSize * 2)));
                    }
                }

                for (int j = 0; j < entities.walls.Count; j++)
                {
                    if (collision.BoxCollides(position, MapSize, entities.walls[j].position))
                    {
                        i = count - 1;
                        position = new Position(random.Next(640 - MapSize * 2), (random.Next(640 - MapSize * 2)));
                    }
                }

                if (i > count - 1)
                {

                    entities.apples.Add(new Apple(position, MapSize));
                    position = new Position(random.Next(640 - MapSize * 2), (random.Next(640 - MapSize * 2)));
                    count++;
                }
            }
        }



        public void InitializePlayer()
        {
            entities.player = new Player(new Position(MapSize, MapSize), Direction.RIGHT, MapSize);
        }

        public void InitializeWalls()
        {
            for(int i = 0; i <= 640; i+= MapSize)
            {
                entities.walls.Add(new Wall(new Position( i, 0), MapSize));
                entities.walls.Add(new Wall(new Position( 0, i), MapSize));
                entities.walls.Add(new Wall(new Position( 640 - MapSize, i), MapSize));
                entities.walls.Add(new Wall(new Position( i, 640 - MapSize), MapSize));
            }

            for(int i = MapSize * 3; i <= 640-(MapSize * 4); i+= MapSize)
            {
                entities.walls.Add(new Wall(new Position(i, MapSize * 3), MapSize));
                entities.walls.Add(new Wall(new Position(i, 640 - (MapSize * 4)), MapSize));
                entities.walls.Add(new Wall(new Position(640 / 2, i), MapSize));
                entities.walls.Add(new Wall(new Position(640 / 2 - MapSize, i), MapSize));
            }
        }
    }
}

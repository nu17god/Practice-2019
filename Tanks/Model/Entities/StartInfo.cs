using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class StartInfo
    {
        private int speed;
        private int objectsSize;
        private int appleCount;
        private int enemyCount;

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if(value <= 5 && value >= 1)
                {
                    speed = value;
                }
                else
                {
                    throw new ArgumentException("Speed Error");
                }
            }
        }

        public int ObjectsSize
        {
            get
            {
                return objectsSize;
            }
            set
            {
                if (value == 64)
                {
                    objectsSize = value;
                }
                else if (value == 32)
                {
                    objectsSize = value;
                }
                else if (value == 16)
                {
                    objectsSize = value;
                }
                else
                {
                    throw new ArgumentException("Objects Size Error");
                }
            }
        }

        public int AppleCount
        {
            get
            {
                return appleCount;
            }
            set
            {
                if (value <= 10 && value >= 0)
                {
                    appleCount = value;
                }
                else
                {
                    throw new ArgumentException("Apple Count Error");
                }
            }
        }

        public int EnemyCount
        {
            get
            {
                return enemyCount;
            }
            set
            {
                if (value <= 10 && value >= 0)
                {
                    enemyCount = value;
                }
                else
                {
                    throw new ArgumentException("Apple Count Error");
                }
            }
        }

        public StartInfo(int objectsSize, int speed, int appleCount, int enemycount)
        {
            this.ObjectsSize = objectsSize;
            this.Speed = speed;
            this.AppleCount = appleCount;
            this.EnemyCount = enemycount;
        }

        public StartInfo()
        {
            this.ObjectsSize = 32;
            this.Speed = 3;
            this.AppleCount = 5;
            this.EnemyCount = 5;
        }   
    }
}

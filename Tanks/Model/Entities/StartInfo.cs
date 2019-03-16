using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class StartInfo
    {
        private int objectsSize;
        private int appleCount;
        private int enemyCount;


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

        public StartInfo(int objectsSize, int appleCount, int enemycount)
        {
            this.ObjectsSize = objectsSize;
            this.AppleCount = appleCount;
            this.EnemyCount = enemycount;
        }

        public StartInfo()
        {
            this.ObjectsSize = 32;
            this.AppleCount = 5;
            this.EnemyCount = 5;
        }   
    }
}

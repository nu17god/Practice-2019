using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model
{
    public class EntitiesList
    {
        public Player player { get; set;}
        public List<Wall> walls = new List<Wall>();
        public List<Apple> apples = new List<Apple>();
        public List<Enemy> enemies = new List<Enemy>();
        public List<Bullet> bullets = new List<Bullet>();
        public List<Bullet> playerBullet = new List<Bullet>();
    }
}

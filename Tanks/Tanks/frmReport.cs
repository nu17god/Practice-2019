using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Control;

namespace Tanks
{
    public partial class frmReport : Form
    {
        public frmReport(EntitiesList entities, Point parentLocation)
        {
            this.Location = new Point(parentLocation.X + 640, parentLocation.Y);

            InitializeComponent();
            Update(entities);


        }

        public void Update(EntitiesList entities)
        {
            ctlData.Columns.Clear();
            ctlData.Columns.Add("FirstCollumn", "Type");
            ctlData.Columns.Add("SecondCollumn", "X");
            ctlData.Columns.Add("ThirdCollumn", "Y");

            int index = entities.walls.Count + 1 + entities.apples.Count + entities.enemies.Count;
            int current = 0;

            ctlData.Rows.Add(index);

            ctlData.Rows[current].Cells[0].Value = "Player";
            ctlData.Rows[current].Cells[1].Value = entities.player.position.X;
            ctlData.Rows[current].Cells[2].Value = entities.player.position.Y;
            current++;

            for ( int i = 0; i < entities.enemies.Count; i++)
            {
                ctlData.Rows[current].Cells[0].Value = "Enemy";
                ctlData.Rows[current].Cells[1].Value = entities.enemies[i].position.X;
                ctlData.Rows[current].Cells[2].Value = entities.enemies[i].position.Y;
                current++;
            }

            for (int i = 0; i < entities.apples.Count; i++)
            {
                ctlData.Rows[current].Cells[0].Value = "Apple";
                ctlData.Rows[current].Cells[1].Value = entities.apples[i].position.X;
                ctlData.Rows[current].Cells[2].Value = entities.apples[i].position.Y;
                current++;
            }

            for (int i = 0; i < entities.walls.Count; i++)
            {
                ctlData.Rows[current].Cells[0].Value = "Wall";
                ctlData.Rows[current].Cells[1].Value = entities.walls[i].position.X;
                ctlData.Rows[current].Cells[2].Value = entities.walls[i].position.Y;
                current++;
            }

        }
    }
}

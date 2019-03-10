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

            ctlData.Rows.Add(entities.walls.Count - 1);

            ctlData.Rows[0].Cells[0].Value = entities.player.position.ToString();

            for (int i = 0; i < entities.apples.Count; i++)
            {
                ctlData.Rows[i].Cells[2].Value = entities.apples[i].position.ToString();
            }

            for (int i = 0; i < entities.walls.Count; i++)
            {
                ctlData.Rows[i].Cells[3].Value = entities.walls[i].position.ToString();
            }

            for (int i = 0; i < entities.enemies.Count; i++)
            {
                ctlData.Rows[i].Cells[1].Value = entities.enemies[i].position.ToString();
            }
        }

        public void Update(EntitiesList entities)
        {
            if (!ctlData.Rows[0].Cells[0].Value.Equals(entities.player.position.ToString()))
            {
                ctlData.Rows[0].Cells[0].Value = entities.player.position.ToString();
            }

            for (int i = 0; i < entities.enemies.Count; i++)
            {
                if (!ctlData.Rows[i].Cells[1].Value.Equals(entities.enemies[i].position.ToString()))
                {
                    ctlData.Rows[i].Cells[1].Value = entities.enemies[i].position.ToString();
                }
            }

            for (int i = 0; i < entities.apples.Count; i++)
            {
                if (!ctlData.Rows[i].Cells[2].Value.Equals(entities.apples[i].position.ToString()))
                {
                    ctlData.Rows[i].Cells[2].Value = entities.apples[i].position.ToString();
                }
            }

            for (int i = 0; i < entities.walls.Count; i++)
            {
                if (!ctlData.Rows[i].Cells[3].Value.Equals(entities.walls[i].position.ToString()))
                {
                    ctlData.Rows[i].Cells[3].Value = entities.walls[i].position.ToString();
                }
            }
        }
    }
}

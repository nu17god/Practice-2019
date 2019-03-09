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
    public partial class frmTanks : Form
    {
        int MapSize = 32;
        int Speed = 5;
        int AppleCount = 5;
        int EnemiesCount = 5;
        EntitiesList entities;
        TanksModel tanksModel;
        TanksControl tanksControl;

        public frmTanks()
        {
            InitializeComponent();
            entities = new EntitiesList();
            tanksModel = new TanksModel(entities, Speed, MapSize, AppleCount);
            tanksControl = new TanksControl(tanksModel);
            tanksControl.NewGame(MapSize, Speed, AppleCount, EnemiesCount);
            ctlTime.Enabled = true;
            DrawTanks();
        }

        public void DrawTanks()
        {
            Bitmap bitmap = new Bitmap(640, 640);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, 640, 640));
            entities.player.Draw(graphics);

            for (int i = 0; i < entities.walls.Count;i++)
            {
                entities.walls[i].Draw(graphics);
            }

            for (int i = 0; i < entities.apples.Count; i++)
            {
                entities.apples[i].Draw(graphics);
            }

            ctlMap.Image = bitmap;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewGame newGameForm = new frmNewGame();

            newGameForm.ShowDialog(this);

            if(newGameForm.DialogResult == DialogResult.OK)
            {
                MapSize = newGameForm.MapSize;
                Speed = newGameForm.Speed;
                AppleCount = newGameForm.AppleCount;
                EnemiesCount = newGameForm.TanksCount;

                switch (MapSize)
                {
                    case 64:
                        this.MapSize = 64;
                        break;

                    case 32:
                        this.MapSize = 32;
                        break;

                    case 16:
                        this.MapSize = 16;
                        break;
                }

                tanksControl.NewGame(MapSize, Speed, AppleCount, EnemiesCount);

                DrawTanks();
            }
        }

        private void ctlTime_Tick(object sender, EventArgs e)
        {
            tanksControl.Update();
            DrawTanks();
        }

        private void frmTanks_KeyDown(object sender, KeyEventArgs e)
        {
            tanksControl.ReadKey(e.KeyCode);
        }
    }
}

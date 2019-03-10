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
        int Speed = 3;
        int AppleCount = 5;
        int EnemiesCount = 5;
        int Score;
        bool GameOver;
        int cooldown;

        EntitiesList entities;
        TanksModel tanksModel;
        TanksControl tanksControl;
        frmReport reportForm;

        public frmTanks()
        {
            InitializeComponent();
            entities = new EntitiesList();
            tanksModel = new TanksModel(entities, Speed, MapSize);
            tanksControl = new TanksControl(tanksModel);
            tanksControl.NewGame(MapSize, Speed, AppleCount, EnemiesCount);
            ctlTime.Enabled = true;
            GameOver = false;
            Score = 0;
            cooldown = 0;
            DrawTanks();
        }

        public void DrawTanks()
        {
            Bitmap bitmap = new Bitmap(640, 640);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, 640, 640));
            this.lblScoreValue.Text = Score.ToString();

            if (!GameOver)
            {
                lblScoretxt.Enabled = true;
                lblScoreValue.Enabled = true;

                entities.player.Draw(graphics);

                for (int i = 0; i < entities.bullets.Count; i++)
                {
                    entities.bullets[i].Draw(graphics);
                }

                for (int i = 0; i < entities.playerBullet.Count; i++)
                {
                    entities.playerBullet[i].Draw(graphics);
                }

                for (int i = 0; i < entities.walls.Count; i++)
                {
                    entities.walls[i].Draw(graphics);
                }

                for (int i = 0; i < entities.enemies.Count; i++)
                {
                    entities.enemies[i].Draw(graphics);
                }

                for (int i = 0; i < entities.apples.Count; i++)
                {
                    entities.apples[i].Draw(graphics);
                }

            }

            else
            {
                lblScoretxt.Enabled = false;
                lblScoreValue.Enabled = false;
            }

            ctlMap.Image = bitmap;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void ctlTime_Tick(object sender, EventArgs e)
        {
            cooldown--;

            if(tanksControl.Update(ref Score))
            {
                GameOver = true;
                ctlTime.Enabled = false;
                DrawTanks();
                frmGameOver gameOver = new frmGameOver(Score);

                gameOver.ShowDialog(this);

                if(gameOver.DialogResult == DialogResult.OK)
                {
                    NewGame();
                }
                else if(gameOver.DialogResult == DialogResult.Abort)
                {
                    this.Close();
                }
            }
            DrawTanks();

            if (!(reportForm == null || reportForm.IsDisposed == true))
            {
                reportForm.Update(entities);
            }
        }

        private void frmTanks_KeyDown(object sender, KeyEventArgs e)
        {
            tanksControl.ReadKey(e.KeyCode);

            if(e.KeyCode == Keys.Space)
            {
                if(cooldown < 0)
                {
                    tanksControl.ReadShoot();
                    cooldown = 64;
                }
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(reportForm == null || reportForm.IsDisposed == true)
            {
                reportForm = new frmReport(entities, this.Location);
            }

            reportForm.Show();
        }

        private void NewGame()
        {
            frmNewGame newGameForm = new frmNewGame();

            newGameForm.ShowDialog(this);

            if (newGameForm.DialogResult == DialogResult.OK)
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
                GameOver = false;
                Score = 0;
                ctlTime.Enabled = true;
                cooldown = 0;
                reportForm = new frmReport(entities, this.Location);
                DrawTanks();
            }
        }
    }
}

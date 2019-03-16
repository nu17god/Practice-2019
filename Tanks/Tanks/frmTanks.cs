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
using Model.Entities;

namespace Tanks
{
    public partial class frmTanks : Form
    {

        int Score;
        bool GameOver;

        StartInfo startInfo = new StartInfo();
        EntitiesList entities;
        TanksModel tanksModel;
        TanksControl tanksControl;
        frmReport reportForm;

        public frmTanks()
        {
            InitializeComponent();
            entities = new EntitiesList();
            tanksModel = new TanksModel(entities, startInfo);
            tanksControl = new TanksControl(tanksModel);
            tanksControl.NewGame(startInfo);
            ctlTime.Enabled = true;
            GameOver = false;
            Score = 0;
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
                
                for (int i = 0; i < entities.walls.Count; i++)
                {
                    entities.walls[i].Draw(graphics);
                }

                for (int i = 0; i < entities.apples.Count; i++)
                {
                    entities.apples[i].Draw(graphics);
                }

                for (int i = 0; i < entities.bullets.Count; i++)
                {
                    entities.bullets[i].Draw(graphics);
                }

                for (int i = 0; i < entities.playerBullet.Count; i++)
                {
                    entities.playerBullet[i].Draw(graphics);
                }

                for (int i = 0; i < entities.enemies.Count; i++)
                {
                    entities.enemies[i].Draw(graphics);
                }

                entities.player.Draw(graphics);

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

            if(entities.player.Cooldown >= 16)
            {
                lblReloadValue.Text = "Ready";
                lblReloadValue.ForeColor = Color.Green;
            }
            else
            {
                lblReloadValue.Text = "Reloading";
                lblReloadValue.ForeColor = Color.Red;
            }

            if (reportForm != null && !reportForm.IsDisposed && reportForm.Visible)
            {
                reportForm.Update(entities);
            }
        }

        private void frmTanks_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.P)
            {
                if (ctlTime.Enabled == true)
                {
                    lblPause.Text = "Press \"P\" to unpause the game";
                    ctlTime.Enabled = false;
                }
                else               
                {
                    ctlTime.Enabled = true;
                    lblPause.Text = "Press \"P\" to pause the game";
                }
            }

            tanksControl.ReadKey(e.KeyCode);
        }

        private void NewGame()
        {
            ctlTime.Enabled = false;
            frmNewGame newGameForm = new frmNewGame();
            newGameForm.ShowDialog(this);

            if (newGameForm.DialogResult == DialogResult.OK)
            {
                startInfo = newGameForm.startInfo;

                tanksControl.NewGame(startInfo);
                GameOver = false;
                Score = 0;
                ctlTime.Enabled = true;
                ctlTime.Interval = newGameForm.Speed;
                DrawTanks();

                if (reportForm != null && !reportForm.IsDisposed && reportForm.Visible)
                {
                    reportForm.Close();
                }

                reportForm = null;
            }
            else if (newGameForm.DialogResult == DialogResult.Cancel)
            {
                ctlTime.Enabled = true ;
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportForm == null || !reportForm.IsDisposed || !reportForm.Visible)
            {
                reportForm = new frmReport(entities, this.Location);
            }

            reportForm.Show();
        }
    }
}

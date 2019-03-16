using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entities;

namespace Tanks
{
    public partial class frmNewGame : Form
    {
        public int Speed;

        public StartInfo startInfo;

        public frmNewGame()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int appleCount = int.Parse(ctlAppleCount.Value.ToString());
            int enemycount = int.Parse(ctlTanksCount.Value.ToString());
            int objectSize;

            switch (ctlSpeed.Value)
            {
                case 1:
                    Speed = 125;
                    break;

                case 2:
                    Speed = 100;
                    break;

                case 3:
                    Speed = 75;
                    break;

                case 4:
                    Speed = 50;
                    break;

                case 5:
                    Speed = 25;
                    break;
                default:
                    throw new Exception("Speed Control exception");
            }

            if(btnSize1.Checked == true)
            {
                objectSize = 64;
            }
            else if(btnSize2.Checked == true)
            {
                objectSize = 32;
            }
            else if(btnSize3.Checked == true)
            {
                objectSize = 16;
            }
            else
            {
                throw new Exception("???");
            }
            startInfo = new StartInfo(objectSize, appleCount, enemycount);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

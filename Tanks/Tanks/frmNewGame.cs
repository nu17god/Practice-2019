using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    public partial class frmNewGame : Form
    {
        public int AppleCount { private set; get;}
        public int TanksCount { private set; get; }
        public int Speed { private set; get; }
        public int MapSize { private set; get; }

        public frmNewGame()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AppleCount = int.Parse(ctlAppleCount.Value.ToString());
            TanksCount = int.Parse(ctlTanksCount.Value.ToString());

            switch (ctlSpeed.Value)
            {
                case 1:
                    Speed = 1;
                    break;

                case 2:
                    Speed = 2;
                    break;

                case 3:
                    Speed = 3;
                    break;

                case 4:
                    Speed = 4;
                    break;

                case 5:
                    Speed = 5;
                    break;
            }

            if(btnSize1.Checked == true)
            {
                MapSize = 64;
            }
            else if(btnSize2.Checked == true)
            {
                MapSize = 32;
            }
            else if(btnSize3.Checked == true)
            {
                MapSize = 16;
            }
            else
            {
                throw new Exception("???");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

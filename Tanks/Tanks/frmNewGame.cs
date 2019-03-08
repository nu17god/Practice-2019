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
        public int AppleCount { get; private set; }
        public int TanksCount { get; private set; }

        public frmNewGame()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AppleCount = int.Parse(ctlAppleCount.Value.ToString());
            TanksCount = int.Parse(ctlTanksCount.Value.ToString());
        }
    }
}

﻿using System;
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
    public partial class frmGameOver : Form
    {
        public frmGameOver(int Score)
        {
            InitializeComponent();
            lblScore.Text = "Final score : " + Score;
        }
    }
}

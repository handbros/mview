﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MView.Forms
{
    public partial class RpgsaveForm : Form
    {
        MainForm main;

        public RpgsaveForm(MainForm main)
        {
            InitializeComponent();

            this.main = main;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu formMainMenu = (MainMenu)Tag;
            formMainMenu.Show();
        }
    }
}

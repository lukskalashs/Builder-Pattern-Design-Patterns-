﻿//Lukhanyo Kalashe
//2023575000
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers
{
    public partial class CdlgMessage : Form
    {
        public CdlgMessage(Computer computer)
        {
            InitializeComponent();
            lblText.Text = computer.ToString();
        }

        private void CdlgMessage_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

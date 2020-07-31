using FacebookBackend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookUI
{
    public partial class Form1 : Form
    {
        private readonly Backend m_Backend;
        public Form1()
        {
           m_Backend = new Backend();
            InitializeComponent();
        }

        private void f_LoginButton_Click(object sender, EventArgs e)
        {
            m_Backend.Login();
        }
    }
}

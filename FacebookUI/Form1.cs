using FacebookBackend;
using FacebookWrapper;
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
            m_Backend.Hey();
            InitializeComponent();
        }

        private void f_LoginButton_Click(object sender, EventArgs e)
        {
            if(m_Backend.Login() == "success")
            {
                picture_smallPictureBox.LoadAsync(m_Backend.getPicutureUrl());

                if (m_Backend.getNumOfPost() > 0)
                {
                    textBoxStatus.Text = m_Backend.GetLastPost();
                }
            }
        }

        private void f_Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

﻿using Integrador.GUI;
using Integrador.Repository.EmailConfigure;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class Integrador : Form
    {
        //private readonly IEmailConfigureRepository _emailConfigureRepository;
        public Integrador()
        {
            InitializeComponent();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailConfigureGUI emailConfigureGUI = new EmailConfigureGUI();
            emailConfigureGUI.TopLevel = false;
            
            //Centralizando o formulário EmailConfigureGUI no centro do painel
            int x = (mainPanel.Width - emailConfigureGUI.Width) / 2;
            int y = (mainPanel.Height - emailConfigureGUI.Height) / 2;
            emailConfigureGUI.Location = new Point(x, y);

            //Chamando o formulário EmailConfigureGUI no mainPainel
            mainPanel.Controls.Add(emailConfigureGUI);
            emailConfigureGUI.Show();
        }

        private void napisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnBloxConfigureGUI onBloxConfigureGUI = new OnBloxConfigureGUI();
            onBloxConfigureGUI.TopLevel = false;

            //Centralizando o formulário OnBloxConfigureGui no centro do painel
            int x = (mainPanel.Width - onBloxConfigureGUI.Width) / 2;
            int y = (mainPanel.Height - onBloxConfigureGUI.Height) / 2;
            onBloxConfigureGUI.Location = new Point(x, y);

            //Chamando o formulário OnBloxConfigureGUI no mainPainel
            mainPanel.Controls.Add(onBloxConfigureGUI);
            onBloxConfigureGUI.Show();
        }
    }
}

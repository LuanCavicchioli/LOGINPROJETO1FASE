﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace LoginProjeto1
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=ZlQGgDE9NNk";
            Process.Start(url);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroDeUsuario Cadastro = new CadastroDeUsuario();
            Cadastro.ShowDialog();

        }
    }
}

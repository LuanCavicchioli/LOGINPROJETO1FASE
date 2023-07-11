using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProjeto1
{
    public partial class CadastroDeUsuario : Form
    {
        public CadastroDeUsuario()
        {
            InitializeComponent();
        }

        private void BTNCadastroUsuario_Click(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text != txtSenha.Text)
            {
                MessageBox.Show("AS SENHAS SÃO DIFERENTES, TENTE NOVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNome.Text == "" || txtSenha.Text == "" || txtConfirmarSenha.Text == "" || CBGenero.Text == "" || mskCPF.Text == "" || mskNascimento.Text == "")
            {
                MessageBox.Show("POR FAVOR, PREENCHA TODAS AS LACUNAS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime dataNascimento = DateTime.Parse(mskNascimento.Text);
                DateTime dataAtual = DateTime.Now;
                int idade = dataAtual.Year - dataNascimento.Year;

                if (dataAtual < dataNascimento.AddYears(idade))
                {
                    idade--;
                }

                if (idade >= 18)
                {
                    MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você precisa ter 18 anos ou mais para acessar o sistema.", "Restrição de Idade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if(mskCPF.Text.Length !=11)
            {
                MessageBox.Show("O CPF DEVE CONTER 11 DIGITOS!","ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

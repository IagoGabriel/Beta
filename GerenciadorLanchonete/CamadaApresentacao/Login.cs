using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDados;
using CamadaDados.Session;
using CamadaDados.DAO;

namespace CamadaApresentacao
{
    public partial class Login : Form
    {
        private bool login;

        public bool getButtonLogin()
        {
            return login;
        }
        public Login()
        {
            InitializeComponent();
            tbUsuario.Select();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Equals("") || tbSenha.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                tbUsuario.Clear();
                tbSenha.Clear();
                tbUsuario.Select();
                login = false;
            }
            else
            {
                CreateSession.setUsuario(tbUsuario.Text);
                CreateSession.setSenha(tbSenha.Text);

                ConexaoOracle conn = new ConexaoOracle();

                if (ConexaoOracle.ObterConexao().State == System.Data.ConnectionState.Open)
                {
                    pbLogin.Visible = true;
                    for (int i = 0; i < 100; )
                    {
                        i += 10;
                        Thread.Sleep(50);
                        pbLogin.Value = i;
                    }
                    Thread.Sleep(100);

                    pbCadeado.BackgroundImage = Properties.Resources.aberto;
                    MessageBox.Show("Login efetuado com sucesso!");
                    this.Close();
                    login = true;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos :(");
                    tbUsuario.Clear();
                    tbSenha.Clear();
                    tbUsuario.Select();
                    login = false;
                }
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bLogin.PerformClick();
            }
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bLogin.PerformClick();
            }
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bLogin.PerformClick();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tHoraData_Tick(object sender, EventArgs e)
        {
            data.Text = DateTime.Now.ToShortDateString();
            hora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

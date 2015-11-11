using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestePI
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

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

                if (tbUsuario.Text.Equals("adm") && tbSenha.Text.Equals("123"))
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

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data.Text = DateTime.Now.ToShortDateString();
            hora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}

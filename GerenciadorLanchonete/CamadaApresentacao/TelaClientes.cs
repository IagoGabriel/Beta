using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDados.DAO;
using CamadaDados.Entidades;

namespace CamadaApresentacao
{
    public partial class TelaClientes : Form
    {
        int botao = 0;

        public TelaClientes()
        {
            InitializeComponent();

            List<String> bairros = BairroDAO.BuscaTodos();

            for (int i = 0; i < bairros.Count(); i++)
            {
                cbBairro.Items.Add(bairros[i]);
            }
        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            tbCodigo.Enabled = false;
            tbEndereco.Enabled = true;
            tbTelefone.Enabled = true;
            tbNome.Enabled = true;
            cbBairro.Enabled = true;
            tbEstado.Enabled = true;
            tbObservacao.Enabled = true;
            botao = 1;
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            tbCodigo.Enabled = false;
            tbEndereco.Enabled = true;
            tbTelefone.Enabled = true;
            tbNome.Enabled = true;
            cbBairro.Enabled = true;
            tbEstado.Enabled = true;
            tbObservacao.Enabled = true;
            botao = 2;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            tbCodigo.Clear();
            tbEndereco.Clear();
            tbTelefone.Clear();
            tbNome.Clear();
            cbBairro.Text = "";
            tbEstado.Clear();
            tbObservacao.Clear();
            tbCodigo.Enabled = true;
            tbEndereco.Enabled = false;
            tbTelefone.Enabled = false;
            tbNome.Enabled = false;
            cbBairro.Enabled = false;
            tbEstado.Enabled = false;
            tbObservacao.Enabled = false;
        }

        private void pbLupa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(tbCodigo.Text.Equals("")))
                {
                    Clientes cliente = ClienteDAO.Buscar(int.Parse(tbCodigo.Text));
                    tbNome.Text = cliente.getNome();
                    tbEndereco.Text = cliente.getEndereco();
                    tbTelefone.Text = cliente.getNumero().ToString();
                    cbBairro.Text = BairroDAO.Buscar(cliente.getBairroId()).getNome();
                    tbEstado.Text = cliente.getEstado();
                    tbObservacao.Text = cliente.getObservacao();
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message + "\nCliente com o este código não encontrado.");
            }
        }

        private void bEfetivar_Click(object sender, EventArgs e)
        {
            if(botao == 2){
                if (tbCodigo.Text.Equals("") || tbNome.Text.Equals("") || tbEndereco.Text.Equals("") || tbTelefone.Text.Equals("") || tbCodigo.Text.Equals("") || cbBairro.Text.Equals("") || tbEstado.Text.Equals("") || tbCodigo.Text.Equals(""))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                }
                else
                {
                    Clientes cliente = new Clientes(int.Parse(tbCodigo.Text), tbNome.Text, BairroDAO.BuscaNome(cbBairro.Text), int.Parse(tbTelefone.Text), tbEndereco.Text, tbEstado.Text, tbObservacao.Text);
                    if (ClienteDAO.Alterar(cliente))
                    {
                        MessageBox.Show("Cliente " + cliente.getNome() + " foi alterado com sucesso!");
                        bCancelar_Click(sender, e);
                    }
                }
            }
        }
    }
}

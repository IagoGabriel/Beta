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
    // Teste commmit 
    public partial class TelaProdutos : Form
    {
        public TelaProdutos()
        {
            InitializeComponent();
            tbCodigo.Select();
             
            List<String> categorias = CategoriaDAO.BuscaTodos();

            for (int i = 0; i < categorias.Count(); i++)
            {
                cbCategoria.Items.Add(categorias[i]);
            }
        }
        int botao = 0;
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaProdutos_Load(object sender, EventArgs e)
        {

        }


        private void bCadastrar_Click(object sender, EventArgs e)
        {
            tbCodigo.Enabled = false;
            tbNome.Enabled = true;
            tbPrecoVenda.Enabled = true;
            tbPrecoCusto.Enabled = true;
            tbStatus.Enabled = true;
            tbDescricao.Enabled = true;
            cbCategoria.Enabled = true;
            botao = 1;


        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            tbCodigo.Enabled = false;
            tbNome.Enabled = true;
            tbPrecoVenda.Enabled = true;
            tbPrecoCusto.Enabled = true;
            tbStatus.Enabled = true;
            tbDescricao.Enabled = true;
            cbCategoria.Enabled = true;
            botao = 2;
        }

        private void bLimpar_Click(object sender, EventArgs e)
        {

            tbCodigo.Clear();
            tbNome.Clear();
            tbPrecoVenda.Clear();
            tbPrecoCusto.Clear();
            tbStatus.Clear();
            tbDescricao.Clear();
            cbCategoria.Text = "";
            tbCodigo.Enabled = false;
            tbNome.Enabled = false;
            tbPrecoVenda.Enabled = false;
            tbPrecoCusto.Enabled = false;
            tbStatus.Enabled = false;
            tbDescricao.Enabled = false;
            cbCategoria.Enabled = false;
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            tbCodigo.Enabled = false;
            tbNome.Enabled = true;
            tbPrecoVenda.Enabled = true;
            tbPrecoCusto.Enabled = true;
            tbStatus.Enabled = true;
            tbDescricao.Enabled = true;
            cbCategoria.Enabled = true;
        }


        private void bEfetivar_Click(object sender, EventArgs e)
        {
            if (botao == 1)
            {
                if (tbNome.Text.Equals("") || tbPrecoVenda.Text.Equals("") || tbPrecoCusto.Text.Equals("") || tbStatus.Text.Equals("") || tbDescricao.Text.Equals("") || cbCategoria.Text.Equals(""))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios: *");
                }
                else
                {
                    if (tbDescricao.Text == "")
                    {
                        tbDescricao.Text = " ";
                    }
                    Produtos produto = new Produtos(CategoriaDAO.BuscaNome(cbCategoria.Text), tbNome.Text, tbPrecoVenda.Text, tbPrecoCusto.Text, tbStatus.Text, tbDescricao.Text);
                    if (ProdutoDAO.Inserir(produto))
                    {
                        // tem que ser cancelar //
                        bLimpar_Click(sender, e);
                        MessageBox.Show("Produto" + produto.getNome() + " foi cadastrado com sucesso!");
                    }
                }
            }

            if (botao == 2)
            {
                if (tbNome.Text.Equals("") || tbPrecoVenda.Text.Equals("") || tbPrecoCusto.Text.Equals("") || tbStatus.Text.Equals("") || tbDescricao.Text.Equals("") || cbCategoria.Text.Equals(""))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios: *");
                }
                else
                {
                    if (tbDescricao.Text == "")
                    {
                        tbDescricao.Text = " ";
                    }
                    Produtos produto = new Produtos(int.Parse(tbCodigo.Text), CategoriaDAO.BuscaNome(cbCategoria.Text), tbNome.Text, tbPrecoVenda.Text, tbPrecoCusto.Text, tbStatus.Text, tbDescricao.Text);

                    if (ProdutoDAO.Alterar(produto))
                    {
                        bLimpar_Click(sender, e);
                        MessageBox.Show("Produto " + produto.getNome() + " foi alterado com sucesso!");
                    }
                }
            }
        }
        catch(Exception ex)

                    MessageBox.Show("Ocorreu um erro, contate o administrador do sistema.");
                }
            }
	

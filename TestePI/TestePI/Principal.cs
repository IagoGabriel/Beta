using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestePI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void deClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            TelaClientes telaClientes = new TelaClientes();
            telaClientes.MdiParent = this;
            if (Application.OpenForms.OfType<TelaClientes>().Count() == 0)
            {
                telaClientes.Show();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            TelaClientes telaClientes = new TelaClientes();
            telaClientes.MdiParent = this;
            if (Application.OpenForms.OfType<TelaClientes>().Count() == 0)
            {
                telaClientes.Show();
            }
        }

		private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.IsMdiContainer = true;
			TelaFuncionarios telaFuncionarios = new TelaFuncionarios();
			telaFuncionarios.MdiParent = this;
			if (Application.OpenForms.OfType<TelaFuncionarios>().Count() == 0)
			{
				telaFuncionarios.Show();
			}
		}
	}
}

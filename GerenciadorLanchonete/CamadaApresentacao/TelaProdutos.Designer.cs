namespace CamadaApresentacao
{
    partial class TelaProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbPrecoCusto = new System.Windows.Forms.TextBox();
            this.tbPrecoVenda = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.bAlterar = new System.Windows.Forms.Button();
            this.bEfetivar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(12, 21);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(59, 20);
            this.tbCodigo.TabIndex = 0;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(12, 72);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(180, 20);
            this.tbNome.TabIndex = 1;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(12, 130);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(180, 20);
            this.tbStatus.TabIndex = 1;
            // 
            // tbPrecoCusto
            // 
            this.tbPrecoCusto.Location = new System.Drawing.Point(218, 72);
            this.tbPrecoCusto.Name = "tbPrecoCusto";
            this.tbPrecoCusto.Size = new System.Drawing.Size(100, 20);
            this.tbPrecoCusto.TabIndex = 2;
            // 
            // tbPrecoVenda
            // 
            this.tbPrecoVenda.Location = new System.Drawing.Point(339, 72);
            this.tbPrecoVenda.Name = "tbPrecoVenda";
            this.tbPrecoVenda.Size = new System.Drawing.Size(100, 20);
            this.tbPrecoVenda.TabIndex = 3;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(218, 130);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(221, 90);
            this.tbDescricao.TabIndex = 4;
            this.tbDescricao.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // bCadastrar
            // 
            this.bCadastrar.Location = new System.Drawing.Point(12, 235);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bCadastrar.TabIndex = 5;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Código";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Nome";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(215, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Categoria";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(215, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Preço Custo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(336, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Preço Venda";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(215, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Descrição";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(218, 21);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(45, 1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 18);
            this.label20.TabIndex = 14;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(276, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 18);
            this.label21.TabIndex = 15;
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(402, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 18);
            this.label22.TabIndex = 16;
            this.label22.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(266, 1);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 18);
            this.label23.TabIndex = 17;
            this.label23.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(45, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 18);
            this.label24.TabIndex = 18;
            this.label24.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(45, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 18);
            this.label25.TabIndex = 19;
            this.label25.Text = "*";
            // 
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(102, 236);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 21;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // bEfetivar
            // 
            this.bEfetivar.Location = new System.Drawing.Point(192, 236);
            this.bEfetivar.Name = "bEfetivar";
            this.bEfetivar.Size = new System.Drawing.Size(75, 23);
            this.bEfetivar.TabIndex = 22;
            this.bEfetivar.Text = "Efetivar";
            this.bEfetivar.UseVisualStyleBackColor = true;
            this.bEfetivar.Click += new System.EventHandler(this.bEfetivar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(279, 235);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 23;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // bExcluir
            // 
            this.bExcluir.Location = new System.Drawing.Point(364, 236);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(75, 23);
            this.bExcluir.TabIndex = 24;
            this.bExcluir.Text = "Excluir";
            this.bExcluir.UseVisualStyleBackColor = true;
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click);
            // 
            // TelaProdutos
            // 
            this.ClientSize = new System.Drawing.Size(451, 270);
            this.Controls.Add(this.bExcluir);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bEfetivar);
            this.Controls.Add(this.bAlterar);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bCadastrar);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbPrecoVenda);
            this.Controls.Add(this.tbPrecoCusto);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbCodigo);
            this.Name = "TelaProdutos";
            this.Load += new System.EventHandler(this.TelaProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbPrecoCusto;
        private System.Windows.Forms.TextBox tbPrecoVenda;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.Button bEfetivar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bExcluir;
    }
}
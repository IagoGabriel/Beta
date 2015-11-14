namespace CamadaApresentacao
{
    partial class TelaClientes
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
			this.bCadastrar = new System.Windows.Forms.Button();
			this.bAlterar = new System.Windows.Forms.Button();
			this.bCancelar = new System.Windows.Forms.Button();
			this.bEfetivar = new System.Windows.Forms.Button();
			this.tbCodigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbEstado = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbEndereco = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbTelefone = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbObservacao = new System.Windows.Forms.TextBox();
			this.pbLupaCodigo = new System.Windows.Forms.PictureBox();
			this.cbBairro = new System.Windows.Forms.ComboBox();
			this.cbAtivo = new System.Windows.Forms.CheckBox();
			this.pbLupaTelefone = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbLupaCodigo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLupaTelefone)).BeginInit();
			this.SuspendLayout();
			// 
			// bCadastrar
			// 
			this.bCadastrar.Location = new System.Drawing.Point(25, 285);
			this.bCadastrar.Name = "bCadastrar";
			this.bCadastrar.Size = new System.Drawing.Size(75, 23);
			this.bCadastrar.TabIndex = 23;
			this.bCadastrar.Text = "Cadastrar";
			this.bCadastrar.UseVisualStyleBackColor = true;
			this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
			// 
			// bAlterar
			// 
			this.bAlterar.Location = new System.Drawing.Point(106, 285);
			this.bAlterar.Name = "bAlterar";
			this.bAlterar.Size = new System.Drawing.Size(75, 23);
			this.bAlterar.TabIndex = 24;
			this.bAlterar.Text = "Alterar";
			this.bAlterar.UseVisualStyleBackColor = true;
			this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
			// 
			// bCancelar
			// 
			this.bCancelar.Location = new System.Drawing.Point(438, 285);
			this.bCancelar.Name = "bCancelar";
			this.bCancelar.Size = new System.Drawing.Size(75, 23);
			this.bCancelar.TabIndex = 25;
			this.bCancelar.Text = "Limpar";
			this.bCancelar.UseVisualStyleBackColor = true;
			this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
			// 
			// bEfetivar
			// 
			this.bEfetivar.Location = new System.Drawing.Point(357, 285);
			this.bEfetivar.Name = "bEfetivar";
			this.bEfetivar.Size = new System.Drawing.Size(75, 23);
			this.bEfetivar.TabIndex = 26;
			this.bEfetivar.Text = "Efetivar";
			this.bEfetivar.UseVisualStyleBackColor = true;
			this.bEfetivar.Click += new System.EventHandler(this.bEfetivar_Click);
			// 
			// tbCodigo
			// 
			this.tbCodigo.Location = new System.Drawing.Point(25, 41);
			this.tbCodigo.Name = "tbCodigo";
			this.tbCodigo.Size = new System.Drawing.Size(64, 20);
			this.tbCodigo.TabIndex = 27;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "Código";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 29;
			this.label2.Text = "Nome";
			// 
			// tbNome
			// 
			this.tbNome.Enabled = false;
			this.tbNome.Location = new System.Drawing.Point(25, 90);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(181, 20);
			this.tbNome.TabIndex = 30;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(261, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 33;
			this.label4.Text = "Bairro";
			// 
			// tbEstado
			// 
			this.tbEstado.Enabled = false;
			this.tbEstado.Location = new System.Drawing.Point(264, 90);
			this.tbEstado.Name = "tbEstado";
			this.tbEstado.Size = new System.Drawing.Size(100, 20);
			this.tbEstado.TabIndex = 34;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 35;
			this.label5.Text = "Endereço";
			// 
			// tbEndereco
			// 
			this.tbEndereco.Enabled = false;
			this.tbEndereco.Location = new System.Drawing.Point(25, 138);
			this.tbEndereco.Name = "tbEndereco";
			this.tbEndereco.Size = new System.Drawing.Size(181, 20);
			this.tbEndereco.TabIndex = 36;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 171);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 37;
			this.label6.Text = "Telefone";
			// 
			// tbTelefone
			// 
			this.tbTelefone.ForeColor = System.Drawing.Color.Silver;
			this.tbTelefone.Location = new System.Drawing.Point(25, 187);
			this.tbTelefone.Name = "tbTelefone";
			this.tbTelefone.Size = new System.Drawing.Size(100, 20);
			this.tbTelefone.TabIndex = 38;
			this.tbTelefone.Text = "(27)99999-9999";
			this.tbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbTelefone.Click += new System.EventHandler(this.tbTelefone_Click);
			this.tbTelefone.TextChanged += new System.EventHandler(this.tbTelefone_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(261, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 39;
			this.label7.Text = "Estado";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(261, 122);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 13);
			this.label8.TabIndex = 41;
			this.label8.Text = "Observação";
			// 
			// tbObservacao
			// 
			this.tbObservacao.Enabled = false;
			this.tbObservacao.Location = new System.Drawing.Point(264, 144);
			this.tbObservacao.Multiline = true;
			this.tbObservacao.Name = "tbObservacao";
			this.tbObservacao.Size = new System.Drawing.Size(249, 96);
			this.tbObservacao.TabIndex = 42;
			// 
			// pbLupaCodigo
			// 
			this.pbLupaCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbLupaCodigo.Image = global::CamadaApresentacao.Properties.Resources.lupa;
			this.pbLupaCodigo.InitialImage = null;
			this.pbLupaCodigo.Location = new System.Drawing.Point(95, 42);
			this.pbLupaCodigo.Name = "pbLupaCodigo";
			this.pbLupaCodigo.Size = new System.Drawing.Size(20, 19);
			this.pbLupaCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLupaCodigo.TabIndex = 43;
			this.pbLupaCodigo.TabStop = false;
			this.pbLupaCodigo.Click += new System.EventHandler(this.pbLupaCodigo_Click);
			// 
			// cbBairro
			// 
			this.cbBairro.Enabled = false;
			this.cbBairro.FormattingEnabled = true;
			this.cbBairro.Location = new System.Drawing.Point(264, 41);
			this.cbBairro.Name = "cbBairro";
			this.cbBairro.Size = new System.Drawing.Size(121, 21);
			this.cbBairro.TabIndex = 45;
			// 
			// cbAtivo
			// 
			this.cbAtivo.AutoSize = true;
			this.cbAtivo.Enabled = false;
			this.cbAtivo.Location = new System.Drawing.Point(25, 222);
			this.cbAtivo.Name = "cbAtivo";
			this.cbAtivo.Size = new System.Drawing.Size(50, 17);
			this.cbAtivo.TabIndex = 46;
			this.cbAtivo.Text = "Ativo";
			this.cbAtivo.UseVisualStyleBackColor = true;
			this.cbAtivo.CheckedChanged += new System.EventHandler(this.cbAtivo_CheckedChanged);
			// 
			// pbLupaTelefone
			// 
			this.pbLupaTelefone.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbLupaTelefone.Image = global::CamadaApresentacao.Properties.Resources.lupa1;
			this.pbLupaTelefone.Location = new System.Drawing.Point(131, 188);
			this.pbLupaTelefone.Name = "pbLupaTelefone";
			this.pbLupaTelefone.Size = new System.Drawing.Size(20, 19);
			this.pbLupaTelefone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLupaTelefone.TabIndex = 47;
			this.pbLupaTelefone.TabStop = false;
			this.pbLupaTelefone.Click += new System.EventHandler(this.pbLupaTelefone_Click);
			// 
			// TelaClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 332);
			this.Controls.Add(this.pbLupaTelefone);
			this.Controls.Add(this.cbAtivo);
			this.Controls.Add(this.cbBairro);
			this.Controls.Add(this.pbLupaCodigo);
			this.Controls.Add(this.tbObservacao);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbTelefone);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbEndereco);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbEstado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbCodigo);
			this.Controls.Add(this.bEfetivar);
			this.Controls.Add(this.bCancelar);
			this.Controls.Add(this.bAlterar);
			this.Controls.Add(this.bCadastrar);
			this.MaximumSize = new System.Drawing.Size(550, 370);
			this.MinimumSize = new System.Drawing.Size(550, 370);
			this.Name = "TelaClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clientes";
			((System.ComponentModel.ISupportInitialize)(this.pbLupaCodigo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLupaTelefone)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bEfetivar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbObservacao;
        private System.Windows.Forms.PictureBox pbLupaCodigo;
        private System.Windows.Forms.ComboBox cbBairro;
		private System.Windows.Forms.CheckBox cbAtivo;
		private System.Windows.Forms.PictureBox pbLupaTelefone;
	}
}
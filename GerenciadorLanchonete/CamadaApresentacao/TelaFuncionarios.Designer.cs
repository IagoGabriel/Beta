namespace CamadaApresentacao
{
	partial class TelaFuncionarios
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
            this.Código = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.rdResidencial = new System.Windows.Forms.RadioButton();
            this.rdCelular = new System.Windows.Forms.RadioButton();
            this.mtbResidencial = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bAlterar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bEfetivar = new System.Windows.Forms.Button();
            this.pbLupaCodigo = new System.Windows.Forms.PictureBox();
            this.pbLupaTelefone = new System.Windows.Forms.PictureBox();
            this.asterisco = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupaCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupaTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(22, 28);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(40, 13);
            this.Código.TabIndex = 0;
            this.Código.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(25, 45);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(75, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(25, 95);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(181, 20);
            this.tbNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Observação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Endereço";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Enabled = false;
            this.tbEndereco.Location = new System.Drawing.Point(254, 45);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(100, 20);
            this.tbEndereco.TabIndex = 11;
            // 
            // tbEstado
            // 
            this.tbEstado.Enabled = false;
            this.tbEstado.Location = new System.Drawing.Point(254, 148);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(100, 20);
            this.tbEstado.TabIndex = 13;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Enabled = false;
            this.cbAtivo.Location = new System.Drawing.Point(28, 293);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbAtivo.TabIndex = 14;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdResidencial
            // 
            this.rdResidencial.AutoSize = true;
            this.rdResidencial.Location = new System.Drawing.Point(25, 205);
            this.rdResidencial.Name = "rdResidencial";
            this.rdResidencial.Size = new System.Drawing.Size(80, 17);
            this.rdResidencial.TabIndex = 15;
            this.rdResidencial.TabStop = true;
            this.rdResidencial.Text = "Residencial";
            this.rdResidencial.UseVisualStyleBackColor = true;
            this.rdResidencial.CheckedChanged += new System.EventHandler(this.rdResidencial_CheckedChanged);
            // 
            // rdCelular
            // 
            this.rdCelular.AutoSize = true;
            this.rdCelular.Location = new System.Drawing.Point(117, 205);
            this.rdCelular.Name = "rdCelular";
            this.rdCelular.Size = new System.Drawing.Size(57, 17);
            this.rdCelular.TabIndex = 16;
            this.rdCelular.TabStop = true;
            this.rdCelular.Text = "Celular";
            this.rdCelular.UseVisualStyleBackColor = true;
            this.rdCelular.CheckedChanged += new System.EventHandler(this.rdCelular_CheckedChanged);
            // 
            // mtbResidencial
            // 
            this.mtbResidencial.Enabled = false;
            this.mtbResidencial.Location = new System.Drawing.Point(25, 229);
            this.mtbResidencial.Mask = "(##) ####-####";
            this.mtbResidencial.Name = "mtbResidencial";
            this.mtbResidencial.Size = new System.Drawing.Size(100, 20);
            this.mtbResidencial.TabIndex = 17;
            this.mtbResidencial.Click += new System.EventHandler(this.mtbResidencial_Click);
            this.mtbResidencial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbResidencial_KeyPress);
            // 
            // mtbCelular
            // 
            this.mtbCelular.Enabled = false;
            this.mtbCelular.Location = new System.Drawing.Point(25, 256);
            this.mtbCelular.Mask = "(##) #####-####";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(100, 20);
            this.mtbCelular.TabIndex = 18;
            this.mtbCelular.Click += new System.EventHandler(this.mtbCelular_Click);
            this.mtbCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCelular_KeyPress);
            // 
            // tbObservacao
            // 
            this.tbObservacao.Enabled = false;
            this.tbObservacao.Location = new System.Drawing.Point(254, 205);
            this.tbObservacao.Multiline = true;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(249, 96);
            this.tbObservacao.TabIndex = 43;
            // 
            // bCadastrar
            // 
            this.bCadastrar.Location = new System.Drawing.Point(25, 328);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bCadastrar.TabIndex = 44;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(106, 328);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 45;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(427, 327);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 46;
            this.bCancelar.Text = "Limpar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bEfetivar
            // 
            this.bEfetivar.Location = new System.Drawing.Point(346, 326);
            this.bEfetivar.Name = "bEfetivar";
            this.bEfetivar.Size = new System.Drawing.Size(75, 23);
            this.bEfetivar.TabIndex = 47;
            this.bEfetivar.Text = "Efetivar";
            this.bEfetivar.UseVisualStyleBackColor = true;
            this.bEfetivar.Click += new System.EventHandler(this.bEfetivar_Click);
            // 
            // pbLupaCodigo
            // 
            this.pbLupaCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLupaCodigo.Image = global::CamadaApresentacao.Properties.Resources.lupa;
            this.pbLupaCodigo.InitialImage = null;
            this.pbLupaCodigo.Location = new System.Drawing.Point(106, 46);
            this.pbLupaCodigo.Name = "pbLupaCodigo";
            this.pbLupaCodigo.Size = new System.Drawing.Size(20, 19);
            this.pbLupaCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLupaCodigo.TabIndex = 48;
            this.pbLupaCodigo.TabStop = false;
            this.pbLupaCodigo.Click += new System.EventHandler(this.pbLupaCodigo_Click);
            // 
            // pbLupaTelefone
            // 
            this.pbLupaTelefone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLupaTelefone.Image = global::CamadaApresentacao.Properties.Resources.lupa;
            this.pbLupaTelefone.InitialImage = null;
            this.pbLupaTelefone.Location = new System.Drawing.Point(131, 228);
            this.pbLupaTelefone.Name = "pbLupaTelefone";
            this.pbLupaTelefone.Size = new System.Drawing.Size(20, 19);
            this.pbLupaTelefone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLupaTelefone.TabIndex = 49;
            this.pbLupaTelefone.TabStop = false;
            this.pbLupaTelefone.Click += new System.EventHandler(this.pbLupaTelefone_Click);
            // 
            // asterisco
            // 
            this.asterisco.AutoSize = true;
            this.asterisco.BackColor = System.Drawing.Color.Transparent;
            this.asterisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisco.ForeColor = System.Drawing.Color.Red;
            this.asterisco.Location = new System.Drawing.Point(61, 23);
            this.asterisco.Name = "asterisco";
            this.asterisco.Size = new System.Drawing.Size(14, 18);
            this.asterisco.TabIndex = 53;
            this.asterisco.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(310, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 18);
            this.label8.TabIndex = 54;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(61, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 18);
            this.label9.TabIndex = 55;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(290, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 18);
            this.label10.TabIndex = 56;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(61, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 18);
            this.label11.TabIndex = 57;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(80, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 18);
            this.label12.TabIndex = 58;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(297, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 18);
            this.label13.TabIndex = 59;
            this.label13.Text = "*";
            // 
            // cbCargo
            // 
            this.cbCargo.Enabled = false;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(25, 148);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 60;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // tbBairro
            // 
            this.tbBairro.Enabled = false;
            this.tbBairro.Location = new System.Drawing.Point(254, 95);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(100, 20);
            this.tbBairro.TabIndex = 61;
            // 
            // TelaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 372);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.asterisco);
            this.Controls.Add(this.pbLupaTelefone);
            this.Controls.Add(this.pbLupaCodigo);
            this.Controls.Add(this.bEfetivar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAlterar);
            this.Controls.Add(this.bCadastrar);
            this.Controls.Add(this.tbObservacao);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbResidencial);
            this.Controls.Add(this.rdCelular);
            this.Controls.Add(this.rdResidencial);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.Código);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 410);
            this.MinimumSize = new System.Drawing.Size(540, 410);
            this.Name = "TelaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.pbLupaCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupaTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Código;
		private System.Windows.Forms.TextBox tbCodigo;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbEndereco;
		private System.Windows.Forms.TextBox tbEstado;
		private System.Windows.Forms.CheckBox cbAtivo;
		private System.Windows.Forms.RadioButton rdResidencial;
		private System.Windows.Forms.RadioButton rdCelular;
		private System.Windows.Forms.MaskedTextBox mtbResidencial;
		private System.Windows.Forms.MaskedTextBox mtbCelular;
		private System.Windows.Forms.TextBox tbObservacao;
		private System.Windows.Forms.Button bCadastrar;
		private System.Windows.Forms.Button bAlterar;
		private System.Windows.Forms.Button bCancelar;
		private System.Windows.Forms.Button bEfetivar;
		private System.Windows.Forms.PictureBox pbLupaCodigo;
		private System.Windows.Forms.PictureBox pbLupaTelefone;
		private System.Windows.Forms.Label asterisco;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cbCargo;
		private System.Windows.Forms.TextBox tbBairro;
	}
}
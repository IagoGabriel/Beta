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
            this.pbLupa = new System.Windows.Forms.PictureBox();
            this.cbBairro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupa)).BeginInit();
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
            this.bAlterar.Location = new System.Drawing.Point(144, 285);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 24;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(532, 285);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 25;
            this.bCancelar.Text = "Limpar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bEfetivar
            // 
            this.bEfetivar.Location = new System.Drawing.Point(441, 285);
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
            this.tbNome.Size = new System.Drawing.Size(221, 20);
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
            this.tbEndereco.Size = new System.Drawing.Size(137, 20);
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
            this.tbTelefone.Enabled = false;
            this.tbTelefone.Location = new System.Drawing.Point(25, 187);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 20);
            this.tbTelefone.TabIndex = 38;
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
            this.tbObservacao.Size = new System.Drawing.Size(273, 96);
            this.tbObservacao.TabIndex = 42;
            // 
            // pbLupa
            // 
            this.pbLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLupa.Image = global::CamadaApresentacao.Properties.Resources.lupa;
            this.pbLupa.InitialImage = null;
            this.pbLupa.Location = new System.Drawing.Point(95, 42);
            this.pbLupa.Name = "pbLupa";
            this.pbLupa.Size = new System.Drawing.Size(20, 19);
            this.pbLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLupa.TabIndex = 43;
            this.pbLupa.TabStop = false;
            this.pbLupa.Click += new System.EventHandler(this.pbLupa_Click);
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
            // TelaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 332);
            this.Controls.Add(this.cbBairro);
            this.Controls.Add(this.pbLupa);
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
            this.MaximumSize = new System.Drawing.Size(645, 370);
            this.MinimumSize = new System.Drawing.Size(645, 370);
            this.Name = "TelaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.pbLupa)).EndInit();
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
        private System.Windows.Forms.PictureBox pbLupa;
        private System.Windows.Forms.ComboBox cbBairro;
    }
}
namespace CamadaApresentacao
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.hora = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.pbLogin = new System.Windows.Forms.ProgressBar();
            this.pbCadeado = new System.Windows.Forms.PictureBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tHoraData = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCadeado)).BeginInit();
            this.SuspendLayout();
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.BackColor = System.Drawing.Color.Transparent;
            this.hora.Location = new System.Drawing.Point(348, 11);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(30, 13);
            this.hora.TabIndex = 20;
            this.hora.Text = "Hora";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.BackColor = System.Drawing.Color.Transparent;
            this.data.Location = new System.Drawing.Point(244, 11);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(30, 13);
            this.data.TabIndex = 19;
            this.data.Text = "Data";
            // 
            // pbLogin
            // 
            this.pbLogin.BackColor = System.Drawing.SystemColors.Control;
            this.pbLogin.Location = new System.Drawing.Point(12, 225);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(423, 14);
            this.pbLogin.TabIndex = 18;
            this.pbLogin.Visible = false;
            // 
            // pbCadeado
            // 
            this.pbCadeado.BackColor = System.Drawing.Color.Transparent;
            this.pbCadeado.BackgroundImage = global::CamadaApresentacao.Properties.Resources.trancado;
            this.pbCadeado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCadeado.ErrorImage = null;
            this.pbCadeado.Location = new System.Drawing.Point(44, 51);
            this.pbCadeado.Name = "pbCadeado";
            this.pbCadeado.Size = new System.Drawing.Size(110, 155);
            this.pbCadeado.TabIndex = 17;
            this.pbCadeado.TabStop = false;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(336, 183);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(61, 23);
            this.bCancelar.TabIndex = 16;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.SystemColors.Control;
            this.bLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bLogin.Location = new System.Drawing.Point(247, 183);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(61, 23);
            this.bLogin.TabIndex = 15;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(247, 123);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(150, 20);
            this.tbSenha.TabIndex = 14;
            this.tbSenha.UseSystemPasswordChar = true;
            this.tbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenha_KeyPress);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(247, 90);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(150, 20);
            this.tbUsuario.TabIndex = 13;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuário:";
            // 
            // tHoraData
            // 
            this.tHoraData.Enabled = true;
            this.tHoraData.Tick += new System.EventHandler(this.tHoraData_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 250);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.data);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.pbCadeado);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 288);
            this.MinimumSize = new System.Drawing.Size(463, 288);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbCadeado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.ProgressBar pbLogin;
        private System.Windows.Forms.PictureBox pbCadeado;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tHoraData;
    }
}
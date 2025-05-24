namespace SistemaChamados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.linkCadastrar = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUsuario.Location = new System.Drawing.Point(344, 173);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(139, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSenha.Location = new System.Drawing.Point(344, 218);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(139, 26);
            this.txtSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrar.Location = new System.Drawing.Point(344, 278);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(139, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // linkCadastrar
            // 
            this.linkCadastrar.AutoSize = true;
            this.linkCadastrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkCadastrar.Location = new System.Drawing.Point(423, 253);
            this.linkCadastrar.Name = "linkCadastrar";
            this.linkCadastrar.Size = new System.Drawing.Size(118, 13);
            this.linkCadastrar.TabIndex = 5;
            this.linkCadastrar.TabStop = true;
            this.linkCadastrar.Text = "Cadastrar novo Usuario";
            this.linkCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastrar_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaChamados.Properties.Resources.Texto_do_seu_paragrafo_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(211, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(398, 100);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(259, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 167);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel linkCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


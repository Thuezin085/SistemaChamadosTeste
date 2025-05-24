using System;
using Npgsql;
using System.Windows.Forms;

namespace SistemaChamados
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChamados = new System.Windows.Forms.TabPage();
            this.btnMarcarPendente = new System.Windows.Forms.Button();
            this.btnFecharChamado = new System.Windows.Forms.Button();
            this.dgvChamados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNovoChamado = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriarChamado = new System.Windows.Forms.Button();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tabRelatorios = new System.Windows.Forms.TabPage();
            this.chartChamados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPreferencias = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPref = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenhaPref = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailPref = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomePref = new System.Windows.Forms.TextBox();
            this.Chatbot = new System.Windows.Forms.TabPage();
            this.lblMensagemBot = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMensagemUsuario = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.picChatbot = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabChamados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).BeginInit();
            this.tabNovoChamado.SuspendLayout();
            this.tabRelatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartChamados)).BeginInit();
            this.tabPreferencias.SuspendLayout();
            this.Chatbot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatbot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChamados);
            this.tabControl1.Controls.Add(this.tabNovoChamado);
            this.tabControl1.Controls.Add(this.tabRelatorios);
            this.tabControl1.Controls.Add(this.tabPreferencias);
            this.tabControl1.Controls.Add(this.Chatbot);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabChamados
            // 
            this.tabChamados.Controls.Add(this.pictureBox7);
            this.tabChamados.Controls.Add(this.pictureBox1);
            this.tabChamados.Controls.Add(this.btnMarcarPendente);
            this.tabChamados.Controls.Add(this.btnFecharChamado);
            this.tabChamados.Controls.Add(this.dgvChamados);
            this.tabChamados.Location = new System.Drawing.Point(4, 22);
            this.tabChamados.Name = "tabChamados";
            this.tabChamados.Padding = new System.Windows.Forms.Padding(3);
            this.tabChamados.Size = new System.Drawing.Size(792, 424);
            this.tabChamados.TabIndex = 0;
            this.tabChamados.Text = "Chamados";
            this.tabChamados.UseVisualStyleBackColor = true;
            // 
            // btnMarcarPendente
            // 
            this.btnMarcarPendente.BackColor = System.Drawing.Color.Gold;
            this.btnMarcarPendente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMarcarPendente.Location = new System.Drawing.Point(575, 380);
            this.btnMarcarPendente.Name = "btnMarcarPendente";
            this.btnMarcarPendente.Size = new System.Drawing.Size(152, 23);
            this.btnMarcarPendente.TabIndex = 2;
            this.btnMarcarPendente.Text = "Marcar como Pendente";
            this.btnMarcarPendente.UseVisualStyleBackColor = false;
            this.btnMarcarPendente.Click += new System.EventHandler(this.btnMarcarPendente_Click);
            // 
            // btnFecharChamado
            // 
            this.btnFecharChamado.BackColor = System.Drawing.Color.IndianRed;
            this.btnFecharChamado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFecharChamado.Location = new System.Drawing.Point(81, 380);
            this.btnFecharChamado.Name = "btnFecharChamado";
            this.btnFecharChamado.Size = new System.Drawing.Size(125, 23);
            this.btnFecharChamado.TabIndex = 1;
            this.btnFecharChamado.Text = "Fechar Chamado";
            this.btnFecharChamado.UseVisualStyleBackColor = false;
            this.btnFecharChamado.Click += new System.EventHandler(this.btnFecharChamado_Click);
            // 
            // dgvChamados
            // 
            this.dgvChamados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Categoria,
            this.Descricao,
            this.Status,
            this.Anexo});
            this.dgvChamados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChamados.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvChamados.Location = new System.Drawing.Point(3, 3);
            this.dgvChamados.Name = "dgvChamados";
            this.dgvChamados.Size = new System.Drawing.Size(786, 418);
            this.dgvChamados.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Anexo
            // 
            this.Anexo.HeaderText = "Anexo";
            this.Anexo.Name = "Anexo";
            // 
            // tabNovoChamado
            // 
            this.tabNovoChamado.BackColor = System.Drawing.Color.White;
            this.tabNovoChamado.Controls.Add(this.pictureBox9);
            this.tabNovoChamado.Controls.Add(this.pictureBox8);
            this.tabNovoChamado.Controls.Add(this.pictureBox2);
            this.tabNovoChamado.Controls.Add(this.label8);
            this.tabNovoChamado.Controls.Add(this.txtAnexo);
            this.tabNovoChamado.Controls.Add(this.label1);
            this.tabNovoChamado.Controls.Add(this.label2);
            this.tabNovoChamado.Controls.Add(this.btnCriarChamado);
            this.tabNovoChamado.Controls.Add(this.btnAnexo);
            this.tabNovoChamado.Controls.Add(this.cmbCategoria);
            this.tabNovoChamado.Controls.Add(this.txtDescricao);
            this.tabNovoChamado.Controls.Add(this.pictureBox6);
            this.tabNovoChamado.Controls.Add(this.pictureBox3);
            this.tabNovoChamado.Location = new System.Drawing.Point(4, 22);
            this.tabNovoChamado.Name = "tabNovoChamado";
            this.tabNovoChamado.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoChamado.Size = new System.Drawing.Size(792, 424);
            this.tabNovoChamado.TabIndex = 1;
            this.tabNovoChamado.Text = "Novo Chamado\n\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(321, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Preencha para realizar seu chamado";
            // 
            // txtAnexo
            // 
            this.txtAnexo.Location = new System.Drawing.Point(390, 326);
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.ReadOnly = true;
            this.txtAnexo.Size = new System.Drawing.Size(19, 20);
            this.txtAnexo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(378, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(378, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // btnCriarChamado
            // 
            this.btnCriarChamado.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCriarChamado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCriarChamado.Location = new System.Drawing.Point(327, 373);
            this.btnCriarChamado.Name = "btnCriarChamado";
            this.btnCriarChamado.Size = new System.Drawing.Size(150, 23);
            this.btnCriarChamado.TabIndex = 5;
            this.btnCriarChamado.Text = "Criar Chamado";
            this.btnCriarChamado.UseVisualStyleBackColor = false;
            this.btnCriarChamado.Click += new System.EventHandler(this.btnCriarChamado_Click);
            // 
            // btnAnexo
            // 
            this.btnAnexo.Location = new System.Drawing.Point(309, 277);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(192, 23);
            this.btnAnexo.TabIndex = 4;
            this.btnAnexo.Text = "Selecionar Anexo";
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(292, 107);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(224, 21);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(292, 147);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(224, 124);
            this.txtDescricao.TabIndex = 0;
            // 
            // tabRelatorios
            // 
            this.tabRelatorios.Controls.Add(this.pictureBox10);
            this.tabRelatorios.Controls.Add(this.chartChamados);
            this.tabRelatorios.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorios.Name = "tabRelatorios";
            this.tabRelatorios.Size = new System.Drawing.Size(792, 424);
            this.tabRelatorios.TabIndex = 2;
            this.tabRelatorios.Text = "Relatórios";
            this.tabRelatorios.UseVisualStyleBackColor = true;
            // 
            // chartChamados
            // 
            chartArea1.Name = "ChartArea1";
            this.chartChamados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartChamados.Legends.Add(legend1);
            this.chartChamados.Location = new System.Drawing.Point(150, 98);
            this.chartChamados.Name = "chartChamados";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Chamados";
            this.chartChamados.Series.Add(series1);
            this.chartChamados.Size = new System.Drawing.Size(530, 318);
            this.chartChamados.TabIndex = 0;
            this.chartChamados.Text = "chart1";
            this.chartChamados.Click += new System.EventHandler(this.chartChamados_Click);
            // 
            // tabPreferencias
            // 
            this.tabPreferencias.BackColor = System.Drawing.Color.White;
            this.tabPreferencias.Controls.Add(this.pictureBox13);
            this.tabPreferencias.Controls.Add(this.pictureBox12);
            this.tabPreferencias.Controls.Add(this.pictureBox11);
            this.tabPreferencias.Controls.Add(this.btnLogout);
            this.tabPreferencias.Controls.Add(this.btnPref);
            this.tabPreferencias.Controls.Add(this.label6);
            this.tabPreferencias.Controls.Add(this.txtSenhaPref);
            this.tabPreferencias.Controls.Add(this.label5);
            this.tabPreferencias.Controls.Add(this.txtEmailPref);
            this.tabPreferencias.Controls.Add(this.label4);
            this.tabPreferencias.Controls.Add(this.txtNomePref);
            this.tabPreferencias.Controls.Add(this.pictureBox4);
            this.tabPreferencias.Location = new System.Drawing.Point(4, 22);
            this.tabPreferencias.Name = "tabPreferencias";
            this.tabPreferencias.Size = new System.Drawing.Size(792, 424);
            this.tabPreferencias.TabIndex = 3;
            this.tabPreferencias.Text = "Preferências";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Brown;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(476, 317);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPref
            // 
            this.btnPref.Location = new System.Drawing.Point(249, 317);
            this.btnPref.Name = "btnPref";
            this.btnPref.Size = new System.Drawing.Size(115, 23);
            this.btnPref.TabIndex = 6;
            this.btnPref.Text = "Salvar Preferências";
            this.btnPref.UseVisualStyleBackColor = true;
            this.btnPref.Click += new System.EventHandler(this.btnPref_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(385, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Senha";
            // 
            // txtSenhaPref
            // 
            this.txtSenhaPref.Location = new System.Drawing.Point(359, 250);
            this.txtSenhaPref.Name = "txtSenhaPref";
            this.txtSenhaPref.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaPref.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(391, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // txtEmailPref
            // 
            this.txtEmailPref.Location = new System.Drawing.Point(359, 171);
            this.txtEmailPref.Name = "txtEmailPref";
            this.txtEmailPref.Size = new System.Drawing.Size(100, 20);
            this.txtEmailPref.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(391, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNomePref
            // 
            this.txtNomePref.Location = new System.Drawing.Point(359, 96);
            this.txtNomePref.Name = "txtNomePref";
            this.txtNomePref.Size = new System.Drawing.Size(100, 20);
            this.txtNomePref.TabIndex = 0;
            // 
            // Chatbot
            // 
            this.Chatbot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Chatbot.Controls.Add(this.pictureBox14);
            this.Chatbot.Controls.Add(this.lblMensagemBot);
            this.Chatbot.Controls.Add(this.button2);
            this.Chatbot.Controls.Add(this.label7);
            this.Chatbot.Controls.Add(this.txtMensagemUsuario);
            this.Chatbot.Controls.Add(this.picChatbot);
            this.Chatbot.Controls.Add(this.pictureBox5);
            this.Chatbot.Location = new System.Drawing.Point(4, 22);
            this.Chatbot.Name = "Chatbot";
            this.Chatbot.Size = new System.Drawing.Size(792, 424);
            this.Chatbot.TabIndex = 4;
            this.Chatbot.Text = "Assistente Virtual";
            // 
            // lblMensagemBot
            // 
            this.lblMensagemBot.AutoSize = true;
            this.lblMensagemBot.BackColor = System.Drawing.Color.White;
            this.lblMensagemBot.Location = new System.Drawing.Point(236, 117);
            this.lblMensagemBot.Name = "lblMensagemBot";
            this.lblMensagemBot.Size = new System.Drawing.Size(209, 13);
            this.lblMensagemBot.TabIndex = 1;
            this.lblMensagemBot.Text = "Olá! Sou o assistente virtual do Help Desk.";
            this.lblMensagemBot.Click += new System.EventHandler(this.label7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(628, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(220, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Digite sua Dúvida";
            // 
            // txtMensagemUsuario
            // 
            this.txtMensagemUsuario.Location = new System.Drawing.Point(181, 355);
            this.txtMensagemUsuario.Multiline = true;
            this.txtMensagemUsuario.Name = "txtMensagemUsuario";
            this.txtMensagemUsuario.Size = new System.Drawing.Size(422, 42);
            this.txtMensagemUsuario.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SistemaChamados.Properties.Resources.circui;
            this.pictureBox7.Location = new System.Drawing.Point(552, 76);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(234, 298);
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaChamados.Properties.Resources.Texto_do_seu_paragrafo__2__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(549, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SistemaChamados.Properties.Resources.circui2;
            this.pictureBox9.Location = new System.Drawing.Point(0, 125);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(209, 299);
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SistemaChamados.Properties.Resources.circui;
            this.pictureBox8.Location = new System.Drawing.Point(575, 125);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(217, 299);
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaChamados.Properties.Resources.gutaolol;
            this.pictureBox2.Location = new System.Drawing.Point(370, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 58);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SistemaChamados.Properties.Resources.Texto_do_seu_paragrafo_71;
            this.pictureBox6.Location = new System.Drawing.Point(349, 43);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(118, 22);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SistemaChamados.Properties.Resources.enanidiu;
            this.pictureBox3.Location = new System.Drawing.Point(224, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(351, 397);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SistemaChamados.Properties.Resources.Texto_do_seu_paragrafo__8__removebg_preview;
            this.pictureBox10.Location = new System.Drawing.Point(320, 30);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(230, 50);
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::SistemaChamados.Properties.Resources.circui;
            this.pictureBox13.Location = new System.Drawing.Point(575, 125);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(217, 299);
            this.pictureBox13.TabIndex = 16;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::SistemaChamados.Properties.Resources.circui2;
            this.pictureBox12.Location = new System.Drawing.Point(0, 125);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(209, 299);
            this.pictureBox12.TabIndex = 15;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox11.Image = global::SistemaChamados.Properties.Resources.user;
            this.pictureBox11.Location = new System.Drawing.Point(279, 27);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(247, 50);
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SistemaChamados.Properties.Resources.enanidiu;
            this.pictureBox4.Location = new System.Drawing.Point(227, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(351, 397);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::SistemaChamados.Properties.Resources.ed1;
            this.pictureBox14.Location = new System.Drawing.Point(283, 3);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(329, 47);
            this.pictureBox14.TabIndex = 6;
            this.pictureBox14.TabStop = false;
            // 
            // picChatbot
            // 
            this.picChatbot.BackColor = System.Drawing.Color.White;
            this.picChatbot.Image = global::SistemaChamados.Properties.Resources.Design_sem_nome_removebg_preview;
            this.picChatbot.Location = new System.Drawing.Point(170, 93);
            this.picChatbot.Name = "picChatbot";
            this.picChatbot.Size = new System.Drawing.Size(60, 59);
            this.picChatbot.TabIndex = 0;
            this.picChatbot.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(128, 53);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(575, 295);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabChamados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).EndInit();
            this.tabNovoChamado.ResumeLayout(false);
            this.tabNovoChamado.PerformLayout();
            this.tabRelatorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartChamados)).EndInit();
            this.tabPreferencias.ResumeLayout(false);
            this.tabPreferencias.PerformLayout();
            this.Chatbot.ResumeLayout(false);
            this.Chatbot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatbot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnMarcarPendente_Click(object sender, EventArgs e)
        {
            if (dgvChamados.SelectedRows.Count > 0)
            {
                int idChamado = Convert.ToInt32(dgvChamados.SelectedRows[0].Cells["Id"].Value);

                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = "UPDATE chamados SET status = @status WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("status", "Pendente");
                        cmd.Parameters.AddWithValue("id", idChamado);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Atualiza a DataGridView e o gráfico
                AtualizarDataGridView();
                AtualizarGrafico(); // Atualiza o gráfico para refletir a mudança para "Pendente"
            }
            else
            {
                MessageBox.Show("Selecione um chamado para marcar como pendente.");
            }
        }




        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChamados;
        private System.Windows.Forms.TabPage tabNovoChamado;
        private System.Windows.Forms.TabPage tabRelatorios;
        private System.Windows.Forms.TabPage tabPreferencias;
        private System.Windows.Forms.DataGridView dgvChamados;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.ComboBox cmbCategoria;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnMarcarPendente;
        private System.Windows.Forms.Button btnFecharChamado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnexo;
        public System.Windows.Forms.Button btnCriarChamado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChamados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaPref;
        private System.Windows.Forms.TextBox txtEmailPref;
        private System.Windows.Forms.TextBox txtNomePref;
        private System.Windows.Forms.Button btnPref;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage Chatbot;
        private System.Windows.Forms.PictureBox picChatbot;
        private System.Windows.Forms.Label lblMensagemBot;
        private System.Windows.Forms.TextBox txtMensagemUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anexo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label8;
        private PictureBox pictureBox4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox14;
    }
}
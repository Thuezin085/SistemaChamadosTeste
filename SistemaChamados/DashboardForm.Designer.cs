using System;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChamados = new System.Windows.Forms.TabPage();
            this.btnMarcarPendente = new System.Windows.Forms.Button();
            this.btnFecharChamado = new System.Windows.Forms.Button();
            this.dgvChamados = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNovoChamado = new System.Windows.Forms.TabPage();
            this.btnCriarChamado = new System.Windows.Forms.Button();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tabRelatorios = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.chartChamados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPreferencias = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaPref = new System.Windows.Forms.TextBox();
            this.txtEmailPref = new System.Windows.Forms.TextBox();
            this.txtNomePref = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabChamados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).BeginInit();
            this.tabNovoChamado.SuspendLayout();
            this.tabRelatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartChamados)).BeginInit();
            this.tabPreferencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChamados);
            this.tabControl1.Controls.Add(this.tabNovoChamado);
            this.tabControl1.Controls.Add(this.tabRelatorios);
            this.tabControl1.Controls.Add(this.tabPreferencias);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabChamados
            // 
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
            this.btnMarcarPendente.Location = new System.Drawing.Point(569, 380);
            this.btnMarcarPendente.Name = "btnMarcarPendente";
            this.btnMarcarPendente.Size = new System.Drawing.Size(152, 23);
            this.btnMarcarPendente.TabIndex = 2;
            this.btnMarcarPendente.Text = "Marcar como Pendente";
            this.btnMarcarPendente.UseVisualStyleBackColor = true;
            this.btnMarcarPendente.Click += new System.EventHandler(this.btnMarcarPendente_Click);
            // 
            // btnFecharChamado
            // 
            this.btnFecharChamado.Location = new System.Drawing.Point(85, 380);
            this.btnFecharChamado.Name = "btnFecharChamado";
            this.btnFecharChamado.Size = new System.Drawing.Size(125, 23);
            this.btnFecharChamado.TabIndex = 1;
            this.btnFecharChamado.Text = "Fechar Chamado";
            this.btnFecharChamado.UseVisualStyleBackColor = true;
            this.btnFecharChamado.Click += new System.EventHandler(this.btnFecharChamado_Click);
            // 
            // dgvChamados
            // 
            this.dgvChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.Descricao,
            this.Status,
            this.Anexo});
            this.dgvChamados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChamados.Location = new System.Drawing.Point(3, 3);
            this.dgvChamados.Name = "dgvChamados";
            this.dgvChamados.Size = new System.Drawing.Size(786, 418);
            this.dgvChamados.TabIndex = 0;
            this.dgvChamados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamados_CellContentClick);
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
            this.tabNovoChamado.Controls.Add(this.txtAnexo);
            this.tabNovoChamado.Controls.Add(this.btnCriarChamado);
            this.tabNovoChamado.Controls.Add(this.btnAnexo);
            this.tabNovoChamado.Controls.Add(this.label2);
            this.tabNovoChamado.Controls.Add(this.label1);
            this.tabNovoChamado.Controls.Add(this.cmbCategoria);
            this.tabNovoChamado.Controls.Add(this.txtDescricao);
            this.tabNovoChamado.Location = new System.Drawing.Point(4, 22);
            this.tabNovoChamado.Name = "tabNovoChamado";
            this.tabNovoChamado.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoChamado.Size = new System.Drawing.Size(792, 424);
            this.tabNovoChamado.TabIndex = 1;
            this.tabNovoChamado.Text = "Novo Chamado\n\n";
            this.tabNovoChamado.UseVisualStyleBackColor = true;
            // 
            // btnCriarChamado
            // 
            this.btnCriarChamado.Location = new System.Drawing.Point(328, 330);
            this.btnCriarChamado.Name = "btnCriarChamado";
            this.btnCriarChamado.Size = new System.Drawing.Size(150, 23);
            this.btnCriarChamado.TabIndex = 5;
            this.btnCriarChamado.Text = "Criar Chamado";
            this.btnCriarChamado.UseVisualStyleBackColor = true;
            this.btnCriarChamado.Click += new System.EventHandler(this.btnCriarChamado_Click);
            // 
            // btnAnexo
            // 
            this.btnAnexo.Location = new System.Drawing.Point(304, 264);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(192, 23);
            this.btnAnexo.TabIndex = 4;
            this.btnAnexo.Text = "Selecionar Anexo";
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(204, 225);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(392, 21);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(204, 60);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(392, 124);
            this.txtDescricao.TabIndex = 0;
            // 
            // tabRelatorios
            // 
            this.tabRelatorios.Controls.Add(this.label3);
            this.tabRelatorios.Controls.Add(this.chartChamados);
            this.tabRelatorios.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorios.Name = "tabRelatorios";
            this.tabRelatorios.Size = new System.Drawing.Size(792, 424);
            this.tabRelatorios.TabIndex = 2;
            this.tabRelatorios.Text = "Relatórios";
            this.tabRelatorios.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chamados Abertos por categoria";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chartChamados
            // 
            chartArea3.Name = "ChartArea1";
            this.chartChamados.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartChamados.Legends.Add(legend3);
            this.chartChamados.Location = new System.Drawing.Point(150, 116);
            this.chartChamados.Name = "chartChamados";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartChamados.Series.Add(series3);
            this.chartChamados.Size = new System.Drawing.Size(523, 300);
            this.chartChamados.TabIndex = 0;
            this.chartChamados.Text = "chart1";
            this.chartChamados.Click += new System.EventHandler(this.chartChamados_Click);
            // 
            // tabPreferencias
            // 
            this.tabPreferencias.Controls.Add(this.button1);
            this.tabPreferencias.Controls.Add(this.label6);
            this.tabPreferencias.Controls.Add(this.label5);
            this.tabPreferencias.Controls.Add(this.label4);
            this.tabPreferencias.Controls.Add(this.txtSenhaPref);
            this.tabPreferencias.Controls.Add(this.txtEmailPref);
            this.tabPreferencias.Controls.Add(this.txtNomePref);
            this.tabPreferencias.Location = new System.Drawing.Point(4, 22);
            this.tabPreferencias.Name = "tabPreferencias";
            this.tabPreferencias.Size = new System.Drawing.Size(792, 424);
            this.tabPreferencias.TabIndex = 3;
            this.tabPreferencias.Text = "Preferências";
            this.tabPreferencias.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar Preferências";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSenhaPref
            // 
            this.txtSenhaPref.Location = new System.Drawing.Point(343, 250);
            this.txtSenhaPref.Name = "txtSenhaPref";
            this.txtSenhaPref.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaPref.TabIndex = 2;
            // 
            // txtEmailPref
            // 
            this.txtEmailPref.Location = new System.Drawing.Point(343, 171);
            this.txtEmailPref.Name = "txtEmailPref";
            this.txtEmailPref.Size = new System.Drawing.Size(100, 20);
            this.txtEmailPref.TabIndex = 1;
            // 
            // txtNomePref
            // 
            this.txtNomePref.Location = new System.Drawing.Point(343, 106);
            this.txtNomePref.Name = "txtNomePref";
            this.txtNomePref.Size = new System.Drawing.Size(100, 20);
            this.txtNomePref.TabIndex = 0;
            // 
            // txtAnexo
            // 
            this.txtAnexo.Location = new System.Drawing.Point(349, 293);
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.ReadOnly = true;
            this.txtAnexo.Size = new System.Drawing.Size(100, 20);
            this.txtAnexo.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.tabRelatorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartChamados)).EndInit();
            this.tabPreferencias.ResumeLayout(false);
            this.tabPreferencias.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnMarcarPendente_Click(object sender, EventArgs e)
        {
            if (dgvChamados.SelectedRows.Count > 0)
            {
                int index = dgvChamados.SelectedRows[0].Index;
                chamados[index].Status = "Pendente";
                AtualizarDataGridView();
                AtualizarGrafico();
            }
        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChamados;
        private System.Windows.Forms.TabPage tabNovoChamado;
        private System.Windows.Forms.TabPage tabRelatorios;
        private System.Windows.Forms.TabPage tabPreferencias;
        private System.Windows.Forms.DataGridView dgvChamados;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnMarcarPendente;
        private System.Windows.Forms.Button btnFecharChamado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.Button btnCriarChamado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChamados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaPref;
        private System.Windows.Forms.TextBox txtEmailPref;
        private System.Windows.Forms.TextBox txtNomePref;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anexo;
        private System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
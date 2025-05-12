using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaChamados
{
    public partial class DashboardForm : Form
    {
        // Lista de chamados em memória
        private List<Chamado> chamados = new List<Chamado>();

        // Caminho do anexo selecionado
        private string anexoSelecionado = "";

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // --- Configurar categorias da ComboBox (Novo Chamado)
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Hardware");
            cmbCategoria.Items.Add("Software");
            cmbCategoria.SelectedIndex = 0;

            // --- Configurar o gráfico
            chartChamados.Series.Clear();
            chartChamados.Series.Add("Chamados");

            // --- Atualizar exibição inicial
            AtualizarDataGridView();
            AtualizarGrafico();
        }

        private void btnAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                anexoSelecionado = ofd.FileName;
                MessageBox.Show("Arquivo selecionado: " + anexoSelecionado);
            }
        }

        private void btnCriarChamado_Click(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.SelectedItem.ToString();
            string descricao = txtDescricao.Text.Trim();

            if (descricao == "")
            {
                MessageBox.Show("Digite a descrição do chamado.");
                return;
            }

            Chamado novoChamado = new Chamado(categoria, descricao, "Aberto");
            novoChamado.Anexo = anexoSelecionado;


            chamados.Add(novoChamado);

            txtDescricao.Clear();
            anexoSelecionado = "";

            AtualizarDataGridView();
            AtualizarGrafico();

            MessageBox.Show("Chamado criado com sucesso!");
        }

        private void AtualizarDataGridView()
        {
            dgvChamados.Rows.Clear();

            foreach (var chamado in chamados)
            {
                dgvChamados.Rows.Add(chamado.Categoria, chamado.Descricao, chamado.Status, chamado.Anexo);
            }
        }

        private void AtualizarGrafico()
        {
            int hardwareCount = chamados.Count(c => c.Categoria == "Hardware" && c.Status == "Aberto");
            int softwareCount = chamados.Count(c => c.Categoria == "Software" && c.Status == "Aberto");

            chartChamados.Series["Chamados"].Points.Clear();
            chartChamados.Series["Chamados"].Points.AddXY("Hardware", hardwareCount);
            chartChamados.Series["Chamados"].Points.AddXY("Software", softwareCount);
        }

        private void btnFecharChamado_Click(object sender, EventArgs e)
        {
            if (dgvChamados.SelectedRows.Count > 0)
            {
                int index = dgvChamados.SelectedRows[0].Index;
                chamados[index].Status = "Fechado";
                AtualizarDataGridView();
                AtualizarGrafico();
            }
        }

        private void dgvChamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chartChamados_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPendenteChamado_Click(object sender, EventArgs e)
        {
            if (dgvChamados.SelectedRows.Count > 0)
            {
                int index = dgvChamados.SelectedRows[0].Index;
                chamados[index].Status = "Pendente";
                AtualizarDataGridView();
                AtualizarGrafico();
            }
        }
    }
}
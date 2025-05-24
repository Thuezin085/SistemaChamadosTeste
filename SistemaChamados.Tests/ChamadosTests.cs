using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaChamados;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace SistemaChamados.Tests
{
    [TestClass]
    public class DashboardFormTests
    {
        [TestMethod]
        public void CriarChamado_ComDadosValidos_DeveSalvarSemErros()
        {
            
            var form = new DashboardForm();

            
            form.Controls.Add(new ComboBox { Name = "cmbCategoria", Items = { "Suporte" }, SelectedIndex = 0 });
            form.Controls.Add(new TextBox { Name = "txtDescricao", Text = "Chamado de teste" });
            form.Controls.Add(new TextBox { Name = "txtAnexo", Text = "anexo.pdf" });

            
            typeof(DashboardForm).GetField("cmbCategoria", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                ?.SetValue(form, form.Controls["cmbCategoria"]);
            typeof(DashboardForm).GetField("txtDescricao", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                ?.SetValue(form, form.Controls["txtDescricao"]);
            typeof(DashboardForm).GetField("txtAnexo", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                ?.SetValue(form, form.Controls["txtAnexo"]);

            
            form.btnCriarChamado_Click(null, EventArgs.Empty);

          
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void CriarChamado_SemDescricao_NaoDeveLancarErro()
        {
            var form = new DashboardForm();

            
            var cmbCategoria = new ComboBox { Name = "cmbCategoria" };
            cmbCategoria.Items.Add("Financeiro");
            cmbCategoria.SelectedIndex = 0;

            var txtDescricao = new TextBox { Name = "txtDescricao", Text = "" }; 
            var txtAnexo = new TextBox { Name = "txtAnexo", Text = "documento.png" };

         
            form.Controls.Add(cmbCategoria);
            form.Controls.Add(txtDescricao);
            form.Controls.Add(txtAnexo);

       
            typeof(DashboardForm).GetField("cmbCategoria", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                ?.SetValue(form, cmbCategoria);
            typeof(DashboardForm).GetField("txtDescricao", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                ?.SetValue(form, txtDescricao);
            typeof(DashboardForm).GetField("txtAnexo", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                ?.SetValue(form, txtAnexo);

            try
            {
                form.btnCriarChamado_Click(null, EventArgs.Empty);
                Assert.IsTrue(true); 
            }
            catch (Exception ex)
            {
                Assert.Fail("O método lançou exceção: " + ex.Message);
            }
        }
    }
}
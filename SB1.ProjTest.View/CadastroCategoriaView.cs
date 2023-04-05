using SB1.ProjTest.Controller;
using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SB1.ProjTest.View
{
    public partial class CadastroCategoriaView : Form
    {
        public CadastroCategoriaView()
        {
            InitializeComponent();
            ConsultaLista();
        }

        private void ConsultaLista()
        {
            try
            {
                BindingSource bindingSourceLista = CategoriaController.Consultar(null);

                dgCategoria.DataSource = bindingSourceLista;

            }
            catch
            {
                // ignored
            }
        }

        //Método de gravação
        private void Gravar()
        {
            try
            {
                List<Categoria> categoria = new List<Categoria>();
                foreach (DataGridViewRow linha in dgCategoria.Rows)
                {
                    //se tiver algum valor no logradouro, grava o endereco,
                    //caso não apenas pula 
                    if (!string.IsNullOrEmpty(Convert.ToString(linha.Cells["categoria"].Value)))
                    {
                        categoria.Add(new Categoria()
                        {

                            //adicionando os campos informados no grid, para os objetos da model
                            codigo = Convert.ToString(linha.Cells["codigo"].Value),
                            categoria = Convert.ToString(linha.Cells["categoria"].Value),
                            descricao = Convert.ToString(linha.Cells["descricao"].Value),
                            status = true,
                            dataInsercao = DateTime.Now,
                            dataAtualizacao = DateTime.Now,
                        });
                    }
                }
                if (CategoriaController.Gravar(categoria))
                {
                    string mensagem = "Sucesso ao gravar a  categoria";
                    string titulo = "Sucesso.";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    MessageBox.Show(mensagem, titulo, botoes, icone);
                }
            }
            catch (Exception ex)
            {

                string mensagem = "Erro ao gravar a categoria. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
    }
}

using SB1.ProjTest.Controller;
using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SB1.ProjTest.View
{
    public partial class CadastroUnidadeMedidaView : Form
    {
        public CadastroUnidadeMedidaView()
        {
            InitializeComponent();
            ConsultaLista();
        }
        private void ConsultaLista()
        {
            try
            {
                BindingSource bindingSourceLista = UnidadeMedidaController.Consultar(null);

                dgUnidadeMedida.DataSource = bindingSourceLista;

            }
            catch { }
        }
        //Método de gravação
        private void Gravar()
        {
            try
            {
                List<UnidadeMedida> medida = new List<UnidadeMedida>();
                foreach (DataGridViewRow linha in dgUnidadeMedida.Rows)
                {
                    //se tiver algum valor no logradouro, grava o endereco,
                    //caso não apenas pula 
                    if (!string.IsNullOrEmpty(Convert.ToString(linha.Cells["unidadeMedida"].Value)))
                    {
                        medida.Add(new UnidadeMedida()
                        {

                            //adicionando os campos informados no grid, para os objetos da model
                            codigo = Convert.ToString(linha.Cells["codigo"].Value),
                            unidadeMedida = Convert.ToString(linha.Cells["unidadeMedida"].Value),
                            descricao = Convert.ToString(linha.Cells["descricao"].Value),
                            status = true,
                            dataInsercao = DateTime.Now,
                            dataAtualizacao = DateTime.Now,
                        });
                    }
                }
                if (UnidadeMedidaController.Gravar(medida))
                {
                    string mensagem = "Sucesso ao gravar as unidades de medida";
                    string titulo = "Sucesso.";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    MessageBox.Show(mensagem, titulo, botoes, icone);
                }
            }
            catch (Exception ex)
            {

                string mensagem = "Erro ao gravar a unidade de medida. Erro: " + ex.Message;
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

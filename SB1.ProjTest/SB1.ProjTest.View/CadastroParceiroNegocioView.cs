using SB1.ProjTest.Controller;
using SB1.ProjTest.Model;
using SB1.ProjTest.Relatorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SB1.ProjTest.View
{
    public partial class CadastroParceiroNegocioView : Form
    {
        public CadastroParceiroNegocioView()
        {
            InitializeComponent();
        }
        public CadastroParceiroNegocioView(int id)
        {
            InitializeComponent();
            Consultar(id);
        }

        private void Consultar(int id)
        {
            try
            {
                ParceiroNegocio parceiro = ParceiroNegocioController.Consultar(id);

                txID.Text = parceiro.id.ToString();

                txNome.Text = parceiro.nome;

                txTelefone.Text = parceiro.telefone;

                txEmail.Text = parceiro.eMail;

                cbParceiro.Text = parceiro.parceiroNegocio;

                if (parceiro.parceiroNegocio.Equals("CL"))
                {
                    cbParceiro.Text = "Cleinte";
                }
                else if(parceiro.parceiroNegocio.Equals("FO"))
                {
                    cbParceiro.Text = "Fornecedor";
                }
                else if (parceiro.parceiroNegocio.Equals("CF"))
                {
                    cbParceiro.Text = "Cliente/FOrnecedor";
                }

                cbTipoDocuemento.Text = parceiro.tipoDocumento;

                txDocumento.Text = parceiro.documento;

                txDataInsercao.Text = parceiro.dataInsercao.ToString();

                txDataAtualizacao.Text = parceiro.dataAtualizacao.ToString();

            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar o Parceiro de Negócio. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }

        private void Gravar()
        {
            try
            {
                //tratamento da gravação de dados
                //trata a falta de informações
                if (string.IsNullOrEmpty(txNome.Text))
                {
                    throw new Exception("Insira um nome.");
                }
                if (string.IsNullOrEmpty(cbParceiro.Text))
                {
                    throw new Exception("Seleciona um tipo de parceiro");
                }
                if (string.IsNullOrEmpty(txDocumento.Text))
                {
                    throw new Exception("Insira um documento");
                }


                ParceiroNegocio parceiroNegocio = new ParceiroNegocio();

                parceiroNegocio.nome = txNome.Text;
                parceiroNegocio.id = !string.IsNullOrEmpty(txID.Text) ? Convert.ToInt32(txID) : 0;

                if (cbParceiro.Text == "CLIENTE")
                {
                    parceiroNegocio.parceiroNegocio = "CL";
                }
                else if (cbParceiro.Text == "FORNECEDOR")
                {
                    parceiroNegocio.parceiroNegocio = "FO";
                }
                else if (cbParceiro.Text == "CLIENTE/FORNECEDOR")
                {
                    parceiroNegocio.parceiroNegocio = "CF";
                }

                parceiroNegocio.tipoDocumento = cbTipoDocuemento.Text;

                parceiroNegocio.documento = txDocumento.Text;

                parceiroNegocio.eMail = txEmail.Text;

                parceiroNegocio.telefone = txTelefone.Text;

                parceiroNegocio.dataInsercao = (!txDataInsercao.Text.Equals("  /  /       :")) ? Convert.ToDateTime(txDataInsercao.Text) : DateTime.Now;

                parceiroNegocio.dataAtualizacao = DateTime.Now;

                parceiroNegocio.ativo = true;

                if (ParceiroNegocioController.Gravar(parceiroNegocio))
                {
                    txID.Text = parceiroNegocio.id.ToString();
                    txDataInsercao.Text = parceiroNegocio.dataInsercao.ToString();
                    txDataAtualizacao.Text = parceiroNegocio.dataAtualizacao.ToString();

                    string mensagem = "Sucesso ao gravar Parceiro de Negócio: " + parceiroNegocio.id.ToString() + " - " + parceiroNegocio.nome;
                    string titulo = "Sucesso.";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    MessageBox.Show(mensagem, titulo, botoes, icone);
                }

            }

            catch (Exception ex)
            {
                string mensagem = "Erro ao gravar o Parceiro de Negócio. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        private void imprimir()
        {
            try
            {
                
                {
                    if (!string.IsNullOrEmpty(txID.Text))
                    {
                        int id = Convert.ToInt32(txID.Text);
                        RelatorioParceiroNegocio relatorio = new RelatorioParceiroNegocio();
                        relatorio.SetParameterValue("user", id);

                        rvRelatorio childForm = new rvRelatorio(relatorio);
                        childForm.MdiParent = ActiveForm;
                        childForm.Show();
                         
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            Gravar();
            Close();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }
    }
}

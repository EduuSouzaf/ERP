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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SB1.ProjTest.View
{
    public partial class CadastroParceiroNegocioView : Form
    {

        //Construtores
        #region CadastroParceiroNegocioView
        public CadastroParceiroNegocioView()
        {
            InitializeComponent();
        }
        public CadastroParceiroNegocioView(int id)
        {
            InitializeComponent();
            Consultar(id);

        }
        #endregion
        //Métodos
        #region Consultar
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
                else if (parceiro.parceiroNegocio.Equals("FO"))
                {
                    cbParceiro.Text = "Fornecedor";
                }
                else if (parceiro.parceiroNegocio.Equals("CF"))
                {
                    cbParceiro.Text = "Cliente/Fornecedor";
                }

                cbTipoDocuemento.Text = parceiro.tipoDocumento;

                txDocumento.Text = parceiro.documento;

                txDataInsercao.Text = parceiro.dataInsercao.ToString();

                txDataAtualizacao.Text = parceiro.dataAtualizacao.ToString();

                //endereco recebendo id do parceiro selecionando na tela de consulta
                BindingSource endereco = ParceiroNegocioController.ConsultarLista(id);
                dgEndereco.DataSource = endereco;

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

        #endregion
        #region Gravar
        private void Gravar()
        {
            try
            {
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

                parceiroNegocio.id = !string.IsNullOrEmpty(txID.Text) ? Convert.ToInt32(txID.Text) : 0;

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

                List<Endereco> endereco = new List<Endereco>();
                foreach (DataGridViewRow linha in dgEndereco.Rows)
                {
                    //se tiver algum valor no logradouro, grava o endereco,
                    //caso não apenas pula 
                    if (!string.IsNullOrEmpty(Convert.ToString(linha.Cells["logradouro"].Value)))
                    {
                        endereco.Add(new Endereco()
                        {
                            //adicionando os campos informados no grid, para os objetos da model
                            idEndereco = Convert.ToInt32(linha.Cells["idEndereco"].Value),
                            idParceiroNegocio = 0,
                            logradouro = Convert.ToString(linha.Cells["logradouro"].Value),
                            numero = Convert.ToInt32(linha.Cells["numero"].Value),
                            bairro = Convert.ToString(linha.Cells["bairro"].Value),
                            cidade = Convert.ToString(linha.Cells["cidade"].Value),
                            estado = Convert.ToString(linha.Cells["estado"].Value),
                            cep = Convert.ToString(linha.Cells["cep"].Value),
                            complemento = Convert.ToString(linha.Cells["complemento"].Value),
                            dataInsercao = DateTime.Now,
                        });
                    }
                }

                if (ParceiroNegocioController.Gravar(parceiroNegocio, endereco))
                {
                    string nome = txNome.Text;

                    string mensagem = "Sucesso ao gravar Parceiro de Negócio: " + nome;
                    string titulo = "Sucesso.";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    MessageBox.Show(mensagem, titulo, botoes, icone);

                    Close();
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
        #endregion
        #region Imprimir
        private void Imprimir()
        {
            try
            {
                if (!string.IsNullOrEmpty(txID.Text))
                {
                    RelatorioParceiroNegocio relatorio = new RelatorioParceiroNegocio();
                    relatorio.SetParameterValue("parceiro", txID.Text);

                    rvRelatorio childForm = new rvRelatorio(relatorio);
                    childForm.Show();
                }

            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao imprimir o Parceiro de Negócio. Erro: " + ex.Message;
                string titulo = "Erro. ";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region ExcluirEndereco
        public void ExcluirEndereco()
        {
            try
            {
                if (dgEndereco.SelectedRows.Count != null)
                {
                    int idEndereco = Convert.ToInt32(dgEndereco.Rows[dgEndereco.SelectedRows[0].Index].Cells["idEndereco"].Value);
                    int idParceiro = !string.IsNullOrEmpty(txID.Text) ? Convert.ToInt32(txID.Text) : 0;

                    string mensagem = "Tem certeza que deseja excluir o Endereço " + idEndereco.ToString();
                    string titulo = "Aviso";
                    MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                    MessageBoxIcon icone = MessageBoxIcon.Warning;
                    DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

                    if (resultado == DialogResult.Yes)
                    {
                        if (idEndereco != 0 && idParceiro != 0)
                        {
                            Endereco endereco = ParceiroNegocioController.ConsultarEndereco(idEndereco, idParceiro);

                            ParceiroNegocioController.ExcluirEndereco(endereco);
                        }

                        dgEndereco.Rows.RemoveAt(dgEndereco.SelectedRows[0].Index);

                        mensagem = "Sucesso ao excluir endereço: " + idEndereco;
                        titulo = "Sucesso. ";
                        botoes = MessageBoxButtons.OK;
                        icone = MessageBoxIcon.Information;
                        MessageBox.Show(mensagem, titulo, botoes, icone);
                    }

                }
                else
                {
                    string mensagem = "Selecione uma linha no grid";
                    string titulo = "Aviso. ";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Warning;
                    MessageBox.Show(mensagem, titulo, botoes, icone);
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao excluir endereço. Erro: " + ex.Message;
                string titulo = "Erro. ";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        //Eventos
        #region cbTipoDocuemento_Leave
        private void cbTipoDocuemento_Leave(object sender, EventArgs e)
        {
            if (cbTipoDocuemento.Text == "CPF")
            {
                txDocumento.Mask = "000,000,000-00";
            }
            else if (cbTipoDocuemento.Text == "CNPJ")
            {
                txDocumento.Mask = "00,000,000/0000-00";
            }
            else
            {
                txDocumento.Mask = "";
            }
        }
        #endregion
        #region txTelefone_KeyPress
        private void txTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
            }
        }
        #endregion
        #region txDocumento_KeyPress
        private void txDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
            }
        }
        #endregion
        #region btCancelar_Click
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region btExcluirEndereco_Click
        private void btExcluirEndereco_Click(object sender, EventArgs e)
        {
            ExcluirEndereco();
        }
        #endregion
        #region txNome_KeyPress
        private void txNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region btExit_Click
        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region btCadastrar_Click
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
        #endregion
        #region btImprimir_Click
        private void btImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        #endregion
    }
}

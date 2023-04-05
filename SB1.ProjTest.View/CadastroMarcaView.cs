﻿using SB1.ProjTest.Controller;
using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SB1.ProjTest.View
{
    public partial class CadastroMarcaView : Form
    {
        public CadastroMarcaView()
        {
            InitializeComponent();
            ConsultaLista();
        }
        private void ConsultaLista()
        {
            try
            {
                BindingSource bindingSourceLista = MarcaController.Consultar(null);

                dgMarca.DataSource = bindingSourceLista;

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
                List<Marca> marca = new List<Marca>();
                foreach (DataGridViewRow linha in dgMarca.Rows)
                {
                    //se tiver algum valor no logradouro, grava o endereco,
                    //caso não apenas pula 
                    if (!string.IsNullOrEmpty(Convert.ToString(linha.Cells["marca"].Value)))
                    {
                        marca.Add(new Marca()
                        {

                            //adicionando os campos informados no grid, para os objetos da model
                            codigo = Convert.ToString(linha.Cells["codigo"].Value),
                            marca = Convert.ToString(linha.Cells["marca"].Value),
                            descricao = Convert.ToString(linha.Cells["descricao"].Value),
                            status = true,
                            dataInsercao = DateTime.Now,
                            dataAtualizacao = DateTime.Now,
                        });
                    }
                }
                if (MarcaController.Gravar(marca))
                {
                    string mensagem = "Sucesso ao gravar as marcas";
                    string titulo = "Sucesso.";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    MessageBox.Show(mensagem, titulo, botoes, icone);
                }
            }
            catch (Exception ex)
            {

                string mensagem = "Erro ao gravar as marcas. Erro: " + ex.Message;
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

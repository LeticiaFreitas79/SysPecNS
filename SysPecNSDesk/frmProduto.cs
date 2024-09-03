﻿using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarregaGrid(string nome = "")
        {
            //Preenchendo o DataGrid com os Produtos.
            var Lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in Lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[cont].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[cont].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[cont].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[cont].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[cont].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[cont].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[cont].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[cont].Cells[8].Value = produto.DataCad;
                cont++;
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            //Carregando o ComboBox de Categorias do Banco de Dados.
            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Sigla";

            CarregaGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                txtCodBar.Text,
                txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)dudEstoqueMinimo.Value,
                double.Parse(txtDesconto.Text)
                );
            produto.Inserir(); //As informações são gravadas no Banco (?)
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto gravado com sucesso com o ID {produto.Id}");
                FrmProduto_Load(sender, e);
            }
        }
    }
}
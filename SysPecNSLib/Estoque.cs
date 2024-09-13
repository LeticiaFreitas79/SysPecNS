using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {
        public int Id { get; set; }
        public Produto produto { get; set; }
        public string? Quantidade { get; set; }
        public DateTime? UltimaMovimentacao {  get; set; }

        //Todos os campos da tabela 'estoque'.
        public Estoque(int id, Produto produto, string? quantidade, DateTime? ultimamovimentacao)
        {
            Id = id;
            Produto = produto;
            Quantidade = quantidade;
            UltimaMovimentacao = ultimamovimentacao;
        }

        //Campos da tabela 'estoque', sem o campo Id.
        public Estoque(Produto produto, string? quantidade, DateTime? ultimamovimentacao)
        {
            Produto = produto;
            Quantidade = quantidade;
            UltimaMovimentacao = ultimamovimentacao;
        }

        //Nenhum campo da tabela 'estoque'.
        public Estoque()
        {

        }
     
        //Entrada de Produtos no Estoque. Uma nova quantidade de produtos será adicionada a quantidade atual.
        public void Inserir()
        {
            var cmd = Banco.Abrir(); //Chama o Banco de Dados.
            cmd.CommandType = CommandType.StoredProcedure; //Permite o use das StoredProcedures existentes no Banco de Dados.
            cmd.CommandText = "sp_estoque_insert"; //Chama a Stored Procedure referente a função a ser executada.
            //As linhas abaixo associam os campos no Banco de Dados com os campos do Formulário.
            cmd.Parameters.AddWithValue("id", Id);
            cmd.Parameters.AddWithValue("quantidade", Quantidade);
            cmd.Parameters.AddWithValue("UltimaMovimentacao", UltimaMovimentacao);
            var dr = cmd.ExecuteReader(); //Executa a função.
            cmd.Connection.Close();
        }

        //Saída de Produtos do Estoque. Uma quantidade de produtos será subtraída da quantidade atual.
        public void Saida()
        {

        }

        //Perda de Produtos do Estoque. Uma quantidade de produtos estragada deverá ser subtraída da quantidade atual do produto
        public void Perda()
        {

        }

        //Troca de Produtos do Estoque. Uma quantidade de produtos não sofre alteração, mas a movimentação no estoque é registrada.
        public void Troca()
        {

        }

        //Consultar os produtos em estoque através do ID.
        public static Estoque ObterPorId (int id)
        {
            Estoque estoque = new(); //Associa o tipo de dado com o nome do parâmetro.
            var cmd = Banco.Abrir(); //Chama o Banco de Dados.
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from estoque where id = {id}"; //Busca o ID no Banco de Dados.
            var dr = cmd.ExecuteReader(); //Executa a função.
            if (dr.Read())
            {
                estoque = new(
                    dr.GetInt32(0), //ID
                    dr.GetString(1), //Nome
                    dr.GetString(3), //Quantidade
                    dr.GetDateTime(4) //UltimaMovimentacao
                    );
            }
            cmd.Connection.Close();
            return estoque;
        }

        //Consulta por Lista.
        public static List<Estoque> ObterLista (string? nome = "")
        {
            List<Estoque> Lista = new(); //Nova lista.
            var comandosSQL = Banco.Abrir(); //Chama o Banco de Dados.
            comandosSQL.CommandType = CommandType.Text;
            if (nome == "") //Se o campo 'nome' estiver vazio, liste os produtos pelo nome.
            {
                comandosSQL.CommandText = "select * from estoque order by name"; //Busca as informações no na tabela do Banco de Dados em ordem alfabética.
            }
            else //Se o campo nome for preenchido, liste os produtos em estoque de acordo com o que foi preenchido no campo 'nome'.
            {
                comandosSQL.CommandText = $"select * from estoque where nome like '%{nome}%' order by nome"; 
            }
            return Lista;
        }

        //Atualiza Produto no Estoque.
        public void Atualizar()
        {
            var cmd = Banco.Abrir(); //Chama o Banco de Dados.
            cmd.CommandType = CommandType.StoredProcedure; //Permite o uso da StoredProcedure.
            cmd.CommandText = "sp_estoque_update"; //Chama a StoreProcedure.
            cmd.Parameters.AddWithValue("sp_produto_id", Id);
            cmd.Parameters.AddWithValue("sp_produto", Produto);
            cmd.Parameters.AddWithValue("sp_quantidade", Quantidade);
            cmd.Parameters.AddWithValue("sp_data_ultimo_movimento", UltimaMovimentacao);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}

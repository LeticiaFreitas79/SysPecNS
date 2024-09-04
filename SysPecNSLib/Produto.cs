using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace SysPecNSLib
{
    //
    public class Produto
    {
        public int Id { get; set; }
        public string? CodBar { get; set; }
        public string? Descricao { get; set; }
        public double ValorUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria? Categoria { get; set; }
        public double EstoqueMinimo { get; set; }
        public double ClasseDesconto { get; set; }
        public byte[]? Imagem { get; set; }
        public DateTime? DataCad { get; set; }
            
        //Sem Id.
        public Produto(string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria? Categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem, DateTime dataCad)
        {
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = Categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }

        //Imagem.
        public Produto(int id, string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria? Categoria, double estoqueMinimo, double classeDesconto, DateTime? dataCad)
        {
            Id = id;
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = Categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            DataCad = dataCad;
        }

        //Sem Id e DataCad
        public Produto(string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria? Categoria, double estoqueMinimo, byte[]? imagem, double classeDesconto, DateTime? dataCad)
        {
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = Categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
        }

        //Sem id, Imagem e DataCad
        public Produto(string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria? Categoria, double estoqueMinimo, double classeDesconto)
        {
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            this.Categoria = Categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;        
        }

        //Todos os campos
        public Produto(int id, string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria? Categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem, DateTime? dataCad)
        {
            Id = Id;
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = Categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }

        //Vazio
        public Produto()
        {

        }

        public void Inserir()
        {
            var cmd = Banco.Abrir(); //sem os (), é compreendido como uma variavel local, o que não pode acontecer.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBar);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Atualizar() //Não se deleta produto.
        {
            var cmd = Banco.Abrir(); 
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBar);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            cmd.ExecuteNonQuery();
        }

        public static Produto ObterPorId(int id)
        {
            Produto produto = new(); //É necessário um método construtor vazio para que essa função funcione.
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    null,
                    dr.GetDateTime(9)
                    );
            }
            return produto;
        }   
            
        public static List<Produto> ObterLista()
        {   
            List<Produto> produtos = new(); //É necessário um método construtor vazio para que essa função funcione
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos order by descricao";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add (new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    //(byte[])dr.GetValue(8), //alternativa ao null.
                    null,
                    dr.GetDateTime(9)
                    ));
            }
            return produtos;
        }
    }
}
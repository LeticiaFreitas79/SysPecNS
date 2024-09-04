using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace SysPecNSLib
{
    public class Categoria
    {
        public int Id { get; set; } //campo id inteiro.
        public string? Nome { get; set; } //campo nome 'varchar'
        public string? Sigla { get; set; } //campo sigla 'varchar'

        public Categoria() //sem parametros.
        {

        }
        public Categoria(string? nome, string? sigla) //parametros.
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria(int id, string? nome, string? sigla) //parametros.
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public Categoria(int id, string? nome) //parametros.
        {
            Id = id;
            Nome = nome;
        }

        public void Inserir() //método [...]
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static Categoria ObterPorId(int id) //método [...]; métodos estáticos não necessitam da criação de um objeto(????).
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias where id = {id}"; //interpolação($)
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categoria = new(dr.GetInt32(0), dr.GetString(1), null);
            }
            return categoria;
        }
        public static List<Categoria> ObterLista() //método [...]
        {
            List<Categoria> categorias = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from categorias";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) //while deve ser usado em listas.
            {
                categorias.Add(new(dr.GetInt32(0), dr.GetString(1), null));
            }
            return categorias;
        }

        public void Atualizar() //método [...]
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id); //parametro. //ctrl + espaço = completam. //ctrl + d = duplica a linha.
            cmd.Parameters.AddWithValue("spnome", Nome); //parametro.
            cmd.Parameters.AddWithValue("spsigla", Sigla); //parametro.
            cmd.ExecuteNonQuery(); //para executar.
        }
        public void Deletar() //método para que [...]
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete from categorias where id = {Id}";
            cmd.ExecuteNonQuery (); //para executar.
        }

    }
}

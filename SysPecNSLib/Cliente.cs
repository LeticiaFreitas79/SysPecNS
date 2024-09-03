using System; 
using System.Data; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Security.Cryptography; 
using MySql.Data.MySqlClient; 

namespace SysPecNSLib
{
    public class Cliente
    {
        //Metódo Construtor.
        public int ID {get; set;}
        public string? Nome {get; set;}
        public string? CPF { get; set;}
        public string? Telefone {get; set;}
        public string? Email { get; set;}
        public string? Data_Nasc {get; set;}
        public string? Data_Cad {get; set;}
        public bool Ativo {get; set;}
        public Cliente() { }
        //Todos os campos.
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, string? data_nasc, string? data_cad, bool ativo)
        {
            ID = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_nasc;
            Data_Cad = data_cad;
            Ativo = ativo;
        }

        //Sem ID.
        public Cliente(string? nome, string? cpf, string? telefone, string? email, string? data_nasc, string? data_cad, bool ativo)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_nasc;
            Data_Cad = data_cad;
            Ativo = ativo;
        }

        //Sem ID e Ativo.
        public Cliente(string? nome, string? cpf, string? telefone, string? email, string? data_nasc, string? data_cad)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_nasc;
            Data_Cad = data_cad;
        }

        //
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_Nasc);
            cmd.Parameters.AddWithValue("spdata_cad", Data_Cad);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ID = dr.GetInt32(0);
            }

        }
        //
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from cliente where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
              
            }
            return cliente;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Fornecedor
    {
        public int ID { get; set; } //Propriedades da Classe de acordo com os campos do Banco de Dados.
        public string? RazaoSocial { get; set; }
        public string? Fantasia { get; set; }
        public string? CNPJ { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }

        //Todos os Campos.
        public Fornecedor (int id, string? razaoSocial, string? fantasia, string? cnpj, string? contato, string? telefone, string? email) //Parametros recebidos pelos métodos.
        {
            ID = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        //Vazio.
        public Fornecedor()
        {
         
        }

        //Sem ID
        public Fornecedor (string? razaoSocial, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            RazaoSocial = razaoSocial; //Associação dos parametros com as propriedades da classe.
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        //Métodos
        public void Inserir() //Torna possivel inserir os dados nos campos do Formulário e consequentemente no Banco de Dados.
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_insert";
            cmd.Parameters.AddWithValue("sprazao_social", RazaoSocial);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", CNPJ);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            ID = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_update";
            cmd.Parameters.AddWithValue("spid", ID);
            cmd.Parameters.AddWithValue("sprazao_social", RazaoSocial);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", CNPJ);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.ExecuteNonQuery();
        }

        public static Fornecedor ObterPorId(int id) 
        {
            Fornecedor fornecedor = new(); //É necessário um método construtor vazio para que essa função funcione.
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from fornecedor where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                    );
            }
            return fornecedor;
        }

        public static List<Fornecedor> ObterLista() //Serve para retornar uma lista com todos os dados da tabela.
        {
            List<Fornecedor> fornecedor = new(); //É necessário um método construtor vazio para que essa função funcione
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from fornecedor order by id";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                    ));
            }
            return fornecedor;
        }


















    }
}

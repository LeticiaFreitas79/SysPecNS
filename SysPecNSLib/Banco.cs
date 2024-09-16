﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    /// <summary>
    /// Classe estática (não necessita declaração de instancia) de conexão de banco de dados MYSQL
    /// </summary>
    public static class Banco //classe de conexão de banco de dados
    {
        /// <summary>
        /// Método abrir da classe Banco é utilizado para representar comandos SQL 
        /// no servidor, cujos dados foram informados na string de conexão (strconn)
        /// </summary>
        /// <returns>Entrega um objeto de comandos SQL, que serão executados na conexão informada</returns>
        public static MySqlCommand Abrir() // método de conexão
        {
            // dados da conexão
            //string strconn = @"server=10.91.45.21;database=syspecdb;user=root;password=root"; //Banco de Dados Well1
            string strconn = @"server=10.91.46.26;database=syspecdb;user=root;password=root"; //Banco de Dados Well2
            //string strconn = @"server=127.0.0.1;database=syspecdb;user=root;password="; //Banco de Dados Pessoal
            //string strconn = @"server=10.91.45.20;database=syspecdb;user=root;password=root"; //Banco de Dados Atividade Prática Avaliativa
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlCommand cmd = new MySqlCommand();
            try // tratamento de excessão
            {
                cn.Open(); //se não funcionar, significa que o banco não está ligado.
                cmd.Connection = cn;
            }
            catch (Exception)
            {

                throw;
            }
            return cmd;
        }

    }
}

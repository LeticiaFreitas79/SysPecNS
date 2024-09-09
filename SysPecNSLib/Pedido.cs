using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Pedido
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data {  get; set; }
        public string Status { get; set; } //Algumas linguagens não permitem a utilização da palavra status, por considera-la uma palavra reservada.
        public double Desconto {  get; set; }
        public List<ItemPedido> Itens { get; set; } 

        //Vazio
        public Pedido()
        {
          
        }

        //Todos os Campos
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        //Sem ID
        public Pedido(Usuario usuario, Cliente cliente, DateTime data, string status, double desconto, List<ItemPedido> itens)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Itens = itens;
        }

        //Sem ID, Data e Status
        public Pedido(Usuario usuario, Cliente cliente, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Desconto = desconto;
        }

        public void Inserir() //Inserir pedido no banco. Permite a inserção de daddos nos campos do formulário.
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp.pedido_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.ID);
            cmd.Parameters.AddWithValue("usuario_id", Usuario.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }

        public void AlterarStatus() //Altera o status do pedido já inserido.
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update pedidos set status = {Status} where id = {Id}";
            cmd.ExecuteNonQuery();
        }

        public void AtualiarDesconto() //Altera o desconto do pedido já inserido.
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update pedidos set desconto = {Desconto} where id = {Id}";
            cmd.ExecuteNonQuery();
        }

        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from pedidos whore id = {id}";
            var dr = cmd.ExecuteReader(); //Retorna um registro ou nenhum registro.
            if (dr.Read())
            {
                pedido = new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5) //Incluir Lista de Itens.
                    //,ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    );

            }
            return pedido;
        }

        //Consulta geral.
        public static List<Pedido> ObterLista() //Para visualizar lista ordenada por cliente e/ou usuario.
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from pedidos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5) //Incluir Lista de Itens. //,ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    ));

            }
            return pedidos;
        }     

        /// <summary>
        /// Método [..]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Pedido> ObterListaPorCliente(int id) 
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from pedidos where cliente_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5) //Incluir Lista de Itens. //,ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    ));

            }
            return pedidos;
        }

        //Consulta por Usuário.
        public static List<Pedido> ObterListaPorUsuario(int id)
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from pedidos where usuario_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5) //Incluir Lista de Itens. //,ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    ));

            }
            return pedidos;
        }
    }
}

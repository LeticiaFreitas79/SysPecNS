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
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("usuario_id", Usuario.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }

        public void Alterar() //Altera o pedido já inserido.
        {
            Pedido pedido = new();

        }

        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();
            
            return pedido;
        }


        public static List<Pedido> ObterLista(int idCliente=0, int idUsuario=0) //Para visualizar lista ordenada por cliente e/ou usuario.
        {
            List<Pedido> pedidos = new();

            return pedidos;
        }
    }
}

using System;

namespace Bar.Models
{
  public class Pedido
  {
    public int IdPedido { get; set; }
    public int IdCliente { get; set; }
    /*
    public string NomeUsuario { get; set; }
    public string Cpf { get; set; }*/
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public int IdMesa { get; set; }
  }
}
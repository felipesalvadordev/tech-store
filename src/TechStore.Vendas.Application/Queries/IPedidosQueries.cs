using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechStore.Vendas.Application.Queries.ViewModels;

namespace TechStore.Vendas.Application.Queries
{
    public interface IPedidosQueries
    {
        Task<CarrinhoViewModel> ObterCarrinhoCliente(Guid clienteId);
        Task<IEnumerable<PedidoViewModel>> ObterPedidosCliente(Guid clienteId);
    }
}

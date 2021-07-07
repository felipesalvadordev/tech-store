using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TechStore.Vendas.Application.Commands;
using Moq.AutoMock;
using TechStore.Venda.Domain;
using System.Threading;
using Moq;

namespace TechStore.Vendas.Application.Tests
{
    public class PedidoCommandHandlerTests
    {
        private readonly Pedido _pedido;
        private readonly AutoMocker _mocker;
        private readonly PedidoCommandHandler _pedidoHandler;
        public PedidoCommandHandlerTests()
        {
            _mocker = new AutoMocker();
            _pedidoHandler = _mocker.CreateInstance<PedidoCommandHandler>();
            _pedido = Pedido.PedidoFactory.NovoPedidoRascunho(Guid.NewGuid());
        }

        [Fact(DisplayName = "Iniciar Pedido com Sucesso")]
        [Trait("Categoria", "Vendas - Pedido Command Handler")]
        public async Task IniciarPedido_DeveRetornarSucesso()
        {
            //Arrange
            var iniciarPedidoCommand = new IniciarPedidoCommand(Guid.NewGuid(), Guid.NewGuid(), 10, "cartão teste", "1234 5678 9012 3452", "12/29", "123");
            _mocker.GetMock<IPedidoRepository>().Setup(r => r.UnitOfWork.Commit()).Returns(Task.FromResult(true));
            //Act
            var result = await _pedidoHandler.Handle(iniciarPedidoCommand, CancellationToken.None);
            // Assert
            Assert.True(result);
            _mocker.GetMock<IPedidoRepository>().Verify(r => r.Atualizar(It.IsAny<Pedido>()), Times.Once);
            _mocker.GetMock<IPedidoRepository>().Verify(r => r.UnitOfWork.Commit(), Times.Once);
        }
    }
}

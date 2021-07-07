using System;
using System.Net.Http;
using System.Threading.Tasks;
using TechStore.Vendas.Application.Queries.ViewModels;
using TechStore.WebApp.Models;
using Xunit;

namespace TechStore.WebApp.Tests
{
    [Collection(nameof(IntegrationApiTestsFixtureCollection))]
    public class PedidoAPITest
    {
        private readonly IntegrationTestsFixtures<StartupApiTests> _testsFixture;

        public PedidoAPITest(IntegrationTestsFixtures<StartupApiTests> testsFixture)
        {
            _testsFixture = testsFixture;
        }

        [Fact(DisplayName = "Adicionar item em novo pedido")]
        [Trait("Categoria", "Integração API - Pedido")]
        public async Task AdicionarItem_NovoPedido_DeveRetornarComSucesso()
        {
            // Arrange
            var carrinhoItem = new CarrinhoViewModel
            {
                 ClienteId = Guid.NewGuid()
            };

            // Act
            var postResponse = await _testsFixture.Client.PostAsJsonAsync("/api/carrinho/pedidos", carrinhoItem);
            // Assert
            postResponse.EnsureSuccessStatusCode();
        }
    }
}

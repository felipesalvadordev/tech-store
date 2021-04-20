using System;
using TechStore.Core.DomainObjects;
using Xunit;

namespace TechStore.Catalogo.Domain.Tests
{
    public class ProdutoTest
    {
        [Fact]
        public void TesteProdutoSemNome()
        {
            var ex = Assert.Throws<DomainException>(() =>
               new Produto(string.Empty, "Descricao", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
           );

            Assert.Equal("O campo Nome do produto não pode estar vazio", ex.Message);
        }
    }
}

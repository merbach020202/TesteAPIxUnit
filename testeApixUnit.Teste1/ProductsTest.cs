using Moq;
using TesteParte2.Domains;
using TesteParte2.Interface;

namespace testeApixUnit.Teste1
{
    public class ProductsTest
    {
        //Indica que é o método de teste de unidade
        [Fact]
        public void Get()
        {
            //Arrange - Organizar (Cenário)

            var products = new List<Products>
            {
                new Products {IdProduct = Guid.NewGuid(), Name = "Produto 1", Price = 10},
                new Products {IdProduct = Guid.NewGuid(), Name = "Produto 1", Price = 10},
                new Products {IdProduct = Guid.NewGuid(), Name = "Produto 1", Price = 10}
            };


            //Cria um objeto de simulação do tipo ProductsRepository
            var mockRepository = new Mock<IProductsRepository>();

            //Configura o método GetProducts para retornar a lista de produtos "mock"
             mockRepository.Setup(x => x.GetProducts()).Returns(products);

            
            //Act - Agir

            //Chama o método GetProducts e armazena o resultado em result
            var result = mockRepository.Object.GetProducts();

            //Assert - Provar

            //Prova se o resultado esperado é igual ao resultado obtido

        }

        [Fact]

        public void
    }
}
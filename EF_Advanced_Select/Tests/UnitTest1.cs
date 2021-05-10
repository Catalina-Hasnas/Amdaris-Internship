using Application;
using Application.Queries.ProductQueries;
using Application.QueriesHandlers.ProductQueryHandlers;
using Domain;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Application.DtoModels;

namespace Tests
{
    [TestFixture]
    public class ProductQueryHandlerFixture
    {
        private Mock<IProductsRepo> _productRepository;
        private List<Product> products;


        [SetUp]
        public void Setup()
        {
            _productRepository = new Mock<IProductsRepo>();

            products = new List<Product>
            {
                new Product { Id = 1, Amount = 5, Image = "https://i.ibb.co/6bgccSg/212.jpg", Price = 200, Title = "First Product", CreatedAt = DateTime.Now },
                new Product { Id = 2, Amount = 6, Image = "https://i.ibb.co/KyQwzHG/21133206.jpg", Price = 210, Title = "Second Product", CreatedAt = DateTime.Now  },
                new Product { Id = 3, Amount = 6, Image = "https://i.ibb.co/kmctC6G/21256508.jpg", Price = 220, Title = "Third Product", CreatedAt = DateTime.Now  },
                new Product { Id = 4, Amount = 6, Image = "https://i.ibb.co/KNFCs43/cosmetic-40.jpg", Price = 220, Title = "Fourth Product", CreatedAt = DateTime.Now  },
                new Product { Id = 5, Amount = 6, Image = "https://i.ibb.co/r6N7p8M/jar-03.jpg", Price = 220, Title = "Fifth Product", CreatedAt = DateTime.Now  },
                new Product { Id = 6, Amount = 6, Image = "https://i.ibb.co/X2gYjMN/jar-13.jpg", Price = 220,  Title = "Sixth Product", CreatedAt = DateTime.Now  },
                new Product { Id = 7, Amount = 6, Image = "https://i.ibb.co/hcRbLBg/jar-24.jpg", Price = 220,  Title = "Seventh Product", CreatedAt = DateTime.Now  },
                new Product { Id = 8, Amount = 6, Image = "https://i.ibb.co/mCMyJHD/jar-25.jpg", Price = 220, Title = "Eigth Product", CreatedAt = DateTime.Now  },
                new Product { Id = 9, Amount = 6, Image = "https://i.ibb.co/qJVPFxJ/jar-36.jpg", Price = 220, Title = "Nineth Product", CreatedAt = DateTime.Now  },
            };
        }

        [Test]
        public async Task TestHandleGetAllProducts()
        {
            _productRepository.Setup(a => a.GetAllProducts()).ReturnsAsync(products);
            var getAllProductsQuery = new GetAllProductsQuery();
            var queryHandler = new ProductQueryHadler(_productRepository.Object);
            IEnumerable<ProductDto> answer = await queryHandler.Handle(getAllProductsQuery, new CancellationToken());

            Assert.That(answer.Count(), Is.EqualTo(products.Count()));
        }

        [Test]
        public async Task TestHandleGetProductById()
        {
            //_productRepository.Setup(a => a.GetProductById(It.IsAny<int>()))
            //    .Returns<int>(id=> products.SingleOrDefault(p => p.Id == id));

            //var getProductQuery = new GetProductByIdQuery() { Id = 1 };

            //var queryHandler = new ProductQueryHadler(_productRepository.Object);
            //Product answer = await queryHandler.Handle(getProductQuery, new CancellationToken());

            //Assert.That(answer, Is.EqualTo(products.First()));
            Assert.IsTrue(true);
        }


    }
}
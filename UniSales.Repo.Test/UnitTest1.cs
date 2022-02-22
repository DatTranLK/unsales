using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UniSales.Repository;
using UniSales.Repository.Entity;

namespace UniSales.Repo.Test
{
    [TestClass]
    public class UnitTest1
    {
        //#1: Test method Get (Get 1 Product):
        [TestMethod]
        public void TestGet()
        {
            ProductRepository productRepository = new ProductRepository();
            int price = 10000;
            Product product = productRepository.Get(1);
            Assert.AreEqual(product.Name, "Coca");
            Assert.AreEqual(product.Price, price);
            Assert.AreEqual(product.Description, "Qua da");
            Assert.AreEqual(product.Status, 99);
            Assert.AreEqual(product.CatId, 2);
        }


        //#2: Test method GetProducts (Get All Product):
        [TestMethod]
        public void TestGetProduct()
        {
            ProductRepository productRepository = new ProductRepository();

            List<Product> products = productRepository.GetProducts();
            Product firstproduct = products[0];
            Product lastproduct = products[products.Count - 1];
            int pricef = 10000;
            int pricel = 25;
            Assert.AreEqual(firstproduct.Name, "Coca");
            Assert.AreEqual(firstproduct.Price, pricef);
            Assert.AreEqual(firstproduct.Description, "Qua da");
            Assert.AreEqual(firstproduct.Status, 99);
            Assert.AreEqual(firstproduct.CatId, 2);

            Assert.AreEqual(lastproduct.Name, "Fish");
            Assert.AreEqual(lastproduct.Price, pricel);
            Assert.AreEqual(lastproduct.Description, "Good");
            Assert.AreEqual(lastproduct.Status, 10);
            Assert.AreEqual(lastproduct.CatId, 1);
        }

        
        //#3: Test method Create:
        [TestMethod]
        public void TestCreate()
        {
            Product product = new Product()
            {
                Name = "Fish",
                Price = 25,
                Description = "Good",
                Status = 10,
                CatId = 1
            };

            ProductRepository productRepository = new ProductRepository();
            productRepository.Create(product);

            List<Product> products = productRepository.GetProducts();
            Product lastproduct = products[products.Count - 1];
            Assert.AreEqual(product.Name, lastproduct.Name);
            Assert.AreEqual(product.Price, lastproduct.Price);
            Assert.AreEqual(product.Description, lastproduct.Description);
            Assert.AreEqual(product.Status, lastproduct.Status);
            Assert.AreEqual(product.CatId, lastproduct.CatId);
        }


        //#4: Test method Delete:
        [TestMethod]
        public void TestDelete()
        {
            ProductRepository productRepository = new ProductRepository();
            productRepository.Delete(5);

            Assert.AreEqual(productRepository.Get(5), null);
        }


        //#5: Test method Update:
        [TestMethod]
        public void TestUpdate()
        {
            Product product = new Product()
            {
                Id = 2,
                Name = "Big Fish",
                Price = 52,
                Description = "So Good",
                Status = 9,
                CatId = 1
            };

            ProductRepository productRepository = new ProductRepository();
            productRepository.Update(2, product);

            Product newproduct = productRepository.Get(2);
            Assert.AreEqual(product.Name, newproduct.Name);
            Assert.AreEqual(product.Price, newproduct.Price);
            Assert.AreEqual(product.Description, newproduct.Description);
            Assert.AreEqual(product.Status, newproduct.Status);
            Assert.AreEqual(product.CatId, newproduct.CatId);
        }
    }
}

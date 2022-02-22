using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSales.Repository;
using UniSales.Repository.Entity;

namespace UniSales.Repo.Test
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void TestGetOrders() {
            OrderRepository or = new OrderRepository();
            List<Orders> orders = or.GetOrders();
            Orders firstOrder = orders[0];
            
            Assert.AreEqual(firstOrder.CustomerName, "Thanh Khánh");
            Assert.AreEqual(firstOrder.Address, "Quận 7, TP Hồ Chí Minh");
            Assert.AreEqual(firstOrder.CreateDate, "11/01/2022");
            Assert.AreEqual(firstOrder.Status, 2);
        }
        [TestMethod]
        public void TestGet() {
            OrderRepository or = new OrderRepository();
            Orders order = or.Get(3);
            Assert.AreEqual(order.CustomerName, "Tiến Đại");
            Assert.AreEqual(order.Address, "Trảng Bom, Long Khánh");
            Assert.AreEqual(order.CreateDate, "11/01/2021");
            Assert.AreEqual(order.Status, 1);
        }
        [TestMethod]
        public void TestCreate()
        {
            Orders order = new Orders()
            {
                CustomerName = "Minh Hiếu",
                Address = "Hóc Môn, Củ Chi,TP Hồ Chí Minh",
                CreateDate = "11/01/2021",
                Status = 4
            };
            OrderRepository or = new OrderRepository();
            or.Create(order);

            List<Orders> orders = or.GetOrders();
            Orders lastOrder = orders[orders.Count - 1];
            Assert.AreEqual(order.CustomerName, lastOrder.CustomerName);
            Assert.AreEqual(order.Address, lastOrder.Address);
            Assert.AreEqual(order.CreateDate, lastOrder.CreateDate);
            Assert.AreEqual(order.Status, lastOrder.Status);

        }
        [TestMethod]
        public void TestDelete()
        {
            OrderRepository or = new OrderRepository();
            or.Delete(5);

            Assert.AreEqual(or.Get(5), null);
        }
        [TestMethod]
        public void TestUpdate() {
            Orders order = new Orders()
            {
                Id = 2,
                CustomerName = "Minh Huy",
                Address = "Quận Tân Bình, TP Hồ Chí Minh",
                CreateDate = "11/01/2021",
                Status = 5
            };
            OrderRepository or = new OrderRepository();
            or.Update(2, order);

            Orders newOrder = or.Get(2);
            Assert.AreEqual(order.CustomerName, newOrder.CustomerName);
            Assert.AreEqual(order.Address, newOrder.Address);
            Assert.AreEqual(order.CreateDate, newOrder.CreateDate);
            Assert.AreEqual(order.Status, newOrder.Status);
        }
    }
}

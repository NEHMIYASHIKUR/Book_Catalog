using System;
using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookCatalog;
using System.Linq;
using System.Collections.Generic;

namespace BookCatalogTest
{
    [TestClass]
    public class Book_Test
    {

        List<Book> Test_List = new List<Book>
            {
                new Book
                {
                    Id=1,
                    Title="Trial"                 
                }

            };

        [TestMethod]
        public void GetBooks()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<BookrepositoryInterface>()
                    .Setup(x => x.GetBooks())
                    .Returns(Test_List);

                var cls = mock.Create<BookrepositoryInterface>();

                var actual = cls.GetBooks().ToList();

                var expected =Test_List;

                Assert.IsTrue(actual != null);
                Assert.AreEqual(actual.Count, expected.Count);
            }
            
        }
    }
}

using System;
using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookCatalog;
using System.Linq;
using System.Collections.Generic;
using Moq;
using System.Windows.Input;
using System.Diagnostics;

namespace BookCatalogTest
{
    [TestClass]
    public class Book_Test
    {
        //   private List<Book> BookList()
        // {

            List<Book> Test_List = new List<Book>
            {
                new Book
                {
                    Id=1,
                    Title="Trial",
                    Release_Date="10-10-2012",
                    price="10",
                    Quantity=10
                },
                new Book
                {
                    Id=2,
                    Title="bb",
                    Release_Date="11-11-2012",
                    price="20",
                    Quantity=20
                },
                new Book
                {
                    Id=3,
                    Title="Trial3",
                    Release_Date="11-11-2012",
                    price="30",
                    Quantity=20
                },
                new Book
                {
                    Id=4,
                    Title="Trial4",
                    Release_Date="11-11-2012",
                    price="40",
                    Quantity=20
                }

            };
        // return Test_List;
        // }

        [TestMethod]
        public void DeleteBook()
        {
            var Delete_Id = 1;
            using (var mock = AutoMock.GetLoose())
            { 
                mock.Mock<BookrepositoryInterface>()
                  .Setup(o => o.DeleteBook(It.IsAny<int>()))
                  .Callback<int>(x => Test_List.Remove(Test_List.FirstOrDefault(y => y.Id == x)))
                 .Returns(Test_List.FirstOrDefault(y => y.Id == Delete_Id));


                var cls = mock.Create<BookrepositoryInterface>();
                var Deleted_Book = cls.DeleteBook(Delete_Id);

                Assert.IsNotNull(Deleted_Book);

                Assert.IsNull(Test_List.FirstOrDefault(x => x.Id == Delete_Id));
                

            }
        }
        // works just fine
        [TestMethod]
        public void Search()
        {
            String input = "10";
            List<Book> searchedbooks = new List<Book>();
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<BookrepositoryInterface>()
                   .Setup(o => o.SearchBook(It.IsAny<String>()))
                   .Callback<String>(x => Test_List.Add(Test_List.FirstOrDefault(y => y.Title == x || y.price == x)))
                   .Returns(Test_List);

                var cls = mock.Create<BookrepositoryInterface>();

                cls.SearchBook(input);

                var actual = cls.SearchBook(input);

                Assert.IsNotNull(actual);

               // Assert.AreEqual(Test_List.Count, actual.Count);

            }
        }

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

                var expected = Test_List;

                Assert.IsTrue(actual != null);
                Assert.AreEqual(actual.Count, expected.Count);
            }

        }

        [TestMethod]
        public void AddBooks()
        {
            Book book = Test_List[0];

            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<BookrepositoryInterface>()
                    .Setup(x => x.AddBook(book))
                    .Returns(Test_List[0]);

                var cls = mock.Create<BookrepositoryInterface>();

                var actual = cls.AddBook(book);

                Assert.IsNotNull(actual);

                List<Book> book2= cls.GetBooks().ToList();
                var expected2 =book2.Where(x =>x.Id == actual.Id).ToList();

                Assert.IsNotNull(expected2);
                
            }
        }


        //[TestMethod]
        //public void AddBooks()
        //{
        //    Book book = Test_List[0];

        //    using (var mock = AutoMock.GetLoose())
        //    {
        //        mock.Mock<BookrepositoryInterface>()
        //            .Setup(x => x.AddBook(book))
        //            .Returns(book);

        //        var cls = mock.Create<BookrepositoryInterface>();

        //        var actual = cls.AddBook(book);

        //        var expected = book;

        //        Assert.IsNotNull(actual);

        //        Assert.AreEqual(actual, expected);

        //    }
        //}

        //[TestMethod]
        //public void DeleteBook()
        //{
        //    using (var mock = AutoMock.GetLoose())
        //    {
        //        mock.Mock<BookrepositoryInterface>()
        //          .Setup(o => o.DeleteBook(It.IsAny<int>()))
        //          .Callback<int>(x => Test_List.Remove(Test_List.FirstOrDefault(y => y.Id == x)));

        //        var cls = mock.Create<BookrepositoryInterface>();

        //        cls.DeleteBook(Addbookid());

        //        Assert.AreEqual(3, Test_List.Count);
        //        Assert.IsNull(Test_List.FirstOrDefault(x => x.Id == 1));

        //    }
        //}

    }
}

using System;
using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookCatalog;
using System.Linq;
using System.Collections.Generic;
using Moq;

namespace BookCatalogTest
{
    [TestClass]
    public class Author_Test
    {

      //  private List<Author> AuthorsList()
     //   {
            List<Author> Test_List = new List<Author>
            {
                new Author
                {
                    Id=1,
                    Author_Name="Nehmiya",
                    Nationality="Ethiopia",
                    Gender="Male"
                },
                new Author
                {
                    Id=2,
                    Author_Name="Steve",
                    Nationality="America",
                    Gender="Male"
                },
                new Author
                {
                    Id=3,
                    Author_Name="Gosha",
                    Nationality="Poland",
                    Gender="Female"
                }
            };
        //  return output;
        //   }

        [TestMethod]
        public void DeleteBook()
        {
            var Delete_Id = 1;
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<AuthorRepositoryInterface>()
                  .Setup(o => o.DeleteAuthor(It.IsAny<int>()))
                  .Callback<int>(x => Test_List.Remove(Test_List.FirstOrDefault(y => y.Id == x)))
                 .Returns(Test_List.FirstOrDefault(y => y.Id == Delete_Id));


                var cls = mock.Create<AuthorRepositoryInterface>();
                var Deleted_Book = cls.DeleteAuthor(Delete_Id);

                Assert.IsNotNull(Deleted_Book);

                Assert.IsNull(Test_List.FirstOrDefault(x => x.Id == Delete_Id));


            }
        }
        [TestMethod]
        public void LoadAuthors()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<AuthorRepositoryInterface>()
                    .Setup(x => x.GetAuthors())
                    .Returns(Test_List);

                var cls = mock.Create<AuthorRepositoryInterface>();

                var actual = cls.GetAuthors().ToList();

                var expected = Test_List;

                Assert.IsTrue(actual != null);
                Assert.AreEqual(actual.Count, expected.Count);
            }
        }

        [TestMethod]
        public void AddAuthors()
        {
            Author author = Test_List[0];

            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<AuthorRepositoryInterface>()
                    .Setup(x => x.AddAuthor(author))
                    .Returns(author);

                var cls = mock.Create<AuthorRepositoryInterface>();

                var actual = cls.AddAuthor(author);

                var expected = author;

                Assert.IsTrue(actual != null);
                Assert.AreEqual(actual,expected);
            }
        }

        [TestMethod]
        public void GetAuthorId()
        {
            List<int> List2 = new List<int> {};

            Mock<AuthorRepositoryInterface> mock = new Mock<AuthorRepositoryInterface>();

            mock.Setup(x => x.GetAuthorId())
                .Returns(List2);

            mock.Object.GetAuthorId();

            var actual = mock.Object.GetAuthorId();

            Assert.IsNotNull(actual);
            mock.Verify(a => a.GetAuthorId(), Times.AtLeastOnce);            
        }

    }
}
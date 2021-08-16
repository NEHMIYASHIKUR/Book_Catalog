using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookCatalog;
using Autofac.Extras.Moq;
using System.Collections.Generic;
using System.Linq;

namespace BookCatalogTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void LoadAuthors()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<AuthorRepositoryInterface>()
                    .Setup(x => x.GetAuthors())
                    .Returns(GetAuthors());

                var cls = mock.Create<AuthorRepository>();

                var expected = GetAuthors();

                var actual = cls.GetAuthors();
                //Assert.IsTrue(actual != null);
                Assert.c(expected, actual.ToList());
            }
        }

        private List<Author> GetAuthors()
        {
            List<Author> output = new List<Author>
            {
                new Author
                {
                    Id=1,
                    Author_Name = "Nehmiya",
                    Nationality="Ethiopia",
                    Gender="Male"
                },
                new Author
                {
                    Id=2,
                    Author_Name="Robert Angel",
                    Nationality="America",
                    Gender="Male"
                },
                new Author
                {
                    Id=3,
                    Author_Name="Jim Carrey",
                    Nationality="America",
                    Gender="Male"
                }
            };
            return output;
        }
    }
}
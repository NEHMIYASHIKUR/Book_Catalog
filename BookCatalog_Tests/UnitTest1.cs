using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookCatalog;
using Autofac.Extras.Moq;
using System.Collections.Generic;

namespace BookCatalog_Tests
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

                Assert.IsTrue(actual != null);
              //  Assert.AreEqual(expected, actual);
            }
        }

        private List<Author> GetAuthors()
        {
            List<Author> output = new List<Author>
            {
                new Author
                {
                    Id=1,
                    Author_Name = "Jhon",
                    Nationality="Germany",
                    Gender="Male"
                },
                new Author
                {
                    Id=2,
                    Author_Name="Steven",
                    Nationality="America",
                    Gender="Male"
                }
            };
            return output;
        }
    }
}

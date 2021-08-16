using System;
using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookCatalog;
using System.Linq;
using System.Collections.Generic;

namespace BookCatalogTest
{
    [TestClass]
    public class UnitTest1
    {
       
        List<Author> Test_List = new List<Author>
            {
                new Author
                {
                    Id=1,
                    Author_Name="Nehmiya",
                    Nationality="Ethiopia",
                    Gender="Male"
                }
                
            };

        [TestMethod]
        public void LoadAuthors()
        {
            using (var mock= AutoMock.GetLoose())
            {
                mock.Mock<AuthorRepositoryInterface>()
                    .Setup(x => x.GetAuthors())
                    .Returns(Test_List);

                var cls = mock.Create<AuthorRepositoryInterface>();

                var actual = cls.GetAuthors().ToList();

                var expected = Test_List;

                Assert.IsTrue(actual!= null);     

                Assert.AreEqual(actual.Count , expected.Count);
            }
        }

        //private List<Author> AuthorsList()
        //{
        //    List<Author> output = new List<Author>
        //    {
        //        new Author
        //        {
        //            Id=1,
        //            Author_Name="Nehmiya",
        //            Nationality="Ethiopia",
        //            Gender="Male"
        //        },
        //        new Author
        //        {
        //            Id=1,
        //            Author_Name="Nehmiyaa",
        //            Nationality="Ethiopia",
        //            Gender="Male"
        //        },
        //        new Author
        //        {
        //            Id=1,
        //            Author_Name="Nehmiyaaa",
        //            Nationality="Ethiopia",
        //            Gender="Male"
        //        }
        //    };
        //    return output;
        //}



    }
}

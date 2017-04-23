using Itech.Data.Infrastructure;
using Itech.Data.Repositories;
using Itech.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Itech.Unit.RepositoryTest
{
    [TestClass]
    public class BrandRepositoryTest
    {
         IDbFactory dbFactory;
         IBrandRepository objRepository;
         IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new BrandRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }


        [TestMethod]
        public void Brand_Repository_GetAll()
        {
            var listBrand = objRepository.GetAll().ToList();


            Assert.IsNotNull(listBrand);
            Assert.AreEqual(1, listBrand.Count());
 
        }

        [TestMethod]
        public void Brand_Repository_Add()
        {
            Brand brand = new Brand();
            brand.Name = "Sony";
            brand.Alias = "so-ny";
            brand.status = true;
             
            var result = objRepository.Add(brand);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
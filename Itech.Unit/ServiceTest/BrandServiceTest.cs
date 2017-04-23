using Itech.Data.Infrastructure;
using Itech.Data.Repositories;
using Itech.Model.Models;
using Itech.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech.Unit.ServiceTest
{
    [TestClass]
    public class BrandServiceTest
    {
        Mock<IBrandRepository> _mockBrandRepository;
        Mock<IUnitOfWork> _mockUnitOfWork;
        IBrandService _brandService;
        List<Brand> _listBrand;

        [TestInitialize]
        public void Initialize()
        {
            _mockBrandRepository = new Mock<IBrandRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _brandService = new BrandService(_mockBrandRepository.Object, _mockUnitOfWork.Object);
            _listBrand = new List<Brand>()
            {
                new Brand() {ID=1 ,Name="Sony", Alias="so-ny",status=true},
                new Brand() {ID=2 ,Name="LG", Alias="lg",status=false},
                new Brand() {ID=3 ,Name="SamSung", Alias="sam-sung",status=true}
            };
        }

        [TestMethod]
        public void Brand_Service_GetAll()
        {
            _mockBrandRepository.Setup(m => m.GetAll(null)).Returns(_listBrand);

            var result =_brandService.GetAll() as List<Brand>;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }
    }
}

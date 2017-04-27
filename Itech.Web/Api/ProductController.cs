using AutoMapper;
using Itech.Model.Models;
using Itech.Service;
using Itech.Web.Infrastructure.Core;
using Itech.Web.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Itech.Web.Infrastructure.Extensions;

namespace Itech.Web.App_Data
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiControllerBase
    {
        private IProductService _productService;

        public ProductController(IErrorService errorService, IProductService productService) : base(errorService)
        {
            this._productService = productService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                var listProduct = _productService.GetAll();
                var listProductVm = Mapper.Map<List<ProductViewModel>>(listProduct);

                response = request.CreateResponse(HttpStatusCode.OK, listProductVm);
                return response;
            });
        }
        [Route("Add")]
        public HttpResponseMessage Post(HttpRequestMessage request, ProductViewModel productVM)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    Product newProduct = new Product();
                    newProduct.UpdateProduct(productVM);

                    var product = _productService.Add(newProduct);
                    _productService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, product);

                }
                return response;
            });
        }


        [Route("Update")]
        public HttpResponseMessage Put(HttpRequestMessage request, ProductViewModel productVM)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var productDB = _productService.GetByID(productVM.ID);
                    productDB.UpdateProduct(productVM);

                    _productService.Update(productDB);
                    _productService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }

        [Route("Delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request, int productID)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _productService.Delete(productID);
                    _productService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
    }
}
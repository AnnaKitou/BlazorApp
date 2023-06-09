﻿using BlazorProducts.Server.Features;
using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
	public interface IProductHttpRepository
	{
		Task<PagingResponse<Product>> GetProducts(ProductParameters productParameters);
		Task<Product> GetProduct(Guid id);
		Task CreateProduct(Product product);
		Task<string> UploadProductImage(MultipartFormDataContent content);
		Task UpdateProduct(Product product);
		Task DeleteProduct(Guid id);
	}
}

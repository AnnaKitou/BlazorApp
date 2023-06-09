﻿using BlazorProducts.Server.Features;
using Entities.Configuration;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
    public class ProductHttpRepository : IProductHttpRepository
    {
        private readonly HttpClient _client;
        private readonly NavigationManager _navManager;
        private readonly ApiConfiguration _apiConfiguration;
        private readonly JsonSerializerOptions _options =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public ProductHttpRepository(HttpClient client, NavigationManager navManager, IOptions<ApiConfiguration> configuration)
        {
            _client = client;
            _navManager = navManager;
            _apiConfiguration = configuration.Value;
        }

        public async Task CreateProduct(Product product) => await _client.PostAsJsonAsync("products", product);


        public async Task<Product> GetProduct(Guid id)
        {
            var product = await _client.GetFromJsonAsync<Product>($"products/{id}");

            return product;
        }

        public async Task<PagingResponse<Product>> GetProducts(ProductParameters productParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = productParameters.PageNumber.ToString(),
                ["pageSize"] = productParameters.PageSize.ToString(),
                ["searchTerm"] = productParameters.SearchTerm == null ? "" : productParameters.SearchTerm,
                ["orderBy"] = productParameters.OrderBy == null ? "" : productParameters.OrderBy
            };

            var response =
                await _client.GetAsync(QueryHelpers.AddQueryString("products", queryStringParam));

            var content = await response.Content.ReadAsStringAsync();

            var pagingResponse = new PagingResponse<Product>
            {
                Items = JsonSerializer.Deserialize<List<Product>>(content, _options),
                MetaData = JsonSerializer.Deserialize<MetaData>(
                        response.Headers.GetValues("X-Pagination").First(), _options)
            };

            return pagingResponse;
        }

        public async Task UpdateProduct(Product product) => await _client
            .PutAsJsonAsync(Path.Combine("products",
                product.Id.ToString()), product);
        public async Task DeleteProduct(Guid id) => await _client
            .DeleteAsync(Path.Combine("products",
                id.ToString()));

        public async Task<string> UploadProductImage(MultipartFormDataContent content)
        {
            var postResult = await _client.PostAsync("upload", content);
            var postContent = await postResult.Content.ReadAsStringAsync();
            var imgUrl = Path.Combine(_apiConfiguration.BaseAddress, postContent);

            return imgUrl;
        }
    }
}

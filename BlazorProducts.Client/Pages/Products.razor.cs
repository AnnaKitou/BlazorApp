﻿using BlazorProducts.Client.HttpInterceptor;
using BlazorProducts.Client.HttpRepository;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class Products : IDisposable
    {
        public List<Product> ProductList { get; set; } = new List<Product>();
        public MetaData MetaData { get; set; } = new MetaData();

        private ProductParameters _productParameters = new ProductParameters();

        [Inject]
        public IProductHttpRepository ProductRepo { get; set; }
        [Inject]
        public HttpInterceptorService Interceptor { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Interceptor.RegisterEvent();
            Interceptor.RegisterBeforeSendEvent();
            await GetProducts();

        }

        private async Task SelectedPage(int page)
        {
            _productParameters.PageNumber = page;
            await GetProducts();
        }

        private async Task GetProducts()
        {
            var pagingResponse = await ProductRepo.GetProducts(_productParameters);

            ProductList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        private async Task SetPageSize(int pageSize)
        {
            _productParameters.PageSize = pageSize;
            _productParameters.PageNumber = 1;

            await GetProducts();
        }

        private async Task SearchChanged(string searchTerm)
        {
            _productParameters.PageNumber = 1;
            _productParameters.SearchTerm = searchTerm;

            await GetProducts();
        }

        private async Task SortChanged(string orderBy)
        {
            _productParameters.OrderBy = orderBy;

            await GetProducts();
        }

        private async Task DeleteProduct(Guid id)
        {
            await ProductRepo.DeleteProduct(id);

            if (_productParameters.PageNumber > 1 && ProductList.Count == 1)
                _productParameters.PageNumber--;

            await GetProducts();
        }
        public void Dispose() => Interceptor.DisposeEvent();
    }
}

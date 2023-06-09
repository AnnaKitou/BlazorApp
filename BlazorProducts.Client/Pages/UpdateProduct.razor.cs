﻿using Blazored.Toast.Services;
using BlazorProducts.Client.HttpInterceptor;
using BlazorProducts.Client.HttpRepository;
using Entities.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
	public partial class UpdateProduct : IDisposable
	{
		private Product _product;
		private EditContext _editContext;
		private bool formInvalid = true;


		[Parameter]
		public Guid Id { get; set; }

		[Inject]
		public IProductHttpRepository ProductRepo { get; set; }

		[Inject]
		public HttpInterceptorService Interceptor { get; set; }

		[Inject]
		public IToastService ToastService { get; set; }

		protected override async Task OnInitializedAsync()
		{
			_product = await ProductRepo.GetProduct(Id);
			_editContext = new EditContext(_product);
			_editContext.OnFieldChanged += HandleFieldChanged;
			Interceptor.RegisterEvent();
		}

		private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
		{
			formInvalid = !_editContext.Validate();
			StateHasChanged();
		}

		private async Task Update()
		{
			await ProductRepo.UpdateProduct(_product);

			ToastService.ShowSuccess($"Action successful. " +
				$"Product \"{_product.Name}\" successfully updated.");
			_product = new Product();
	
		}


		private void AssignImgUrl(string imgUrl) => _product.ImageUrl = imgUrl;
		public void Dispose()
		{
			Interceptor.DisposeEvent();
			_editContext.OnFieldChanged -= HandleFieldChanged;
		}
	}
}

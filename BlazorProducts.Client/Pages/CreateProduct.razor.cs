using BlazorProducts.Client.HttpInterceptor;
using BlazorProducts.Client.HttpRepository;
using Entities.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class CreateProduct : IDisposable
    {
        private Product _product { get; set; } = new Product();
        private EditContext _editContext;
        private bool formInvalid = true;

        [Inject]
        public IProductHttpRepository ProductRepo { get; set; }
        [Inject]
        private HttpInterceptorService Interceptor { get; set; }


        protected override void OnInitialized()
        {
            _editContext = new EditContext(_product);
            _editContext.OnFieldChanged += HandleFieldChanged;
            Interceptor.RegisterEvent();
        }

        private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private async Task Create()
        {
            formInvalid = !_editContext.Validate();
            StateHasChanged();  
        }

        public void Dispose() => Interceptor.DisposeEvent();
    }
}

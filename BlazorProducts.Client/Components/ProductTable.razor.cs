using BlazorProducts.Client.Shared;
using Entities.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Components
{
    public partial class ProductTable
    {
        [Parameter]
        public List<Product> Products { get; set; }

        [Parameter]
        public EventCallback<Guid> OnDelete { get; set; }

        private Confirmation _confirmation;
        private Guid _productToDelete;
        private void CallConfirmationModal(Guid id)
        {
            _productToDelete = id;
            _confirmation.Show();
        }

        private async Task DeleteProduct()
        {
            _confirmation.Hide();
            await OnDelete.InvokeAsync(_productToDelete);
        }
    }
}

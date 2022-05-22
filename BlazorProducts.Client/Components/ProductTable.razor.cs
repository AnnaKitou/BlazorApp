using Entities.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace BlazorProducts.Client.Components
{
    public partial class ProductTable
    {
        [Parameter]
        public List<Product> Products { get; set; }

        [Parameter]
        public EventCallback<Guid> OnDelete { get; set; }
    }
}

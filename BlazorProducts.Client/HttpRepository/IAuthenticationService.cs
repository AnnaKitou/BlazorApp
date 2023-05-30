﻿using Entities.DTO;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
    public interface IAuthenticationService
    {
        Task<ResponseDto> RegisterUser(UserForRegistrationDto userForRegistrationDto);
    }
}

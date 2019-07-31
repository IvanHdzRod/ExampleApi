using ExampleApi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.Services
{
    public interface IAuthenticateService
    {
        bool IsAuthenticated(TokenRequestDTO request, out string token);
    }
}

﻿using System.IdentityModel.Tokens;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core.Connect.Models;
using Thinktecture.IdentityServer.Core.Services;

namespace Thinktecture.IdentityServer.Core.Connect.Services
{
    public interface ITokenService
    {
        Token CreateIdentityToken(ValidatedAuthorizeRequest request, ClaimsPrincipal user);
        Token CreateIdentityToken(ValidatedTokenRequest request, ClaimsPrincipal client);

        Token CreateAccessToken(ValidatedAuthorizeRequest request, ClaimsPrincipal user);
        Token CreateAccessToken(ValidatedTokenRequest request, ClaimsPrincipal client);

        string CreateJsonWebToken(Token token, SigningCredentials credentials);
    }
}
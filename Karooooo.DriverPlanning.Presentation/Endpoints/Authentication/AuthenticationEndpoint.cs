using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Karooooo.Common.Http.RestClients.AccessManagement;
using Karooooo.DriverPlanning.Presentation.Contracts;

namespace Karooooo.DriverPlanning.Presentation.Endpoints.Authentication
{
    [HttpPost("diagnostcs/authenticate"), AllowAnonymous]
    public sealed class AuthenticationEndpoint(IAccessManagementWebApi accessManagement): Endpoint<Credentials>
    {
        public override async Task HandleAsync(Credentials credentials, CancellationToken cancellationToken)
        {
            var res = await accessManagement.AuthenticateSendingSystem(new Common.Http.RestClients.AccessManagement.Contracts.SendingSystemCredentials { ApiKey = credentials.ApiKey }, cancellationToken);

            res.ThrowIfFailure();

            await SendOkAsync(res.Value, cancellationToken).ConfigureAwait(false);
        }
    }
}

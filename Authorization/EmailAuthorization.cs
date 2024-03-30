using Microsoft.AspNetCore.Authorization;

namespace Gerenciador.Authorization
{
    public class EmailAuthorization : AuthorizationHandler<EmailConfirm>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EmailConfirm requirement)
        {
            var emailClaim = context.User.FindFirst(claim => claim.Type == "emailconfirmed");
            if (emailClaim is null)
            {
                return Task.CompletedTask;
            }

            var emailConfirmValue = Convert.ToBoolean(emailClaim.Value);

            if (emailConfirmValue == requirement.EmailConfirmValue)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}

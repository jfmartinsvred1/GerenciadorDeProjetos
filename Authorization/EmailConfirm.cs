using Microsoft.AspNetCore.Authorization;

namespace Gerenciador.Authorization
{
    public class EmailConfirm:IAuthorizationRequirement
    {
        public EmailConfirm(bool emailConfirmValue)
        {
            EmailConfirmValue = emailConfirmValue;
        }

        public bool EmailConfirmValue { get; set; }



    }
}

using Gerenciador.Data;
using Gerenciador.Models;

namespace Gerenciador.Services
{
    public class EmailService
    {
        GerenciadorContext _context;

        public EmailService(GerenciadorContext context)
        {
            _context = context;
        }
        public void SaveCode(string code,string email)
        {
            ValidationEmail validation = new ValidationEmail();
            validation.Code = code;
            validation.Email = email;
            _context.ValidationEmails.Add(validation);
            _context.SaveChanges();
        }
        public bool VerifyCode(string code,string email)
        {
            var validator =_context.ValidationEmails.FirstOrDefault(x => x.Code == code);
            if (validator.Email == email && validator != null)
            {
                _context.ValidationEmails.Remove(validator);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

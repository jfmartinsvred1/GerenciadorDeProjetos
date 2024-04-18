namespace Gerenciador.Models
{
    public class ValidationEmail
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; }
        public string Code { get; set; }
    }
}

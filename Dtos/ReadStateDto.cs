using System.ComponentModel.DataAnnotations;

namespace Gerenciador.Dtos
{
    public class ReadStateDto
    {
        public string StateId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

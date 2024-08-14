using System.ComponentModel.DataAnnotations;

namespace AgendaTelefonicaWeb.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Numero { get; set; }
    }
}

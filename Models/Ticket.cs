using System;
using System.ComponentModel.DataAnnotations;

namespace ChamadosTecnicos.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string? Titulo { get; set; }

        [Required]
        public string? Descricao { get; set; }

        public string Status { get; set; } = "Aberto";

        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}

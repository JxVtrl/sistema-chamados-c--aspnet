using Microsoft.AspNetCore.Identity;

namespace ChamadosTecnicos.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Campos extras (opcional)
        public string? NomeCompleto { get; set; }
    }
}

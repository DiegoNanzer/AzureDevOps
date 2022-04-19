using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDevOps.Domain
{
    public class Smurf
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Campo deve ter no mínimo 3 caracteres.")]
        public string Name { get; set; }

        public int Idade { get; set; } = 0;
    }
}

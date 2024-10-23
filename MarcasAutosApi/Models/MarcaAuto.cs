using System.ComponentModel.DataAnnotations;

namespace MarcasAutosApi.Models
{
    public class MarcaAuto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}

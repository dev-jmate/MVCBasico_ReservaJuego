using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCBasico_ReservaJuego.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NroCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Dni { get; set; }
        public string? Email { get; set; }
        public int Telefono { get; set; }
        public string? JuegoReservado { get; set; } //Acá se cambió el tipo de dato para que funcionase con la consola 

    }

}

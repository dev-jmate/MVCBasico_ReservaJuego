using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCBasico_ReservaJuego.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReserva { get; set; }
        public int IdJuego { get; set; } //No nos deja con la clase Juego, lo cambiamos a int
        public int NroCliente { get; set; } //No nos deja con la clase Cliente, lo cambiamos a int
    }
  
}
